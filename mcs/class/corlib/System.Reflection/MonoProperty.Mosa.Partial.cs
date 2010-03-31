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
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection
{
	 partial struct MonoPropertyInfo
	{
		internal static void get_property_info (MonoProperty prop, ref MonoPropertyInfo info,
		PInfo req_info)
		{
			throw new System.NotImplementedException();
		}
		internal static Type[] GetTypeModifiers (MonoProperty prop, bool optional)
		{
			throw new System.NotImplementedException();
		}

	}
}
