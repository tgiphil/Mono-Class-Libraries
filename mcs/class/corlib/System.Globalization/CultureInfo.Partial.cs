using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	public partial class CultureInfo
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern bool construct_internal_locale_from_lcid (int lcid);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern bool construct_internal_locale_from_name (string name);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool construct_internal_locale_from_specific_name (CultureInfo ci,
		string name);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool construct_internal_locale_from_current_locale (CultureInfo ci);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static CultureInfo [] internal_get_cultures (bool neutral, bool specific, bool installed);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern void construct_datetime_format ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern void construct_number_format ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool internal_is_lcid_neutral (int lcid, out bool is_neutral);

	}
}
