using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial class ValueType
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static bool InternalEquals (object o1, object o2, out object[] fields);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static int InternalGetHashCode (object o, out object[] fields);

	}
}
