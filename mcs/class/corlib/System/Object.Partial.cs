using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public partial class Object
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern Type GetType ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		protected extern object MemberwiseClone ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal static extern int InternalGetHashCode (object o);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern IntPtr obj_address ();

	}
}
