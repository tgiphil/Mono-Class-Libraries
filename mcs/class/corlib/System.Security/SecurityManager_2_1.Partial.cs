using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace System.Security
{
	 partial class SecurityManager
	{
		
		extern public static bool SecurityEnabled {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}

	}
}
