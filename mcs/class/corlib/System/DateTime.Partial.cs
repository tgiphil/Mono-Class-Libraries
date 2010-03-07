using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	public partial struct DateTime
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern long GetTimeMonotonic ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern long GetNow ();

	}
}
