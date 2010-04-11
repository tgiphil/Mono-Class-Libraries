/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

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
		internal bool EqualsInternal (Type type)
		{
			throw new System.NotImplementedException();
		}
		private static Type internal_from_handle (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private static Type internal_from_name (string name, bool throwOnError, bool ignoreCase)
		{
			throw new System.NotImplementedException();
		}
		internal static TypeCode GetTypeCodeInternal (Type type)
		{
			throw new System.NotImplementedException();
		}
		internal static bool type_is_subtype_of (Type a, Type b, bool check_interfaces)
		{
			throw new System.NotImplementedException();
		}
		internal static bool type_is_assignable_from (Type a, Type b)
		{
			throw new System.NotImplementedException();
		}
		internal static void GetInterfaceMapData (Type t, Type iface, out MethodInfo[] targets, out MethodInfo[] methods)
		{
			throw new System.NotImplementedException();
		}
		static bool IsInstanceOfType (Type type, object o)
		{
			throw new System.NotImplementedException();
		}
		internal static bool IsArrayImpl (Type type)
		{
			throw new System.NotImplementedException();
		}
		public virtual bool IsGenericTypeDefinition {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		internal Type GetGenericTypeDefinition_impl ()
		{
			throw new System.NotImplementedException();
		}
		public virtual bool IsGenericType {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		static Type MakeGenericType (Type gt, Type [] types)
		{
			throw new System.NotImplementedException();
		}
		int GetGenericParameterPosition ()
		{
			throw new System.NotImplementedException();
		}
		GenericParameterAttributes GetGenericParameterAttributes ()
		{
			throw new System.NotImplementedException();
		}
		Type[] GetGenericParameterConstraints_impl ()
		{
			throw new System.NotImplementedException();
		}
		Type make_array_type (int rank)
		{
			throw new System.NotImplementedException();
		}
		Type make_byref_type ()
		{
			throw new System.NotImplementedException();
		}
		static Type MakePointerType (Type type)
		{
			throw new System.NotImplementedException();
		}
		void GetPacking (out int packing, out int size)
		{
			throw new System.NotImplementedException();
		}

	}
}
