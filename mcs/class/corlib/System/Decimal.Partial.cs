using System;
using System.Globalization;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

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

	}
}
