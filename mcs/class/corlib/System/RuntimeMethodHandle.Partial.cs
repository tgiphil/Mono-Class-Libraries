using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial struct RuntimeMethodHandle
	{
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern IntPtr GetFunctionPointer (IntPtr m);

	}
}
