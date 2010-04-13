//
// System.ConsoleDriver
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) 2005 Novell, Inc (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if !NET_2_1
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
#endif
