using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace System
{
	 partial class CurrentSystemTimeZone
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern bool GetTimeZoneData (int year, out Int64[] data, out string[] names);

	}
}
