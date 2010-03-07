using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Proxies;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting.Activation
{
	 partial class ActivationServices
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern object AllocateUninitializedClassInstance (Type type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void EnableProxyActivation (Type type, bool enable);

	}
}
