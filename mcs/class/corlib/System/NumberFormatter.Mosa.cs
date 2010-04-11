/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#endif

using System.Globalization;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class NumberFormatter
	{
		private unsafe static void GetFormatterTables (out ulong* MantissaBitsTable, out int* TensExponentTable,
		out char* DigitLowerTable, out char* DigitUpperTable,
		out long* TenPowersList, out int* DecHexDigits)
		{
			throw new System.NotImplementedException();
		}

	}
}
