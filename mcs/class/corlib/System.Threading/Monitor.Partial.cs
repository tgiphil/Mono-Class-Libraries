using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	public partial class Monitor
	{
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Monitor_try_enter(object obj, int ms);
		
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void Enter(object obj);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void Exit(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Monitor_pulse(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Monitor_test_synchronised(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Monitor_pulse_all(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Monitor_wait(object obj, int ms);

	}
}
