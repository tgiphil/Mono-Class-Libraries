//
// System.Net.ServicePointManager
//
// Author:
//   Lawrence Pit (loz@cable.a2000.nl)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;

#if NET_2_0
using System.Globalization;
using System.Net.Security;
#if SECURITY_DEP
using System.Text.RegularExpressions;
using Mono.Security;
using Mono.Security.Cryptography;
using Mono.Security.X509.Extensions;
#endif
#endif

//
// notes:
// A service point manager manages service points (duh!).
// A service point maintains a list of connections (per scheme + authority).
// According to HttpWebRequest.ConnectionGroupName each connection group
// creates additional connections. therefor, a service point has a hashtable
// of connection groups where each value is a list of connections.
// 
// when we need to make an HttpWebRequest, we need to do the following:
// 1. find service point, given Uri and Proxy 
// 2. find connection group, given service point and group name
// 3. find free connection in connection group, or create one (if ok due to limits)
// 4. lease connection
// 5. execute request
// 6. when finished, return connection
//


namespace System.Net 
{
	public class ServicePointManager
	{
		class SPKey {
			Uri uri; // schema/host/port
			bool use_connect;

			public SPKey (Uri uri, bool use_connect) {
				this.uri = uri;
				this.use_connect = use_connect;
			}

			public Uri Uri {
				get { return uri; }
			}

			public bool UseConnect {
				get { return use_connect; }
			}

			public override int GetHashCode () {
				return uri.GetHashCode () + ((use_connect) ? 1 : 0);
			}

			public override bool Equals (object obj) {
				SPKey other = obj as SPKey;
				if (obj == null) {
					return false;
				}

				return (uri.Equals (other.uri) && other.use_connect == use_connect);
			}
		}

		private static HybridDictionary servicePoints = new HybridDictionary ();
		
		// Static properties
		
		private static ICertificatePolicy policy = new DefaultCertificatePolicy ();
		private static int defaultConnectionLimit = DefaultPersistentConnectionLimit;
		private static int maxServicePointIdleTime = 900000; // 15 minutes
		private static int maxServicePoints = 0;
		private static bool _checkCRL = false;
		private static SecurityProtocolType _securityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

#if NET_1_1
#if TARGET_JVM
		static bool expectContinue = false;
#else
		static bool expectContinue = true;
#endif
		static bool useNagle;
#endif
#if NET_2_0
		static RemoteCertificateValidationCallback server_cert_cb;
#endif

		// Fields
		
		public const int DefaultNonPersistentConnectionLimit = 4;
		public const int DefaultPersistentConnectionLimit = 2;

#if !MONOTOUCH
		const string configKey = "system.net/connectionManagement";
		static ConnectionManagementData manager;
#endif
		
		static ServicePointManager ()
		{
#if !MONOTOUCH
#if NET_2_0 && CONFIGURATION_DEP
			object cfg = ConfigurationManager.GetSection (configKey);
			ConnectionManagementSection s = cfg as ConnectionManagementSection;
			if (s != null) {
				manager = new ConnectionManagementData (null);
				foreach (ConnectionManagementElement e in s.ConnectionManagement)
					manager.Add (e.Address, e.MaxConnection);

				defaultConnectionLimit = (int) manager.GetMaxConnections ("*");				
				return;
			}
#endif
			manager = (ConnectionManagementData) ConfigurationSettings.GetConfig (configKey);
			if (manager != null) {
				defaultConnectionLimit = (int) manager.GetMaxConnections ("*");				
			}
#endif
		}

		// Constructors
		private ServicePointManager ()
		{
		}		
		
		// Properties
		
#if NET_2_0
		[Obsolete ("Use ServerCertificateValidationCallback instead",
			   false)]
#endif
		public static ICertificatePolicy CertificatePolicy {
			get { return policy; }
			set { policy = value; }
		}

#if NET_1_0
		// we need it for SslClientStream
		internal
#else
		[MonoTODO("CRL checks not implemented")]
		public
#endif
		static bool CheckCertificateRevocationList {
			get { return _checkCRL; }
			set { _checkCRL = false; }	// TODO - don't yet accept true
		}
		
