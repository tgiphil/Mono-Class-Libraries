using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial struct Double
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		unsafe private static extern bool ParseImpl (byte *byte_ptr, out double value);

	}
}
