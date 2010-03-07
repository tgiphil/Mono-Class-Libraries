using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	public partial class MethodBase
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static MethodBase GetCurrentMethod ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static MethodBase GetMethodFromHandleInternalType (IntPtr method_handle, IntPtr type_handle);
#endif
		
#if NET_2_0
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static MethodBody GetMethodBodyInternal (IntPtr handle);

	}
}
