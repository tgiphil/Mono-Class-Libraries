using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using Mono.Xml;

namespace System.Security
{
	public partial class SecurityManager
	{
		
		
		extern public static bool CheckExecutionRights {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[SecurityPermission (SecurityAction.Demand, ControlPolicy = true)]
		set;
		}
		
#if NET_2_0
		[Obsolete ("The security manager cannot be turned off on MS runtime")]
#endif
		extern public static bool SecurityEnabled {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[SecurityPermission (SecurityAction.Demand, ControlPolicy = true)]
		set;
		}
		
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static unsafe extern bool GetLinkDemandSecurity (MethodBase method, RuntimeDeclSecurityActions *cdecl, RuntimeDeclSecurityActions *mdecl);

	}
}
