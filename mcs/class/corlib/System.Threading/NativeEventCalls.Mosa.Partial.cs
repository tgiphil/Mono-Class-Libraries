using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.IO;

namespace System.Threading
{
	 partial class NativeEventCalls
	{
		public static IntPtr CreateEvent_internal(bool manual,bool initial,string name, out bool created)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetEvent_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		public static bool ResetEvent_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		public static void CloseEvent_internal (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr OpenEvent_internal (string name, EventWaitHandleRights rights, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}

	}
}
