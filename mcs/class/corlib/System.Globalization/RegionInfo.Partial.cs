using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	public partial class RegionInfo
	{
#endif		
		
#if !NET_2_0
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern bool construct_internal_region_from_lcid (int lcid);
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern bool construct_internal_region_from_name (string name);

	}
}
