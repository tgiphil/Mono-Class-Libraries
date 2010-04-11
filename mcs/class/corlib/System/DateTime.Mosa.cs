/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.Serialization;

namespace System
{
	public partial struct DateTime
	{
		internal static long GetTimeMonotonic ()
		{
			throw new System.NotImplementedException();
		}
		internal static long GetNow ()
		{
			throw new System.NotImplementedException();
		}

	}
}
