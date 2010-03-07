using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Principal
{
	public partial class WindowsImpersonationContext
	{
		private static bool CloseToken (IntPtr token)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr DuplicateToken (IntPtr token)
		{
			throw new System.NotImplementedException();
		}
		private static bool SetCurrentToken (IntPtr token)
		{
			throw new System.NotImplementedException();
		}
		private static bool RevertToSelf ()
		{
			throw new System.NotImplementedException();
		}

	}
}
