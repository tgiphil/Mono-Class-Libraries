using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace System
{
	public partial class Type
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern bool EqualsInternal (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_handle (IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_name (string name, bool throwOnError, bool ignoreCase);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static TypeCode GetTypeCodeInternal (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool type_is_subtype_of (Type a, Type b, bool check_interfaces);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool type_is_assignable_from (Type a, Type b);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void GetInterfaceMapData (Type t, Type iface, out MethodInfo[] targets, out MethodInfo[] methods);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern virtual bool IsInstanceOfType (object o);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool IsArrayImpl (Type type);
		
		public virtual extern bool IsGenericTypeDefinition {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern Type GetGenericTypeDefinition_impl ();
		
		public virtual extern bool IsGenericType {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern Type MakeGenericType (Type gt, Type [] types);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern int GetGenericParameterPosition ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern GenericParameterAttributes GetGenericParameterAttributes ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern Type[] GetGenericParameterConstraints_impl ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern Type make_array_type (int rank);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern Type make_byref_type ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern virtual Type MakePointerType ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern void GetPacking (out int packing, out int size);		

	}
}
