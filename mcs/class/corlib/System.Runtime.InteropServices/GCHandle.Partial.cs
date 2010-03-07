using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{
	public partial struct GCHandle
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool CheckCurrentDomain (int handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static object GetTarget(int handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static int GetTargetHandle(object obj, int handle, GCHandleType type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void FreeHandle(int handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static IntPtr GetAddrOfPinnedObject(int handle);

	}
}
