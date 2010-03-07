using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.InteropServices;

namespace Mono.Interop
{
	 partial class ComInteropProxy
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static void AddProxy (IntPtr pItf, ComInteropProxy proxy);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static ComInteropProxy FindProxy (IntPtr pItf);

	}
}
