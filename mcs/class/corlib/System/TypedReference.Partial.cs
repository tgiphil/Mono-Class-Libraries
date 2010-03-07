using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace System
{
	public partial struct TypedReference
	{
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		public extern static object ToObject (TypedReference value);

	}
}
