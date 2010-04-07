/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System;
using System.Runtime.CompilerServices;

#if NET_2_0
using System.Runtime.InteropServices;
#endif

namespace System.Diagnostics
{
	public partial class Debugger
	{
		private static bool IsAttached_internal ()
		{
			throw new System.NotImplementedException();
		}

	}
}
