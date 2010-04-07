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
using System.Runtime.InteropServices;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Resources;
using System.Globalization;

namespace System.Reflection.Emit
{
	public partial class ModuleBuilder
	{
		private static void basic_init (ModuleBuilder ab)
		{
			throw new System.NotImplementedException();
		}
		private static void set_wrappers_type (ModuleBuilder mb, Type ab)
		{
			throw new System.NotImplementedException();
		}
		private static Type create_modified_type (TypeBuilder tb, string modifiers)
		{
			throw new System.NotImplementedException();
		}
		private static int getUSIndex (ModuleBuilder mb, string str)
		{
			throw new System.NotImplementedException();
		}
		private static int getToken (ModuleBuilder mb, object obj)
		{
			throw new System.NotImplementedException();
		}
		private static int getMethodToken (ModuleBuilder mb, MethodInfo method,
		Type[] opt_param_types)
		{
			throw new System.NotImplementedException();
		}
		internal void RegisterToken (object obj, int token)
		{
			throw new System.NotImplementedException();
		}
		private static void build_metadata (ModuleBuilder mb)
		{
			throw new System.NotImplementedException();
		}
		private void WriteToFile (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}

	}
}
