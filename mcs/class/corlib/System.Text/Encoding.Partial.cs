using System;
using System.Reflection;
using System.Globalization;
using System.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	public partial class Encoding
	{
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		extern internal static string InternalCodePage (ref int code_page);

	}
}
