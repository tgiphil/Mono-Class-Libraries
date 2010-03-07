using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
	public partial class Interlocked
	{
#endif
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int CompareExchange(ref int location1, int value, int comparand);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static object CompareExchange(ref object location1, object value, object comparand);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static float CompareExchange(ref float location1, float value, float comparand);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int Decrement(ref int location);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long Decrement(ref long location);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int Increment(ref int location);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long Increment(ref long location);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int Exchange(ref int location1, int value);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static object Exchange(ref object location1, object value);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static float Exchange(ref float location1, float value);
		
#if NET_2_0
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long CompareExchange(ref long location1, long value, long comparand);
		
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static double CompareExchange(ref double location1, double value, double comparand);
		
		[ComVisible (false)]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		[ReliabilityContract (Consistency.WillNotCorruptState, Cer.Success)]
		public extern static T CompareExchange<T> (ref T location1, T value, T comparand) where T:class;
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long Exchange(ref long location1, long value);
		
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr Exchange(ref IntPtr location1, IntPtr value);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static double Exchange(ref double location1, double value);
		
		[ComVisible (false)]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		[ReliabilityContract (Consistency.WillNotCorruptState, Cer.Success)]
		public extern static T Exchange<T> (ref T location1, T value) where T:class;
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long Read(ref long location);
		
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int Add(ref int location1, int value);
		
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long Add(ref long location1, long value);
#else
		/* This is needed by the runtime fast path locking */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);

	}
}
