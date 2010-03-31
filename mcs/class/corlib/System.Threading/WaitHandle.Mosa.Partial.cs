/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Permissions;

#if NET_2_0
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;
#endif

namespace System.Threading
{
	public partial class WaitHandle
	{
		private static bool WaitAll_internal(WaitHandle[] handles, int ms, bool exitContext)
		{
			throw new System.NotImplementedException();
		}
		private static int WaitAny_internal(WaitHandle[] handles, int ms, bool exitContext)
		{
			throw new System.NotImplementedException();
		}
		private bool WaitOne_internal(IntPtr handle, int ms, bool exitContext)
		{
			throw new System.NotImplementedException();
		}
		static bool SignalAndWait_Internal (IntPtr toSignal, IntPtr toWaitOn, int ms, bool exitContext)
		{
			throw new System.NotImplementedException();
		}
		private bool WaitOne_internal(IntPtr handle, int ms, bool exitContext)
		{
			throw new System.NotImplementedException();
		}

	}
}
