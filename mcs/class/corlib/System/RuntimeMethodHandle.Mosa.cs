/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial struct RuntimeMethodHandle
	{
		static IntPtr GetFunctionPointer (IntPtr m)
		{
			throw new System.NotImplementedException();
		}

	}
}
