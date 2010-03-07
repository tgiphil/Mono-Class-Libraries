using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.IO;

namespace System.Threading
{
	 partial class NativeEventCalls
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern IntPtr CreateEvent_internal(bool manual,bool initial,string name, out bool created);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern bool SetEvent_internal(IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern bool ResetEvent_internal(IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern void CloseEvent_internal (IntPtr handle);
		
#if NET_2_0 && !NET_2_1
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public static extern IntPtr OpenEvent_internal (string name, EventWaitHandleRights rights, out MonoIOError error);

	}
}