		public static int DefaultConnectionLimit {
			get { return defaultConnectionLimit; }
			set { 
				if (value <= 0)
					throw new ArgumentOutOfRangeException ("value");

				defaultConnectionLimit = value; 
			}
		}

#if NET_2_0
		static Exception GetMustImplement ()
		{
			return new NotImplementedException ();
		}
		
		[MonoTODO]
		public static int DnsRefreshTimeout
		{
			get {
				throw GetMustImplement ();
			}
			set {
				throw GetMustImplement ();
			}
		}
		
		[MonoTODO]
		public static bool EnableDnsRoundRobin
		{
			get {
				throw GetMustImplement ();
			}
			set {
				throw GetMustImplement ();
			}
		}
#endif
		
		public static int MaxServicePointIdleTime {
			get { 
				return maxServicePointIdleTime;
			}
			set { 
				if (value < -2 || value > Int32.MaxValue)
					throw new ArgumentOutOfRangeException ("value");
				maxServicePointIdleTime = value;
			}
		}
		
		public static int MaxServicePoints {
			get { 
				return maxServicePoints; 
			}
			set {  
				if (value < 0)
					throw new ArgumentException ("value");				

				maxServicePoints = value;
				RecycleServicePoints ();
			}
		}

#if NET_1_0
		// we need it for SslClientStream
		internal
#else
		public
#endif
		static SecurityProtocolType SecurityProtocol {
			get { return _securityProtocol; }
			set { _securityProtocol = value; }
		}

#if NET_2_0
		public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get {
				return server_cert_cb;
			}
			set {
				server_cert_cb = value;
			}
		}
#endif

#if NET_1_1
		public static bool Expect100Continue {
			get { return expectContinue; }
			set { expectContinue = value; }
		}

		public static bool UseNagleAlgorithm {
			get { return useNagle; }
			set { useNagle = value; }
		}
#endif
		// Methods
		
		public static ServicePoint FindServicePoint (Uri address) 
		{
			return FindServicePoint (address, GlobalProxySelection.Select);
		}
		
		public static ServicePoint FindServicePoint (string uriString, IWebProxy proxy)
		{
			return FindServicePoint (new Uri(uriString), proxy);
		}

		public static ServicePoint FindServicePoint (Uri address, IWebProxy proxy)
		{
			if (address == null)
				throw new ArgumentNullException ("address");

			RecycleServicePoints ();
			
			bool usesProxy = false;
			bool useConnect = false;
			if (proxy != null && !proxy.IsBypassed(address)) {
				usesProxy = true;
				bool isSecure = address.Scheme == "https";
				address = proxy.GetProxy (address);
				if (address.Scheme != "http" && !isSecure)
					throw new NotSupportedException ("Proxy scheme not supported.");

				if (isSecure && address.Scheme == "http")
					useConnect = true;
			} 

			address = new Uri (address.Scheme + "://" + address.Authority);
			
			ServicePoint sp = null;
			lock (servicePoints) {
				SPKey key = new SPKey (address, useConnect);
				sp = servicePoints [key] as ServicePoint;
				if (sp != null)
					return sp;

				if (maxServicePoints > 0 && servicePoints.Count >= maxServicePoints)
					throw new InvalidOperationException ("maximum number of service points reached");

				string addr = address.ToString ();
#if MONOTOUCH
				int limit = defaultConnectionLimit;
#else
				int limit = (int) manager.GetMaxConnections (addr);
#endif
				sp = new ServicePoint (address, limit, maxServicePointIdleTime);
#if NET_1_1
				sp.Expect100Continue = expectContinue;
				sp.UseNagleAlgorithm = useNagle;
#endif
				sp.UsesProxy = usesProxy;
				sp.UseConnect = useConnect;
				servicePoints.Add (key, sp);
			}
			
			return sp;
		}
		
		// Internal Methods

