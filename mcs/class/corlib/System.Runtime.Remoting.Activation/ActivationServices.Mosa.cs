/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

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
		public static object AllocateUninitializedClassInstance (Type type)
		{
			throw new System.NotImplementedException();
		}
		public static void EnableProxyActivation (Type type, bool enable)
		{
			throw new System.NotImplementedException();
		}

	}
}
