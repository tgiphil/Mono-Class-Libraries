using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace System.Reflection
{
	 partial class MonoGenericClass
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern void initialize (MethodInfo[] methods, ConstructorInfo[] ctors, FieldInfo[] fields, PropertyInfo[] properties, EventInfo[] events);

	}
}
