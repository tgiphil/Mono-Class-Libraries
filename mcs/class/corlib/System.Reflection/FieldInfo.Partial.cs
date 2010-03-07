using System.Diagnostics;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	public partial class FieldInfo
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern FieldInfo internal_from_handle_type (IntPtr field_handle, IntPtr type_handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern UnmanagedMarshal GetUnmanagedMarshal ();
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern Type[] GetTypeModifiers (bool optional);

	}
}
