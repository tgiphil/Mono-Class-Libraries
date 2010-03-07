using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	 partial struct MonoEventInfo
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern void get_event_info (MonoEvent ev, out MonoEventInfo info);

	}
}
