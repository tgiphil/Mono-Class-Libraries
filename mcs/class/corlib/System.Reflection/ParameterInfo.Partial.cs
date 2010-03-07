using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	public partial class ParameterInfo
	{
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		public
#else
		internal
#endif
		extern int MetadataToken {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern Type[] GetTypeModifiers (bool optional);

	}
}
