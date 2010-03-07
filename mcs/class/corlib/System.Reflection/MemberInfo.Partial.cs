using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection
{
	public partial class MemberInfo
	{
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		public
#else
		internal
#endif
		virtual extern int MetadataToken {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}

	}
}
