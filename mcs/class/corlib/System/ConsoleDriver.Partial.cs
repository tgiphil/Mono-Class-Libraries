using System.IO;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class ConsoleDriver
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern bool Isatty (IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern int InternalKeyAvailable (int ms_timeout);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		unsafe internal static extern bool TtySetup (string keypadXmit, string teardown, out byte [] control_characters, out int *address);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool SetEcho (bool wantEcho);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool SetBreak (bool wantBreak);

	}
}
