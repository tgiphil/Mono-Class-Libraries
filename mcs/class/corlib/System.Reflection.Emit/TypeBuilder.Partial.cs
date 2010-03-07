using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Collections;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit
{
	public partial class TypeBuilder
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void setup_internal_class (TypeBuilder tb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void create_internal_class (TypeBuilder tb);
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void setup_generic_class ();
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void create_generic_class ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern EventInfo get_event_info (EventBuilder eb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern Type create_runtime_class (TypeBuilder tb);
		
		public extern override bool IsGenericParameter {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}

	}
}
