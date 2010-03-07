using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Principal
{
	public partial class WindowsImpersonationContext
	{
		
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool CloseToken (IntPtr token);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static IntPtr DuplicateToken (IntPtr token);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool SetCurrentToken (IntPtr token);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool RevertToSelf ();

	}
}
