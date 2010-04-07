/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System;
using System.Globalization;
using System.Text;
using System.Runtime.CompilerServices;

using NUtil = Mono.Globalization.Unicode.NormalizationTableUtil;

namespace Mono.Globalization.Unicode
{
	unsafe partial class Normalization
	{
		static void load_normalization_resource (
		out IntPtr props, out IntPtr mappedChars,
		out IntPtr charMapIndex, out IntPtr helperIndex,
		out IntPtr mapIdxToComposite, out IntPtr combiningClass)
		{
			throw new System.NotImplementedException();
		}

	}
}
