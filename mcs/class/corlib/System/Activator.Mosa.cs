/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Configuration.Assemblies;
using System.Text;
#if !NET_2_1 || MONOTOUCH
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
#endif

namespace System
{
	public partial class Activator
	{
		internal static object CreateInstanceInternal (Type type)
		{
			throw new System.NotImplementedException();
		}

	}
}
