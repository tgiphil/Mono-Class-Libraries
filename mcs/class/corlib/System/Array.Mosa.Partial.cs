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
using System.Runtime.InteropServices;

#if NET_2_0
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;
#endif

namespace System
{
	public partial class Array
	{
		internal void GetGenericValueImpl<T> (int pos, out T value)
		{
			throw new System.NotImplementedException();
		}
		internal void SetGenericValueImpl<T> (int pos, ref T value)
		{
			throw new System.NotImplementedException();
		}
		int GetRank ()
		{
			throw new System.NotImplementedException();
		}
		public int GetLength (int dimension)
		{
			throw new System.NotImplementedException();
		}
		public int GetLowerBound (int dimension)
		{
			throw new System.NotImplementedException();
		}
		public object GetValue (params int[] indices)
		{
			throw new System.NotImplementedException();
		}
		public void SetValue (object value, params int[] indices)
		{
			throw new System.NotImplementedException();
		}
		internal object GetValueImpl (int pos)
		{
			throw new System.NotImplementedException();
		}
		internal void SetValueImpl (object value, int pos)
		{
			throw new System.NotImplementedException();
		}
		internal static bool FastCopy (Array source, int source_idx, Array dest, int dest_idx, int length)
		{
			throw new System.NotImplementedException();
		}
		internal static Array CreateInstanceImpl (Type elementType, int[] lengths, int[] bounds)
		{
			throw new System.NotImplementedException();
		}
		static void ClearInternal (Array a, int index, int count)
		{
			throw new System.NotImplementedException();
		}
		object Clone ()
		{
			throw new System.NotImplementedException();
		}

	}
}
