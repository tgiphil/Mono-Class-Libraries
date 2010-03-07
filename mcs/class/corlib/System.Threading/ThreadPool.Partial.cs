using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Threading
{
	public partial class ThreadPool
	{
#endif
		
#if !NET_2_1		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern void GetAvailableThreads (out int workerThreads, out int completionPortThreads);
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern void GetMaxThreads (out int workerThreads, out int completionPortThreads);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern void GetMinThreads (out int workerThreads, out int completionPortThreads);
		
		[MonoTODO("The min number of completion port threads is not evaluated.")]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		[SecurityPermission (SecurityAction.Demand, ControlThread=true)]
		public static extern bool SetMinThreads (int workerThreads, int completionPortThreads);
		
#if NET_2_0
		[MonoTODO("The max number of threads cannot be decremented.")]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		[SecurityPermission (SecurityAction.Demand, ControlThread=true)]
		public static extern bool SetMaxThreads (int workerThreads, int completionPortThreads);

	}
}
