using System.Globalization;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class NumberFormatter
	{
		
		[MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		private unsafe static extern void GetFormatterTables (out ulong* MantissaBitsTable, out int* TensExponentTable,
		out char* DigitLowerTable, out char* DigitUpperTable,
		out long* TenPowersList, out int* DecHexDigits);

	}
}
