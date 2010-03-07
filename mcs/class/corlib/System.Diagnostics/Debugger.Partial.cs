using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	public partial class Debugger
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool IsAttached_internal ();

	}
}
