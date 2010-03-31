/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Diagnostics;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	public partial class FieldInfo
	{
		private static FieldInfo internal_from_handle_type (IntPtr field_handle, IntPtr type_handle)
		{
			throw new System.NotImplementedException();
		}
		private UnmanagedMarshal GetUnmanagedMarshal ()
		{
			throw new System.NotImplementedException();
		}
		Type[] GetTypeModifiers (bool optional)
		{
			throw new System.NotImplementedException();
		}

	}
}
