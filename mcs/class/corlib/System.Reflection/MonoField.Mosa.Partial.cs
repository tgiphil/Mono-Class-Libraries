/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	 partial class MonoField
	{
		private Type GetParentType (bool declaring)
		{
			throw new System.NotImplementedException();
		}
		internal override int GetFieldOffset ()
		{
			throw new System.NotImplementedException();
		}
		private object GetValueInternal (object obj)
		{
			throw new System.NotImplementedException();
		}
		private static void SetValueInternal (FieldInfo fi, object obj, object value)
		{
			throw new System.NotImplementedException();
		}
		public override object GetRawConstantValue ()
		{
			throw new System.NotImplementedException();
		}

	}
}
