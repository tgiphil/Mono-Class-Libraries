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
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Proxies
{
	public partial class RealProxy
	{
		static Type InternalGetProxyType (object transparentProxy)
		{
			throw new System.NotImplementedException();
		}
		internal virtual object InternalGetTransparentProxy (string className)
		{
			throw new System.NotImplementedException();
		}

	}
}
