using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	 partial struct MonoEnumInfo
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern void get_enum_info (Type enumType, out MonoEnumInfo info);

	}
	public partial class Enum
	{
#if ONLY_1_1
#pragma warning restore 3019
#endif
		
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern object get_value ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern Type get_underlying_type (Type enumType);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern int compare_value_to (object other);
		
#if NET_2_0
		[ComVisible (true)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern object ToObject (Type enumType, object value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern int get_hashcode ();

	}
}
