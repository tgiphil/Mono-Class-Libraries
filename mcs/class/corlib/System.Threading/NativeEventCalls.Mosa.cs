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
using System.Runtime.CompilerServices;

#if !NET_2_1
using System.Security.AccessControl;
using System.IO;
#endif

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
