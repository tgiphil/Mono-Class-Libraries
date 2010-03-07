using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
	public partial class WaitHandle
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern bool WaitAll_internal(WaitHandle[] handles, int ms, bool exitContext);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int WaitAny_internal(WaitHandle[] handles, int ms, bool exitContext);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern bool WaitOne_internal(IntPtr handle, int ms, bool exitContext);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern bool SignalAndWait_Internal (IntPtr toSignal, IntPtr toWaitOn, int ms, bool exitContext);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern bool WaitOne_internal(IntPtr handle, int ms, bool exitContext);

	}
}
