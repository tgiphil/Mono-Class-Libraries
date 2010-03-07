using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial class Buffer
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static int ByteLengthInternal (Array array);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static byte GetByteInternal (Array array, int index);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static void SetByteInternal (Array array, int index, int value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static bool BlockCopyInternal (Array src, int src_offset, Array dest, int dest_offset, int count);

	}
}
