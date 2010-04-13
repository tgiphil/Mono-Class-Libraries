//
// System.Threading.Thread.cs
//
// Author:
//   Dick Porter (dick@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
// Copyright (C) 2004-2006 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

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
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void Thread_free_internal(IntPtr handle);

	}
	public partial class Thread
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void ConstructInternalThread ();
		
		/*
		* These two methods return an array in the target
		* domain with the same content as the argument.  If
		* the argument is already in the target domain, then
		* the argument is returned, otherwise a copy.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static byte[] ByteArrayToRootDomain (byte[] arr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static byte[] ByteArrayToCurrentDomain (byte[] arr);
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static InternalThread CurrentInternalThread_internal();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static void FreeLocalSlotValues (int slot, bool thread_local);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int GetDomainID();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void ResetAbort_internal();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Sleep_internal(int ms);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern IntPtr Thread_internal (MulticastDelegate start);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static CultureInfo GetCachedCurrentCulture (InternalThread thread);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern void SetCachedCurrentCulture (CultureInfo culture);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static CultureInfo GetCachedCurrentUICulture (InternalThread thread);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern void SetCachedCurrentUICulture (CultureInfo culture);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static string GetName_internal (InternalThread thread);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void SetName_internal (InternalThread thread, String name);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Abort_internal (InternalThread thread, object stateInfo);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern object GetAbortExceptionState ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static void Interrupt_internal (InternalThread thread);
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Join_internal(InternalThread thread, int ms, IntPtr handle);
#endif
		
#if NET_1_1
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void MemoryBarrier ();
#endif
		
#if !MOONLIGHT
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void Resume_internal();
#endif // !NET_2_1
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static void SpinWait_nop ();
		
#if !MOONLIGHT
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Suspend_internal(InternalThread thread);
#endif // !NET_2_1
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern private static void SetState (InternalThread thread, ThreadState set);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern private static void ClrState (InternalThread thread, ThreadState clr);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern private static ThreadState GetState (InternalThread thread);
		
#if NET_1_1
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static byte VolatileRead (ref byte address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static double VolatileRead (ref double address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static short VolatileRead (ref short address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static int VolatileRead (ref int address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static long VolatileRead (ref long address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static IntPtr VolatileRead (ref IntPtr address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static object VolatileRead (ref object address);
		
		[CLSCompliant(false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static sbyte VolatileRead (ref sbyte address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static float VolatileRead (ref float address);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static ushort VolatileRead (ref ushort address);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static uint VolatileRead (ref uint address);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static ulong VolatileRead (ref ulong address);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static UIntPtr VolatileRead (ref UIntPtr address);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref byte address, byte value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref double address, double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref short address, short value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref int address, int value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref long address, long value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref IntPtr address, IntPtr value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref object address, object value);
		
		[CLSCompliant(false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref sbyte address, sbyte value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref float address, float value);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref ushort address, ushort value);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref uint address, uint value);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref ulong address, ulong value);
		
		[CLSCompliant (false)]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern public static void VolatileWrite (ref UIntPtr address, UIntPtr value);

	}
}
