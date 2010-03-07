using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial struct ArgIterator
	{
#pragma warning restore 169, 414
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		extern void Setup (IntPtr argsp, IntPtr start);
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		extern TypedReference IntGetNextArg ();
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		extern TypedReference IntGetNextArg (IntPtr rth);
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		extern IntPtr IntGetNextArgType ();

	}
}
