/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Configuration.Assemblies;

using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace System
{
	public partial class AppDomain
	{
		private AppDomainSetup getSetup ()
		{
			throw new System.NotImplementedException();
		}
		private string getFriendlyName ()
		{
			throw new System.NotImplementedException();
		}
		private static AppDomain getCurDomain ()
		{
			throw new System.NotImplementedException();
		}
		private static AppDomain getRootDomain ()
		{
			throw new System.NotImplementedException();
		}
		private int ExecuteAssembly (Assembly a, string[] args)
		{
			throw new System.NotImplementedException();
		}
		private Assembly [] GetAssemblies (bool refOnly)
		{
			throw new System.NotImplementedException();
		}
		public object GetData (string name)
		{
			throw new System.NotImplementedException();
		}
		internal Assembly LoadAssembly (string assemblyRef, Evidence securityEvidence, bool refOnly)
		{
			throw new System.NotImplementedException();
		}
		internal Assembly LoadAssemblyRaw (byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly)
		{
			throw new System.NotImplementedException();
		}
		private static AppDomain InternalSetDomainByID (int domain_id)
		{
			throw new System.NotImplementedException();
		}
		private static AppDomain InternalSetDomain (AppDomain context)
		{
			throw new System.NotImplementedException();
		}
		internal static void InternalPushDomainRef (AppDomain domain)
		{
			throw new System.NotImplementedException();
		}
		internal static void InternalPushDomainRefByID (int domain_id)
		{
			throw new System.NotImplementedException();
		}
		internal static void InternalPopDomainRef ()
		{
			throw new System.NotImplementedException();
		}
		internal static Context InternalSetContext (Context context)
		{
			throw new System.NotImplementedException();
		}
		internal static Context InternalGetContext ()
		{
			throw new System.NotImplementedException();
		}
		internal static Context InternalGetDefaultContext ()
		{
			throw new System.NotImplementedException();
		}
		internal static string InternalGetProcessGuid (string newguid)
		{
			throw new System.NotImplementedException();
		}
		private static AppDomain createDomain (string friendlyName, AppDomainSetup info)
		{
			throw new System.NotImplementedException();
		}
		private static bool InternalIsFinalizingForUnload (int domain_id)
		{
			throw new System.NotImplementedException();
		}
		static void InternalUnload (int domain_id)
		{
			throw new System.NotImplementedException();
		}
		public void SetData (string name, object data)
		{
			throw new System.NotImplementedException();
		}

	}
}
