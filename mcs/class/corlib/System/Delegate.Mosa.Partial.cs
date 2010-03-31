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

namespace System
{
	public partial class Delegate
	{
		internal static Delegate CreateDelegate_internal (Type type, object target, MethodInfo info, bool throwOnBindFailure)
		{
			throw new System.NotImplementedException();
		}
		internal void SetMulticastInvoke ()
		{
			throw new System.NotImplementedException();
		}

	}
}
