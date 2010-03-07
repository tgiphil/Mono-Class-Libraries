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
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern AppDomainSetup getSetup ();
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string getFriendlyName ();
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern AppDomain getCurDomain ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern AppDomain getRootDomain ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern int ExecuteAssembly (Assembly a, string[] args);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern Assembly [] GetAssemblies (bool refOnly);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern object GetData (string name);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Assembly LoadAssembly (string assemblyRef, Evidence securityEvidence, bool refOnly);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Assembly LoadAssemblyRaw (byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly);
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern AppDomain InternalSetDomainByID (int domain_id);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern AppDomain InternalSetDomain (AppDomain context);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern void InternalPushDomainRef (AppDomain domain);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern void InternalPushDomainRefByID (int domain_id);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern void InternalPopDomainRef ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern Context InternalSetContext (Context context);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern Context InternalGetContext ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern Context InternalGetDefaultContext ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern string InternalGetProcessGuid (string newguid);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern AppDomain createDomain (string friendlyName, AppDomainSetup info);
#endif // !NET_2_1
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern bool InternalIsFinalizingForUnload (int domain_id);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern void InternalUnload (int domain_id);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[SecurityPermission (SecurityAction.LinkDemand, ControlAppDomain = true)]
		public extern void SetData (string name, object data);

	}
}
