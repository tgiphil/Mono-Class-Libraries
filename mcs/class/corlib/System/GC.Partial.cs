using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial class GC
	{
#endif
		
		public extern static int MaxGeneration {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static void InternalCollect (int generation);
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static int GetGeneration (object obj);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static long GetTotalMemory (bool forceFullCollection);
		
		/* this icall has weird semantics check the docs... */
#if NET_2_0
		[ReliabilityContract (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static void KeepAlive (object obj);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static void ReRegisterForFinalize (object obj);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static void SuppressFinalize (object obj);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static void WaitForPendingFinalizers ();
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static int CollectionCount (int generation);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static void RecordPressure (long bytesAllocated);

	}
}
