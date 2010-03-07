using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Reflection.Emit
{
	 partial class DerivedType
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern void create_unmanaged_type (Type type);

	}
}
