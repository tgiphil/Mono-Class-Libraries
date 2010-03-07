using System.Runtime.ConstrainedExecution;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	public partial class RuntimeHelpers
	{
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern void InitializeArray (Array array, IntPtr fldHandle);
		
		public static extern int OffsetToStringData {
		[MethodImpl (MethodImplOptions.InternalCall)]
		get;
		}
#endif
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern object GetObjectValue (object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern void RunClassConstructor (IntPtr type);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public static extern void RunModuleConstructor (IntPtr module);

	}
}
