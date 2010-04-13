//
// System.Type.cs
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace System
{
	public partial class Type
	{
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern bool EqualsInternal (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_handle (IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_name (string name, bool throwOnError, bool ignoreCase);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static TypeCode GetTypeCodeInternal (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool type_is_subtype_of (Type a, Type b, bool check_interfaces);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool type_is_assignable_from (Type a, Type b);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void GetInterfaceMapData (Type t, Type iface, out MethodInfo[] targets, out MethodInfo[] methods);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static bool IsInstanceOfType (Type type, object o);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern bool IsArrayImpl (Type type);
		
		public virtual extern bool IsGenericTypeDefinition {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern Type GetGenericTypeDefinition_impl ();
		
		public virtual extern bool IsGenericType {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern Type MakeGenericType (Type gt, Type [] types);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern int GetGenericParameterPosition ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern GenericParameterAttributes GetGenericParameterAttributes ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern Type[] GetGenericParameterConstraints_impl ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern Type make_array_type (int rank);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern Type make_byref_type ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern Type MakePointerType (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern void GetPacking (out int packing, out int size);		

	}
}
