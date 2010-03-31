/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Globalization;
using System.Runtime.CompilerServices;
#if NET_2_0
using System.Runtime.InteropServices;
#endif

namespace System
{
	public partial struct Char
	{
		private unsafe static void GetDataTablePointers (out byte *category_data,
		out byte *numeric_data, out double *numeric_data_values,
		out ushort *to_lower_data_low, out ushort *to_lower_data_high,
		out ushort *to_upper_data_low, out ushort *to_upper_data_high)
		{
			throw new System.NotImplementedException();
		}

	}
}
