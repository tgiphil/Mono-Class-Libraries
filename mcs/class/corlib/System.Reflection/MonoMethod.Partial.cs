using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Security;
using System.Threading;
using System.Text;

namespace System.Reflection
{
	 partial struct MonoMethodInfo
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern void get_method_info (IntPtr handle, out MonoMethodInfo info);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern ParameterInfo[] get_parameter_info (IntPtr handle, MemberInfo member);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern UnmanagedMarshal get_retval_marshal (IntPtr handle);

	}
	 partial class MonoMethod
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern string get_name (MethodBase method);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern MonoMethod get_base_definition (MonoMethod method);
		
		/*
		* InternalInvoke() receives the parameters correctly converted by the 
		* binder to match the types of the method signature.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern Object InternalInvoke (Object obj, Object[] parameters, out Exception exc);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern DllImportAttribute GetDllImportAttribute (IntPtr mhandle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern MethodInfo MakeGenericMethod_impl (Type [] types);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public override extern Type [] GetGenericArguments ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern MethodInfo GetGenericMethodDefinition_impl ();
		
		public override extern bool IsGenericMethodDefinition {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}
		
		public override extern bool IsGenericMethod {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}

	}
	 partial class MonoCMethod
	{
		
		/*
		* InternalInvoke() receives the parameters corretcly converted by the binder
		* to match the types of the method signature.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern Object InternalInvoke (Object obj, Object[] parameters, out Exception exc);

	}
}
