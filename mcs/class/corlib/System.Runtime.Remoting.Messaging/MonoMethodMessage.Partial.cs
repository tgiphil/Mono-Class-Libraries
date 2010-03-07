using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Runtime.Remoting.Messaging
{
	 partial class MonoMethodMessage
	{
		
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern void InitMessage (MonoMethod method, object [] out_args);

	}
}
