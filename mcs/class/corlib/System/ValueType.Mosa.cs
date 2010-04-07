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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial class ValueType
	{
		private static bool InternalEquals (object o1, object o2, out object[] fields)
		{
			throw new System.NotImplementedException();
		}
		internal static int InternalGetHashCode (object o, out object[] fields)
		{
			throw new System.NotImplementedException();
		}

	}
}
