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
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void basic_init (ModuleBuilder ab);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void set_wrappers_type (ModuleBuilder mb, Type ab);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Type create_modified_type (TypeBuilder tb, string modifiers);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int getUSIndex (ModuleBuilder mb, string str);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int getToken (ModuleBuilder mb, object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int getMethodToken (ModuleBuilder mb, MethodInfo method,
		Type[] opt_param_types);
		
		/*
		* Register the token->obj mapping with the runtime so the Module.Resolve... 
		* methods will work for obj.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern void RegisterToken (object obj, int token);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void build_metadata (ModuleBuilder mb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void WriteToFile (IntPtr handle);

	}
}
