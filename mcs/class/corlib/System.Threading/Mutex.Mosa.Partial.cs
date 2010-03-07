using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Runtime.ConstrainedExecution;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Threading
{
	public partial class Mutex
	{
		private static IntPtr  CreateMutex_internal(
		bool initiallyOwned,
		string name,
		out bool created)
		{
			throw new System.NotImplementedException();
		}
		private static bool ReleaseMutex_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr OpenMutex_internal (string name, MutexRights rights, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}

	}
}
