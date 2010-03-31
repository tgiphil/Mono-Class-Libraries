/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if NET_2_0 || BOOTSTRAP_NET_2_0

using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	public partial class DynamicMethod
	{
		private void create_dynamic_method (DynamicMethod m)
		{
			throw new System.NotImplementedException();
		}
		private void destroy_dynamic_method (DynamicMethod m)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif