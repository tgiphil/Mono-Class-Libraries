using Mono.Interop;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class __ComObject
	{
#pragma warning restore 169
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern __ComObject CreateRCW (Type t);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern void ReleaseInterfaces ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern IntPtr GetInterfaceInternal (Type t, bool throwException);
		
		[DllImport ("ole32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, PreserveSig = true)]
		static extern int CoCreateInstance (
		[In, MarshalAs (UnmanagedType.LPStruct)] Guid rclsid,
		IntPtr pUnkOuter,
		uint dwClsContext,
		[In, MarshalAs (UnmanagedType.LPStruct)] Guid riid,
		out IntPtr pUnk);

	}
}
