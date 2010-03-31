/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Globalization;
using System.Runtime.CompilerServices;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System
{
	public partial struct Double
	{
		unsafe private static bool ParseImpl (byte *byte_ptr, out double value)
		{
			throw new System.NotImplementedException();
		}

	}
}
