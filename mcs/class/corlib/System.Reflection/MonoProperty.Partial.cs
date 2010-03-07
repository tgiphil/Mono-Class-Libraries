using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection
{
	 partial struct MonoPropertyInfo
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void get_property_info (MonoProperty prop, ref MonoPropertyInfo info,
		PInfo req_info);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern Type[] GetTypeModifiers (MonoProperty prop, bool optional);

	}
}
