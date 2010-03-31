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

namespace System
{
	 partial struct MonoEnumInfo
	{
		private static void get_enum_info (Type enumType, out MonoEnumInfo info)
		{
			throw new System.NotImplementedException();
		}

	}
	public partial class Enum
	{
		private object get_value ()
		{
			throw new System.NotImplementedException();
		}
		private static Type get_underlying_type (Type enumType)
		{
			throw new System.NotImplementedException();
		}
		private int compare_value_to (object other)
		{
			throw new System.NotImplementedException();
		}
		public static object ToObject (Type enumType, object value)
		{
			throw new System.NotImplementedException();
		}
		private int get_hashcode ()
		{
			throw new System.NotImplementedException();
		}

	}
}
