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
using System.Runtime.CompilerServices;
using System;
using System.Security;
using System.Reflection;
using System.Threading;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
#if !NET_2_1 || MONOTOUCH
using System.Runtime.InteropServices.ComTypes;
#endif
#endif

#if !NET_2_1 || MONOTOUCH
using Mono.Interop;
#endif

namespace System.Runtime.InteropServices
{
	public partial class Marshal
	{
		private static int AddRefInternal (IntPtr pUnk)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr AllocCoTaskMem (int cb)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr AllocHGlobal (IntPtr cb)
		{
			throw new System.NotImplementedException();
		}
		static void copy_to_unmanaged (Array source, int startIndex,
		IntPtr destination, int length)
		{
			throw new System.NotImplementedException();
		}
		static void copy_from_unmanaged (IntPtr source, int startIndex,
		Array destination, int length)
		{
			throw new System.NotImplementedException();
		}
		public static void DestroyStructure (IntPtr ptr, Type structuretype)
		{
			throw new System.NotImplementedException();
		}
		public static void FreeBSTR (IntPtr ptr)
		{
			throw new System.NotImplementedException();
		}
		public static void FreeCoTaskMem (IntPtr ptr)
		{
			throw new System.NotImplementedException();
		}
		public static void FreeHGlobal (IntPtr hglobal)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetCCW (object o, Type T)
		{
			throw new System.NotImplementedException();
		}
		private static int GetComSlotForMethodInfoInternal (MemberInfo m)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetIDispatchForObjectInternal (object o)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetIUnknownForObjectInternal (object o)
		{
			throw new System.NotImplementedException();
		}
		private static object GetObjectForCCW (IntPtr pUnk)
		{
			throw new System.NotImplementedException();
		}
		public static bool IsComObject (object o)
		{
			throw new System.NotImplementedException();
		}
		public static int GetLastWin32Error()
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr OffsetOf (Type t, string fieldName)
		{
			throw new System.NotImplementedException();
		}
		public static void Prelink (MethodInfo m)
		{
			throw new System.NotImplementedException();
		}
		public static void PrelinkAll (Type c)
		{
			throw new System.NotImplementedException();
		}
		public static string PtrToStringAnsi (IntPtr ptr)
		{
			throw new System.NotImplementedException();
		}
		public static string PtrToStringAnsi (IntPtr ptr, int len)
		{
			throw new System.NotImplementedException();
		}
		public static string PtrToStringUni (IntPtr ptr)
		{
			throw new System.NotImplementedException();
		}
		public static string PtrToStringUni (IntPtr ptr, int len)
		{
			throw new System.NotImplementedException();
		}
		public static string PtrToStringBSTR (IntPtr ptr)
		{
			throw new System.NotImplementedException();
		}
		public static void PtrToStructure (IntPtr ptr, object structure)
		{
			throw new System.NotImplementedException();
		}
		public static object PtrToStructure (IntPtr ptr, Type structureType)
		{
			throw new System.NotImplementedException();
		}
		private static int QueryInterfaceInternal (IntPtr pUnk, ref Guid iid, out IntPtr ppv)
		{
			throw new System.NotImplementedException();
		}
		public static byte ReadByte (IntPtr ptr, int ofs)
		{
			throw new System.NotImplementedException();
		}
		public static short ReadInt16 (IntPtr ptr, int ofs)
		{
			throw new System.NotImplementedException();
		}
		public static int ReadInt32 (IntPtr ptr, int ofs)
		{
			throw new System.NotImplementedException();
		}
		public static long ReadInt64 (IntPtr ptr, int ofs)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr ReadIntPtr (IntPtr ptr, int ofs)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr ReAllocCoTaskMem (IntPtr pv, int cb)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr ReAllocHGlobal (IntPtr pv, IntPtr cb)
		{
			throw new System.NotImplementedException();
		}
		private static int ReleaseInternal (IntPtr pUnk)
		{
			throw new System.NotImplementedException();
		}
		private static int ReleaseComObjectInternal (object co)
		{
			throw new System.NotImplementedException();
		}
		public static int SizeOf (Type t)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr StringToBSTR (string s)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr StringToHGlobalAnsi (string s)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr StringToHGlobalUni (string s)
		{
			throw new System.NotImplementedException();
		}
		public static void StructureToPtr (object structure, IntPtr ptr, bool fDeleteOld)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr UnsafeAddrOfPinnedArrayElement (Array arr, int index)
		{
			throw new System.NotImplementedException();
		}
		public static void WriteByte (IntPtr ptr, int ofs, byte val)
		{
			throw new System.NotImplementedException();
		}
		public static void WriteInt16 (IntPtr ptr, int ofs, short val)
		{
			throw new System.NotImplementedException();
		}
		public static void WriteInt16 (IntPtr ptr, int ofs, char val)
		{
			throw new System.NotImplementedException();
		}
		public static void WriteInt32 (IntPtr ptr, int ofs, int val)
		{
			throw new System.NotImplementedException();
		}
		public static void WriteInt64 (IntPtr ptr, int ofs, long val)
		{
			throw new System.NotImplementedException();
		}
		public static void WriteIntPtr (IntPtr ptr, int ofs, IntPtr val)
		{
			throw new System.NotImplementedException();
		}
		private static Delegate GetDelegateForFunctionPointerInternal (IntPtr ptr, Type t)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetFunctionPointerForDelegateInternal (Delegate d)
		{
			throw new System.NotImplementedException();
		}

	}
}
