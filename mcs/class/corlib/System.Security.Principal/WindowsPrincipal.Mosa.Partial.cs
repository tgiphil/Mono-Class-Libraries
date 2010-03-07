using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	public partial class WindowsPrincipal
	{
		private static bool IsMemberOfGroupId (IntPtr user, IntPtr group)
		{
			throw new System.NotImplementedException();
		}
		private static bool IsMemberOfGroupName (IntPtr user, string group)
		{
			throw new System.NotImplementedException();
		}

	}
}
