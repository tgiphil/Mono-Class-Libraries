/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

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
	 partial class InternalThread
	{
		private void Thread_free_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}

	}
	public partial class Thread
	{
		private void ConstructInternalThread ()
		{
			throw new System.NotImplementedException();
		}
		private static byte[] ByteArrayToRootDomain (byte[] arr)
		{
			throw new System.NotImplementedException();
		}
		private static byte[] ByteArrayToCurrentDomain (byte[] arr)
		{
			throw new System.NotImplementedException();
		}
		private static InternalThread CurrentInternalThread_internal()
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
		private static CultureInfo GetCachedCurrentCulture (InternalThread thread)
		{
			throw new System.NotImplementedException();
		}
		private void SetCachedCurrentCulture (CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		private static CultureInfo GetCachedCurrentUICulture (InternalThread thread)
		{
			throw new System.NotImplementedException();
		}
		private void SetCachedCurrentUICulture (CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		private static string GetName_internal (InternalThread thread)
		{
			throw new System.NotImplementedException();
		}
		private static void SetName_internal (InternalThread thread, String name)
		{
			throw new System.NotImplementedException();
		}
		private static void Abort_internal (InternalThread thread, object stateInfo)
		{
			throw new System.NotImplementedException();
		}
		internal object GetAbortExceptionState ()
		{
			throw new System.NotImplementedException();
		}
		private static void Interrupt_internal (InternalThread thread)
		{
			throw new System.NotImplementedException();
		}
		private static bool Join_internal(InternalThread thread, int ms, IntPtr handle)
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
		private static void Suspend_internal(InternalThread thread)
		{
			throw new System.NotImplementedException();
		}
		private static void SetState (InternalThread thread, ThreadState set)
		{
			throw new System.NotImplementedException();
		}
		private static void ClrState (InternalThread thread, ThreadState clr)
		{
			throw new System.NotImplementedException();
		}
		private static ThreadState GetState (InternalThread thread)
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
