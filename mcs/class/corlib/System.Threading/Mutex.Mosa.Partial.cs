/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.CompilerServices;
using System.Security.Permissions;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
using System.IO;
using System.Runtime.InteropServices;
#if !NET_2_1
using System.Security.AccessControl;
#endif
#endif

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
