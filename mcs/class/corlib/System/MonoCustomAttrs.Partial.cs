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
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern object[] GetCustomAttributesInternal (ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs);
		
#if NET_2_0
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern CustomAttributeData [] GetCustomAttributesDataInternal (ICustomAttributeProvider obj);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern bool IsDefinedInternal (ICustomAttributeProvider obj, Type AttributeType);

	}
}
