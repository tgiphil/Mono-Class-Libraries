//
// System.__ComObject
//
// Authors:
//   Sebastien Pouliot <sebastien@ximian.com>
//   Kornél Pál <http://www.kornelpal.hu/>
//   Jonathan Chambers <joncham@gmail.com>
//
// Copyright (C) 2004 Novell (http://www.novell.com)
// Copyright (C) 2005 Kornél Pál
// Copyright (C) 2006 Jonathan Chambers
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

using Mono.Interop;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class __ComObject
	{
#pragma warning restore 169
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern __ComObject CreateRCW (Type t);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern void ReleaseInterfaces ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern IntPtr GetInterfaceInternal (Type t, bool throwException);
		
		[DllImport ("ole32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, PreserveSig = true)]
		static extern int CoCreateInstance (
		[In, MarshalAs (UnmanagedType.LPStruct)] Guid rclsid,
		IntPtr pUnkOuter,
		uint dwClsContext,
		[In, MarshalAs (UnmanagedType.LPStruct)] Guid riid,
		out IntPtr pUnk);

	}
}
