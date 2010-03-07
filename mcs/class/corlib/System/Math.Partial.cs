using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial class Math
	{
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Floor (double d);
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Round (double a);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static double Round2 (double value, int digits, bool away_from_zero);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Sin (double a);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Cos (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Tan (double a);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Sinh (double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Cosh (double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Tanh (double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Acos (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Asin (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Atan (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Atan2 (double y, double x);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Exp (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Log (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Log10 (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Pow (double x, double y);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		public extern static double Sqrt (double d);

	}
}
