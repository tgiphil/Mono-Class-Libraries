/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial struct ArgIterator
	{
		void Setup (IntPtr argsp, IntPtr start)
		{
			throw new System.NotImplementedException();
		}
		TypedReference IntGetNextArg ()
		{
			throw new System.NotImplementedException();
		}
		TypedReference IntGetNextArg (IntPtr rth)
		{
			throw new System.NotImplementedException();
		}
		IntPtr IntGetNextArgType ()
		{
			throw new System.NotImplementedException();
		}

	}
}
