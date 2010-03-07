using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial class Delegate
	{
		
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern Delegate CreateDelegate_internal (Type type, object target, MethodInfo info, bool throwOnBindFailure);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern void SetMulticastInvoke ();

	}
}
