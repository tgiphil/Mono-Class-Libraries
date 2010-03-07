using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	public partial class CultureInfo
	{
		private bool construct_internal_locale_from_lcid (int lcid)
		{
			throw new System.NotImplementedException();
		}
		private bool construct_internal_locale_from_name (string name)
		{
			throw new System.NotImplementedException();
		}
		private static bool construct_internal_locale_from_specific_name (CultureInfo ci,
		string name)
		{
			throw new System.NotImplementedException();
		}
		private static bool construct_internal_locale_from_current_locale (CultureInfo ci)
		{
			throw new System.NotImplementedException();
		}
		private static CultureInfo [] internal_get_cultures (bool neutral, bool specific, bool installed)
		{
			throw new System.NotImplementedException();
		}
		private void construct_datetime_format ()
		{
			throw new System.NotImplementedException();
		}
		private void construct_number_format ()
		{
			throw new System.NotImplementedException();
		}
		private static bool internal_is_lcid_neutral (int lcid, out bool is_neutral)
		{
			throw new System.NotImplementedException();
		}

	}
}
