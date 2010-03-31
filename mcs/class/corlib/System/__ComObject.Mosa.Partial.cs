/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using Mono.Interop;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class __ComObject
	{
		internal static __ComObject CreateRCW (Type t)
		{
			throw new System.NotImplementedException();
		}
		private void ReleaseInterfaces ()
		{
			throw new System.NotImplementedException();
		}
		internal IntPtr GetInterfaceInternal (Type t, bool throwException)
		{
			throw new System.NotImplementedException();
		}
		static int CoCreateInstance (
		[In, MarshalAs (UnmanagedType.LPStruct)] Guid rclsid,
		IntPtr pUnkOuter,
		uint dwClsContext,
		[In, MarshalAs (UnmanagedType.LPStruct)] Guid riid,
		out IntPtr pUnk)
		{
			throw new System.NotImplementedException();
		}

	}
}
