using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

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
