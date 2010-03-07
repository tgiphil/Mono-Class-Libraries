using System.Diagnostics;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Remoting.Services;
using System.Security.Permissions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization.Formatters;

namespace System.Runtime.Remoting
{
	public partial class RemotingServices
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static object InternalExecute (MethodBase method, Object obj,
		Object[] parameters, out object [] out_args);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern static MethodBase GetVirtualMethod (Type type, MethodBase method);
		
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static bool IsTransparentProxy (object proxy);

	}
}
