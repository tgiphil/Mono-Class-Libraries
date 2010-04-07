
using System;
using System.Globalization;
using System.Text;
using System.Runtime.CompilerServices;

using NUtil = Mono.Globalization.Unicode.NormalizationTableUtil;

namespace Mono.Globalization.Unicode
{
	unsafe partial class Normalization
	{
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern void load_normalization_resource (
		out IntPtr props, out IntPtr mappedChars,
		out IntPtr charMapIndex, out IntPtr helperIndex,
		out IntPtr mapIdxToComposite, out IntPtr combiningClass);

	}
}
