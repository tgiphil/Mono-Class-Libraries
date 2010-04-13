//
// System.MonoType
//
// Authors: 
// 	Sean MacIsaac (macisaac@ximian.com)
// 	Paolo Molaro (lupus@ximian.com)
// 	Patrik Torstensson (patrik.torstensson@labs2.com)
//	Gonzalo Paniagua (gonzalo@ximian.com)
//
// (c) 2001-2003 Ximian, Inc.
// Copyright (C) 2003-2005 Novell, Inc (http://www.novell.com)
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

using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	 partial class MonoType
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void type_from_obj (MonoType type, Object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern TypeAttributes get_attributes (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern ConstructorInfo[] GetConstructors_internal (BindingFlags bindingAttr, Type reflected_type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern EventInfo InternalGetEvent (string name, BindingFlags bindingAttr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern EventInfo[] GetEvents_internal (BindingFlags bindingAttr, Type reflected_type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override FieldInfo GetField (string name, BindingFlags bindingAttr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern FieldInfo[] GetFields_internal (BindingFlags bindingAttr, Type reflected_type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override Type[] GetInterfaces();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern MethodInfo [] GetMethodsByName (string name, BindingFlags bindingAttr, bool ignoreCase, Type reflected_type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern MethodInfo GetCorrespondingInflatedMethod (MethodInfo generic);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern ConstructorInfo GetCorrespondingInflatedConstructor (ConstructorInfo generic);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override Type GetNestedType (string name, BindingFlags bindingAttr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override Type[] GetNestedTypes (BindingFlags bindingAttr);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern PropertyInfo[] GetPropertiesByName (string name, BindingFlags bindingAttr, bool icase, Type reflected_type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		protected extern override bool IsByRefImpl ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		protected extern override bool IsCOMObjectImpl ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		protected extern override bool IsPointerImpl ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		protected extern override bool IsPrimitiveImpl ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override Type GetElementType ();
		
		public extern override Assembly Assembly {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern string getFullName(bool full_name, bool assembly_qualified);
		
		public extern override Type BaseType {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern override string Name {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern override string Namespace {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern override Module Module {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern override Type DeclaringType {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override int GetArrayRank ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern override Type [] GetGenericArguments ();
		
		public extern override bool IsGenericParameter {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern override MethodBase DeclaringMethod {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern int get_core_clr_security_level ();

	}
}
