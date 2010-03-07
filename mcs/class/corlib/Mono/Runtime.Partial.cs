using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	 partial class Runtime
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern void mono_runtime_install_handlers ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern string GetDisplayName ();

	}
}
