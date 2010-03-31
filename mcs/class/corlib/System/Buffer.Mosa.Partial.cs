/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial class Buffer
	{
		private static int ByteLengthInternal (Array array)
		{
			throw new System.NotImplementedException();
		}
		private static byte GetByteInternal (Array array, int index)
		{
			throw new System.NotImplementedException();
		}
		private static void SetByteInternal (Array array, int index, int value)
		{
			throw new System.NotImplementedException();
		}
		internal static bool BlockCopyInternal (Array src, int src_offset, Array dest, int dest_offset, int count)
		{
			throw new System.NotImplementedException();
		}

	}
}
