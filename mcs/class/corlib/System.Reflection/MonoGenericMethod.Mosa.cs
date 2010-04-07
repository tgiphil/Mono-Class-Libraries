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
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	 partial class MonoGenericMethod
	{
		public override Type ReflectedType {
			get
			{
				throw new System.NotImplementedException();
			}
		}

	}
	 partial class MonoGenericCMethod
	{
		public override Type ReflectedType {
			get
			{
				throw new System.NotImplementedException();
			}
		}

	}
}
