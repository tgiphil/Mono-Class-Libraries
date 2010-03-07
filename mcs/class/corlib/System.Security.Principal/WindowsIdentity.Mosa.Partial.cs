using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security.Principal
{
	public partial class WindowsIdentity
	{
		internal static string[] _GetRoles (IntPtr token)
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr GetCurrentToken ()
		{
			throw new System.NotImplementedException();
		}
		private static string GetTokenName (IntPtr token)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetUserToken (string username)
		{
			throw new System.NotImplementedException();
		}

	}
}