		internal static void RecycleServicePoints ()
		{
			ArrayList toRemove = new ArrayList ();
			lock (servicePoints) {
				IDictionaryEnumerator e = servicePoints.GetEnumerator ();
				while (e.MoveNext ()) {
					ServicePoint sp = (ServicePoint) e.Value;
					if (sp.AvailableForRecycling) {
						toRemove.Add (e.Key);
					}
				}
				
				for (int i = 0; i < toRemove.Count; i++) 
					servicePoints.Remove (toRemove [i]);

				if (maxServicePoints == 0 || servicePoints.Count <= maxServicePoints)
					return;

				// get rid of the ones with the longest idle time
				SortedList list = new SortedList (servicePoints.Count);
				e = servicePoints.GetEnumerator ();
				while (e.MoveNext ()) {
					ServicePoint sp = (ServicePoint) e.Value;
					if (sp.CurrentConnections == 0) {
						while (list.ContainsKey (sp.IdleSince))
							sp.IdleSince = sp.IdleSince.AddMilliseconds (1);
						list.Add (sp.IdleSince, sp.Address);
					}
				}
				
				for (int i = 0; i < list.Count && servicePoints.Count > maxServicePoints; i++)
					servicePoints.Remove (list.GetByIndex (i));
			}
		}
#if NET_2_0 && SECURITY_DEP
		internal class ChainValidationHelper {
			object sender;
			string host;

			public ChainValidationHelper (object sender)
			{
				this.sender = sender;
			}

			public string Host {
				get {
					if (host == null && sender is HttpWebRequest)
						host = ((HttpWebRequest) sender).Address.Host;
					return host;
				}

				set { host = value; }
			}

			// Used when the obsolete ICertificatePolicy is set to DefaultCertificatePolicy
			// and the new ServerCertificateValidationCallback is not null
			internal bool ValidateChain (Mono.Security.X509.X509CertificateCollection certs)
			{
				if (certs == null || certs.Count == 0)
					return false;

				RemoteCertificateValidationCallback cb = ServicePointManager.ServerCertificateValidationCallback;
				if (cb == null)
					return false;

				X509Chain chain = new X509Chain ();
				chain.ChainPolicy = new X509ChainPolicy ();
				for (int i = 1; i < certs.Count; i++) {
					X509Certificate2 c2 = new X509Certificate2 (certs [i].RawData);
					chain.ChainPolicy.ExtraStore.Add (c2);
				}

				X509Certificate2 leaf = new X509Certificate2 (certs [0].RawData);
				SslPolicyErrors errors = 0;
				if (!chain.Build (leaf))
					errors |= GetErrorsFromChain (chain);
				if (!CheckCertificateUsage (leaf)) // -2146762490: CERT_E_PURPOSE
					errors |= SslPolicyErrors.RemoteCertificateChainErrors;
				if (!CheckServerIdentity (leaf, Host))
					errors |= SslPolicyErrors.RemoteCertificateNameMismatch;
				return cb (sender, leaf, chain, errors);
			}

			static SslPolicyErrors GetErrorsFromChain (X509Chain chain)
			{
				SslPolicyErrors errors = SslPolicyErrors.None;
				foreach (var status in chain.ChainStatus) {
					if (status.Status == X509ChainStatusFlags.NoError)
						continue;
					errors |= SslPolicyErrors.RemoteCertificateChainErrors;
					break;
				}
				return errors;
			}

			static X509KeyUsageFlags s_flags = X509KeyUsageFlags.DigitalSignature  | 
							X509KeyUsageFlags.KeyAgreement |
							X509KeyUsageFlags.KeyEncipherment;
			// Adapted to System 2.0+ from TlsServerCertificate.cs
			//------------------------------
			// Note: this method only works for RSA certificates
			// DH certificates requires some changes - does anyone use one ?
			static bool CheckCertificateUsage (X509Certificate2 cert) 
			{
				// certificate extensions are required for this
				// we "must" accept older certificates without proofs
				if (cert.Version < 3)
					return true;

				X509KeyUsageExtension kux = (X509KeyUsageExtension) cert.Extensions ["2.5.29.15"];
				X509EnhancedKeyUsageExtension eku = (X509EnhancedKeyUsageExtension) cert.Extensions ["2.5.29.37"];
				if (kux != null && eku != null) {
					// RFC3280 states that when both KeyUsageExtension and 
					// ExtendedKeyUsageExtension are present then BOTH should
					// be valid
					if ((kux.KeyUsages & s_flags) == 0)
						return false;
					return eku.EnhancedKeyUsages ["1.3.6.1.5.5.7.3.1"] != null ||
						eku.EnhancedKeyUsages ["2.16.840.1.113730.4.1"] != null;
				} else if (kux != null) {
					return ((kux.KeyUsages & s_flags) != 0);
				} else if (eku != null) {
					// Server Authentication (1.3.6.1.5.5.7.3.1) or
					// Netscape Server Gated Crypto (2.16.840.1.113730.4)
					return eku.EnhancedKeyUsages ["1.3.6.1.5.5.7.3.1"] != null ||
						eku.EnhancedKeyUsages ["2.16.840.1.113730.4.1"] != null;
				}

				// last chance - try with older (deprecated) Netscape extensions
				X509Extension ext = cert.Extensions ["2.16.840.1.113730.1.1"];
				if (ext != null) {
					string text = ext.NetscapeCertType (false);
					return text.IndexOf ("SSL Server Authentication") != -1;
				}
				return true;
			}

