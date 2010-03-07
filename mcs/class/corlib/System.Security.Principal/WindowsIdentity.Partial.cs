using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security.Principal
{
	public partial class WindowsIdentity
	{
		
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static string[] _GetRoles (IntPtr token);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static IntPtr GetCurrentToken ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string GetTokenName (IntPtr token);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static IntPtr GetUserToken (string username);

	}
}
