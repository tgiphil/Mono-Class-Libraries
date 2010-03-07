using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	 partial class MonoField
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern Type GetParentType (bool declaring);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal override extern int GetFieldOffset ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern object GetValueInternal (object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void SetValueInternal (FieldInfo fi, object obj, object value);
		
#if NET_2_0
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public override extern object GetRawConstantValue ();

	}
}
