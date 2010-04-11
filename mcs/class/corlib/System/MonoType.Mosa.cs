/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

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
		private static void type_from_obj (MonoType type, Object obj)
		{
			throw new System.NotImplementedException();
		}
		private static TypeAttributes get_attributes (Type type)
		{
			throw new System.NotImplementedException();
		}
		internal ConstructorInfo[] GetConstructors_internal (BindingFlags bindingAttr, Type reflected_type)
		{
			throw new System.NotImplementedException();
		}
		EventInfo InternalGetEvent (string name, BindingFlags bindingAttr)
		{
			throw new System.NotImplementedException();
		}
		internal EventInfo[] GetEvents_internal (BindingFlags bindingAttr, Type reflected_type)
		{
			throw new System.NotImplementedException();
		}
		public override FieldInfo GetField (string name, BindingFlags bindingAttr)
		{
			throw new System.NotImplementedException();
		}
		internal FieldInfo[] GetFields_internal (BindingFlags bindingAttr, Type reflected_type)
		{
			throw new System.NotImplementedException();
		}
		public override Type[] GetInterfaces()
		{
			throw new System.NotImplementedException();
		}
		internal MethodInfo [] GetMethodsByName (string name, BindingFlags bindingAttr, bool ignoreCase, Type reflected_type)
		{
			throw new System.NotImplementedException();
		}
		MethodInfo GetCorrespondingInflatedMethod (MethodInfo generic)
		{
			throw new System.NotImplementedException();
		}
		ConstructorInfo GetCorrespondingInflatedConstructor (ConstructorInfo generic)
		{
			throw new System.NotImplementedException();
		}
		public override Type GetNestedType (string name, BindingFlags bindingAttr)
		{
			throw new System.NotImplementedException();
		}
		public override Type[] GetNestedTypes (BindingFlags bindingAttr)
		{
			throw new System.NotImplementedException();
		}
		internal PropertyInfo[] GetPropertiesByName (string name, BindingFlags bindingAttr, bool icase, Type reflected_type)
		{
			throw new System.NotImplementedException();
		}
		protected override bool IsByRefImpl ()
		{
			throw new System.NotImplementedException();
		}
		protected override bool IsCOMObjectImpl ()
		{
			throw new System.NotImplementedException();
		}
		protected override bool IsPointerImpl ()
		{
			throw new System.NotImplementedException();
		}
		protected override bool IsPrimitiveImpl ()
		{
			throw new System.NotImplementedException();
		}
		public override Type GetElementType ()
		{
			throw new System.NotImplementedException();
		}
		public override Assembly Assembly {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		private string getFullName(bool full_name, bool assembly_qualified)
		{
			throw new System.NotImplementedException();
		}
		public override Type BaseType {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override string Name {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override string Namespace {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override Module Module {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override Type DeclaringType {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override int GetArrayRank ()
		{
			throw new System.NotImplementedException();
		}
		public override Type [] GetGenericArguments ()
		{
			throw new System.NotImplementedException();
		}
		public override bool IsGenericParameter {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override MethodBase DeclaringMethod {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public int get_core_clr_security_level ()
		{
			throw new System.NotImplementedException();
		}

	}
}