			// RFC2818 - HTTP Over TLS, Section 3.1
			// http://www.ietf.org/rfc/rfc2818.txt
			// 
			// 1.	if present MUST use subjectAltName dNSName as identity
			// 1.1.		if multiples entries a match of any one is acceptable
			// 1.2.		wildcard * is acceptable
			// 2.	URI may be an IP address -> subjectAltName.iPAddress
			// 2.1.		exact match is required
			// 3.	Use of the most specific Common Name (CN=) in the Subject
			// 3.1		Existing practice but DEPRECATED
			static bool CheckServerIdentity (X509Certificate2 cert, string targetHost) 
			{
				X509Extension ext = cert.Extensions ["2.5.29.17"];
				// 1. subjectAltName
				if (ext != null) {
					ASN1 asn = new ASN1 (ext.RawData);
					SubjectAltNameExtension subjectAltName = new SubjectAltNameExtension (asn);
					// 1.1 - multiple dNSName
					foreach (string dns in subjectAltName.DNSNames) {
						// 1.2 TODO - wildcard support
						if (Match (targetHost, dns))
							return true;
					}
					// 2. ipAddress
					foreach (string ip in subjectAltName.IPAddresses) {
						// 2.1. Exact match required
						if (ip == targetHost)
							return true;
					}
				}
				// 3. Common Name (CN=)
				return CheckDomainName (cert.SubjectName.Format (false), targetHost);
			}

			static bool CheckDomainName (string subjectName, string targetHost)
			{
				string	domainName = String.Empty;
				Regex search = new Regex(@"CN\s*=\s*([^,]*)");
				MatchCollection	elements = search.Matches(subjectName);
				if (elements.Count == 1) {
					if (elements[0].Success)
						domainName = elements[0].Groups[1].Value.ToString();
				}

				return Match (targetHost, domainName);
			}

			// ensure the pattern is valid wrt to RFC2595 and RFC2818
			// http://www.ietf.org/rfc/rfc2595.txt
			// http://www.ietf.org/rfc/rfc2818.txt
			static bool Match (string hostname, string pattern)
			{
				// check if this is a pattern
				int index = pattern.IndexOf ('*');
				if (index == -1) {
					// not a pattern, do a direct case-insensitive comparison
					return (String.Compare (hostname, pattern, true, CultureInfo.InvariantCulture) == 0);
				}

				// check pattern validity
				// A "*" wildcard character MAY be used as the left-most name component in the certificate.

				// unless this is the last char (valid)
				if (index != pattern.Length - 1) {
					// then the next char must be a dot .'.
					if (pattern [index + 1] != '.')
						return false;
				}

				// only one (A) wildcard is supported
				int i2 = pattern.IndexOf ('*', index + 1);
				if (i2 != -1)
					return false;

				// match the end of the pattern
				string end = pattern.Substring (index + 1);
				int length = hostname.Length - end.Length;
				// no point to check a pattern that is longer than the hostname
				if (length <= 0)
					return false;

				if (String.Compare (hostname, length, end, 0, end.Length, true, CultureInfo.InvariantCulture) != 0)
					return false;

				// special case, we start with the wildcard
				if (index == 0) {
					// ensure we hostname non-matched part (start) doesn't contain a dot
					int i3 = hostname.IndexOf ('.');
					return ((i3 == -1) || (i3 >= (hostname.Length - end.Length)));
				}

				// match the start of the pattern
				string start = pattern.Substring (0, index);
				return (String.Compare (hostname, 0, start, 0, start.Length, true, CultureInfo.InvariantCulture) == 0);
			}
		}
#endif
	}
}

