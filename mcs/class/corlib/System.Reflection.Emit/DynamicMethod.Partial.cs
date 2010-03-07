using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	public partial class DynamicMethod
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void create_dynamic_method (DynamicMethod m);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void destroy_dynamic_method (DynamicMethod m);

	}
}
