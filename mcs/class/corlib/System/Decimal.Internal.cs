//
// System.Decimal.cs
//
// Represents a floating-point decimal data type with up to 29 
// significant digits, suitable for financial and commercial calculations.
//
// Author:
//   Martin Weindel (martin.weindel@t-online.de)
//
// (C) 2001 Martin Weindel
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
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

using System;
using System.Globalization;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

#if MSTEST
using System.Runtime.InteropServices;
#endif

namespace System
{
	public partial struct Decimal
	{
		
#if !MSTEST
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimal2UInt64 (ref Decimal val, out ulong result);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimal2Int64 (ref Decimal val, out long result);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int double2decimal (out Decimal erg, double val, int digits);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimalIncr (ref Decimal d1, ref Decimal d2);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern int decimal2string (ref Decimal val, 
		int digits, int decimals, char[] bufDigits, int bufSize, out int decPos, out int sign);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern int string2decimal (out Decimal val, String sDigits, uint decPos, int sign);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern int decimalSetExponent (ref Decimal val, int exp);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern double decimal2double (ref Decimal val);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void decimalFloorAndTrunc (ref Decimal val, int floorFlag);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimalMult (ref Decimal pd1, ref Decimal pd2);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimalDiv (out Decimal pc, ref Decimal pa, ref Decimal pb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimalIntDiv (out Decimal pc, ref Decimal pa, ref Decimal pb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int decimalCompare (ref Decimal d1, ref Decimal d2);
#else
		[DllImport("libdec", EntryPoint="decimal2UInt64")]
		private static extern int decimal2UInt64 (ref Decimal val, out ulong result);
		
		[DllImport("libdec", EntryPoint="decimal2Int64")]
		private static extern int decimal2Int64 (ref Decimal val, out long result);
		
		[DllImport("libdec", EntryPoint="double2decimal")]
		private static extern int double2decimal (out Decimal erg, double val, int digits);
		
		[DllImport("libdec", EntryPoint="decimalIncr")]
		private static extern int decimalIncr (ref Decimal d1, ref Decimal d2);
		
		[DllImport("libdec", EntryPoint="decimal2string")]
		internal static extern int decimal2string (ref Decimal val, 
		int digits, int decimals,
		[MarshalAs(UnmanagedType.LPWStr)]StringBuilder bufDigits, 
		int bufSize, out int decPos, out int sign);
		
		[DllImport("libdec", EntryPoint="string2decimal")]
		internal static extern int string2decimal (out Decimal val,
		[MarshalAs(UnmanagedType.LPWStr)]String sDigits,
		uint decPos, int sign);
		
		[DllImport("libdec", EntryPoint="decimalSetExponent")]
		internal static extern int decimalSetExponent (ref Decimal val, int exp);
		
		[DllImport("libdec", EntryPoint="decimal2double")]
		private static extern double decimal2double (ref Decimal val);
		
		[DllImport("libdec", EntryPoint="decimalFloorAndTrunc")]
		private static extern void decimalFloorAndTrunc (ref Decimal val, int floorFlag);
		
		[DllImport("libdec", EntryPoint="decimalRound")]
		private static extern void decimalRound (ref Decimal val, int decimals);
		
		[DllImport("libdec", EntryPoint="decimalMult")]
		private static extern int decimalMult (ref Decimal pd1, ref Decimal pd2);
		
		[DllImport("libdec", EntryPoint="decimalDiv")]
		private static extern int decimalDiv (out Decimal pc, ref Decimal pa, ref Decimal pb);
		
		[DllImport("libdec", EntryPoint="decimalIntDiv")]
		private static extern int decimalIntDiv (out Decimal pc, ref Decimal pa, ref Decimal pb);
		
		[DllImport("libdec", EntryPoint="decimalCompare")]
		private static extern int decimalCompare (ref Decimal d1, ref Decimal d2);

#endif
	}
}
