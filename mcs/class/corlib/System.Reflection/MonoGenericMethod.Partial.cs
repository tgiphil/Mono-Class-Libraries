using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	 partial class MonoGenericMethod
	{
		
		public override extern Type ReflectedType {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}

	}
	 partial class MonoGenericCMethod
	{
		
		public override extern Type ReflectedType {
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		get;
		}

	}
}
