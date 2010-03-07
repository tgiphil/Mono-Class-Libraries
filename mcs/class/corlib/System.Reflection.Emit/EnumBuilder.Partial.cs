using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	public partial class EnumBuilder
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void setup_enum_type (Type t);

	}
}
