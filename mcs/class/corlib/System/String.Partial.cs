using System.Text;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Mono.Globalization.Unicode;

namespace System
{
	public partial class String
	{
		
		[CLSCompliant (false), MethodImplAttribute (MethodImplOptions.InternalCall)]
		unsafe public extern String (char *value);
		
		[CLSCompliant (false), MethodImplAttribute (MethodImplOptions.InternalCall)]
		unsafe public extern String (char *value, int startIndex, int length);
		
		[CLSCompliant (false), MethodImplAttribute (MethodImplOptions.InternalCall)]
		unsafe public extern String (sbyte *value);
		
		[CLSCompliant (false), MethodImplAttribute (MethodImplOptions.InternalCall)]
		unsafe public extern String (sbyte *value, int startIndex, int length);
		
		[CLSCompliant (false), MethodImplAttribute (MethodImplOptions.InternalCall)]
		unsafe public extern String (sbyte *value, int startIndex, int length, Encoding enc);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern String (char [] value, int startIndex, int length);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern String (char [] value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern String (char c, int count);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern String[] InternalSplit (char[] separator, int count, int options);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static String InternalAllocateStr (int length);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string InternalIntern (string str);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string InternalIsInterned (string str);

	}
}
