/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if MOONLIGHT

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace System.Security
{
	 partial class SecurityManager
	{
		public static bool SecurityEnabled {
			get
			{
				throw new System.NotImplementedException();
			}
		}

	}
}
#endif
