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
using System.Reflection;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace System
{
	 partial class MonoCustomAttrs
	{
		internal static object[] GetCustomAttributesInternal (ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
		{
			throw new System.NotImplementedException();
		}
		static CustomAttributeData [] GetCustomAttributesDataInternal (ICustomAttributeProvider obj)
		{
			throw new System.NotImplementedException();
		}
		internal static bool IsDefinedInternal (ICustomAttributeProvider obj, Type AttributeType)
		{
			throw new System.NotImplementedException();
		}

	}
}
