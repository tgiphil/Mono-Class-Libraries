//
// System.Char.cs
//
// Authors:
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//   Miguel de Icaza (miguel@ximian.com)
//   Jackson Harper (jackson@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
// Copyright (C) 2004-2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

// Note about the ToString()'s. ECMA says there's only a ToString() method, 
// BUT it is just a wrapper for ToString(null). However there is no other ToString
// in the docs. Turning to the NET framework sdk reveals that there is a 
// ToString(formatprovider) method, as well as a 'static ToString (char c)' method, 
// which appears to just be a Convert.ToString(char c) type method. ECMA also
// doesn't list this class as implementing IFormattable.

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
