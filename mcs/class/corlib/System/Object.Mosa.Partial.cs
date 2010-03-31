/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System
{
	public partial class Object
	{
		public Type GetType ()
		{
			throw new System.NotImplementedException();
		}
		protected object MemberwiseClone ()
		{
			throw new System.NotImplementedException();
		}
		internal static int InternalGetHashCode (object o)
		{
			throw new System.NotImplementedException();
		}
		internal IntPtr obj_address ()
		{
			throw new System.NotImplementedException();
		}

	}
}
