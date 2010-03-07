using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Security.Principal;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Reflection;
using System.Security;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
	public partial class Thread
	{
		private static Thread CurrentThread_internal()
		{
			throw new System.NotImplementedException();
		}
		internal static void FreeLocalSlotValues (int slot, bool thread_local)
		{
			throw new System.NotImplementedException();
		}
		public static int GetDomainID()
		{
			throw new System.NotImplementedException();
		}
		private static void ResetAbort_internal()
		{
			throw new System.NotImplementedException();
		}
		private static void Sleep_internal(int ms)
		{
			throw new System.NotImplementedException();
		}
		private IntPtr Thread_internal (MulticastDelegate start)
		{
			throw new System.NotImplementedException();
		}
		private void Thread_init ()
		{
			throw new System.NotImplementedException();
		}
		private CultureInfo GetCachedCurrentCulture ()
		{
			throw new System.NotImplementedException();
		}
		private byte[] GetSerializedCurrentCulture ()
		{
			throw new System.NotImplementedException();
		}
		private void SetCachedCurrentCulture (CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		private void SetSerializedCurrentCulture (byte[] culture)
		{
			throw new System.NotImplementedException();
		}
		private CultureInfo GetCachedCurrentUICulture ()
		{
			throw new System.NotImplementedException();
		}
		private byte[] GetSerializedCurrentUICulture ()
		{
			throw new System.NotImplementedException();
		}
		private void SetCachedCurrentUICulture (CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		private void SetSerializedCurrentUICulture (byte[] culture)
		{
			throw new System.NotImplementedException();
		}
		private string GetName_internal ()
		{
			throw new System.NotImplementedException();
		}
		private void SetName_internal (String name)
		{
			throw new System.NotImplementedException();
		}
		private void Abort_internal (object stateInfo)
		{
			throw new System.NotImplementedException();
		}
		internal object GetAbortExceptionState ()
		{
			throw new System.NotImplementedException();
		}
		private void Interrupt_internal ()
		{
			throw new System.NotImplementedException();
		}
		private bool Join_internal(int ms, IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		public static void MemoryBarrier ()
		{
			throw new System.NotImplementedException();
		}
		private void Resume_internal()
		{
			throw new System.NotImplementedException();
		}
		private static void SpinWait_nop ()
		{
			throw new System.NotImplementedException();
		}
		private void Suspend_internal()
		{
			throw new System.NotImplementedException();
		}
		private void Thread_free_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private void SetState (ThreadState set)
		{
			throw new System.NotImplementedException();
		}
		private void ClrState (ThreadState clr)
		{
			throw new System.NotImplementedException();
		}
		private ThreadState GetState ()
		{
			throw new System.NotImplementedException();
		}
		public static byte VolatileRead (ref byte address)
		{
			throw new System.NotImplementedException();
		}
		public static double VolatileRead (ref double address)
		{
			throw new System.NotImplementedException();
		}
		public static short VolatileRead (ref short address)
		{
			throw new System.NotImplementedException();
		}
		public static int VolatileRead (ref int address)
		{
			throw new System.NotImplementedException();
		}
		public static long VolatileRead (ref long address)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr VolatileRead (ref IntPtr address)
		{
			throw new System.NotImplementedException();
		}
		public static object VolatileRead (ref object address)
		{
			throw new System.NotImplementedException();
		}
		public static sbyte VolatileRead (ref sbyte address)
		{
			throw new System.NotImplementedException();
		}
		public static float VolatileRead (ref float address)
		{
			throw new System.NotImplementedException();
		}
		public static ushort VolatileRead (ref ushort address)
		{
			throw new System.NotImplementedException();
		}
		public static uint VolatileRead (ref uint address)
		{
			throw new System.NotImplementedException();
		}
		public static ulong VolatileRead (ref ulong address)
		{
			throw new System.NotImplementedException();
		}
		public static UIntPtr VolatileRead (ref UIntPtr address)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref byte address, byte value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref double address, double value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref short address, short value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref int address, int value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref long address, long value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref IntPtr address, IntPtr value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref object address, object value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref sbyte address, sbyte value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref float address, float value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref ushort address, ushort value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref uint address, uint value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref ulong address, ulong value)
		{
			throw new System.NotImplementedException();
		}
		public static void VolatileWrite (ref UIntPtr address, UIntPtr value)
		{
			throw new System.NotImplementedException();
		}

	}
}
