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
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern IntPtr  CreateMutex_internal(
		bool initiallyOwned,
		string name,
		out bool created);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern bool ReleaseMutex_internal(IntPtr handle);
		
#if NET_2_0 && !NET_2_1
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern IntPtr OpenMutex_internal (string name, MutexRights rights, out MonoIOError error);

	}
}
