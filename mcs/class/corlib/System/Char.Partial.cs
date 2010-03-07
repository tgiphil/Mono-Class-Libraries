using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial struct Char
	{
		
		[MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		private unsafe static extern void GetDataTablePointers (out byte *category_data,
		out byte *numeric_data, out double *numeric_data_values,
		out ushort *to_lower_data_low, out ushort *to_lower_data_high,
		out ushort *to_upper_data_low, out ushort *to_upper_data_high);

	}
}
