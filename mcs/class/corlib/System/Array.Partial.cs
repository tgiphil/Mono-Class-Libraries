using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial class Array
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern void GetGenericValueImpl<T> (int pos, out T value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern void SetGenericValueImpl<T> (int pos, ref T value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern int GetRank ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern int GetLength (int dimension);
#endif
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern int GetLowerBound (int dimension);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern object GetValue (params int[] indices);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern void SetValue (object value, params int[] indices);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern object GetValueImpl (int pos);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern void SetValueImpl (object value, int pos);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static bool FastCopy (Array source, int source_idx, Array dest, int dest_idx, int length);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static Array CreateInstanceImpl (Type elementType, int[] lengths, int[] bounds);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern void ClearInternal (Array a, int index, int count);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public
#if !NET_2_0
		virtual
#endif
		extern object Clone ();

	}
}
