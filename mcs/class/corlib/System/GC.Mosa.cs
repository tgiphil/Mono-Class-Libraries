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

#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System
{
	public partial class GC
	{
		public static int MaxGeneration {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		static void InternalCollect (int generation)
		{
			throw new System.NotImplementedException();
		}
		public static int GetGeneration (object obj)
		{
			throw new System.NotImplementedException();
		}
		public static long GetTotalMemory (bool forceFullCollection)
		{
			throw new System.NotImplementedException();
		}
		public static void KeepAlive (object obj)
		{
			throw new System.NotImplementedException();
		}
		public static void ReRegisterForFinalize (object obj)
		{
			throw new System.NotImplementedException();
		}
		public static void SuppressFinalize (object obj)
		{
			throw new System.NotImplementedException();
		}
		public static void WaitForPendingFinalizers ()
		{
			throw new System.NotImplementedException();
		}
		public static int CollectionCount (int generation)
		{
			throw new System.NotImplementedException();
		}
		private static void RecordPressure (long bytesAllocated)
		{
			throw new System.NotImplementedException();
		}

	}
}
