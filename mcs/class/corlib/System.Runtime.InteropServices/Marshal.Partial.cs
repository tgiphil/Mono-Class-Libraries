using System.Collections;
using System.Runtime.CompilerServices;
using System;
using System.Security;
using System.Reflection;
using System.Threading;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using Mono.Interop;

namespace System.Runtime.InteropServices
{
	public partial class Marshal
	{
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static int AddRefInternal (IntPtr pUnk);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr AllocCoTaskMem (int cb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.MayFail)]
#endif
		public extern static IntPtr AllocHGlobal (IntPtr cb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void copy_to_unmanaged (Array source, int startIndex,
		IntPtr destination, int length);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void copy_from_unmanaged (IntPtr source, int startIndex,
		Array destination, int length);
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
#if NET_2_0
		[ComVisible (true)]
#endif
		public extern static void DestroyStructure (IntPtr ptr, Type structuretype);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void FreeBSTR (IntPtr ptr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void FreeCoTaskMem (IntPtr ptr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		public extern static void FreeHGlobal (IntPtr hglobal);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static IntPtr GetCCW (object o, Type T);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static int GetComSlotForMethodInfoInternal (MemberInfo m);
#if !NET_2_1 || MONOTOUCH
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static IntPtr GetIDispatchForObjectInternal (object o);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static IntPtr GetIUnknownForObjectInternal (object o);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern object GetObjectForCCW (IntPtr pUnk);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool IsComObject (object o);
#endif // !NET_2_1
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		public static extern int GetLastWin32Error();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr OffsetOf (Type t, string fieldName);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void Prelink (MethodInfo m);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void PrelinkAll (Type c);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static string PtrToStringAnsi (IntPtr ptr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static string PtrToStringAnsi (IntPtr ptr, int len);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static string PtrToStringUni (IntPtr ptr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static string PtrToStringUni (IntPtr ptr, int len);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static string PtrToStringBSTR (IntPtr ptr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
#if NET_2_0
		[ComVisible (true)]
#endif
		public extern static void PtrToStructure (IntPtr ptr, object structure);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
#if NET_2_0
		[ComVisible (true)]
#endif
		public extern static object PtrToStructure (IntPtr ptr, Type structureType);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static int QueryInterfaceInternal (IntPtr pUnk, ref Guid iid, out IntPtr ppv);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static byte ReadByte (IntPtr ptr, int ofs);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static short ReadInt16 (IntPtr ptr, int ofs);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int ReadInt32 (IntPtr ptr, int ofs);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static long ReadInt64 (IntPtr ptr, int ofs);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr ReadIntPtr (IntPtr ptr, int ofs);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static IntPtr ReAllocCoTaskMem (IntPtr pv, int cb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr ReAllocHGlobal (IntPtr pv, IntPtr cb);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static int ReleaseInternal (IntPtr pUnk);
		
#if !NET_2_1 || MONOTOUCH
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static int ReleaseComObjectInternal (object co);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static int SizeOf (Type t);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr StringToBSTR (string s);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr StringToHGlobalAnsi (string s);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr StringToHGlobalUni (string s);
#endif
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.MayFail)]
		[ComVisible (true)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void StructureToPtr (object structure, IntPtr ptr, bool fDeleteOld);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static IntPtr UnsafeAddrOfPinnedArrayElement (Array arr, int index);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void WriteByte (IntPtr ptr, int ofs, byte val);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void WriteInt16 (IntPtr ptr, int ofs, short val);
		
		[MonoTODO]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void WriteInt16 (IntPtr ptr, int ofs, char val);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void WriteInt32 (IntPtr ptr, int ofs, int val);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void WriteInt64 (IntPtr ptr, int ofs, long val);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void WriteIntPtr (IntPtr ptr, int ofs, IntPtr val);
#endif
#if NET_2_0
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Delegate GetDelegateForFunctionPointerInternal (IntPtr ptr, Type t);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFunctionPointerForDelegateInternal (Delegate d);

	}
}
