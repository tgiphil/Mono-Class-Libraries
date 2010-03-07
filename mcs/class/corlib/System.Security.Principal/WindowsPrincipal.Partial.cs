using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	public partial class WindowsPrincipal
	{
		
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool IsMemberOfGroupId (IntPtr user, IntPtr group);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool IsMemberOfGroupName (IntPtr user, string group);

	}
}
