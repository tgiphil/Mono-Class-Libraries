/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading
{
	public partial class ThreadPool
	{
		public static void GetAvailableThreads (out int workerThreads, out int completionPortThreads)
		{
			throw new System.NotImplementedException();
		}
		public static void GetMaxThreads (out int workerThreads, out int completionPortThreads)
		{
			throw new System.NotImplementedException();
		}
		public static void GetMinThreads (out int workerThreads, out int completionPortThreads)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetMinThreads (int workerThreads, int completionPortThreads)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetMaxThreads (int workerThreads, int completionPortThreads)
		{
			throw new System.NotImplementedException();
		}

	}
}
