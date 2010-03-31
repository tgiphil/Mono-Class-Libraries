/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Cryptography.X509Certificates;

#if !NET_2_1 || MONOTOUCH
using Mono.Security.Authenticode;
#endif

namespace System.Security.Policy
{
	public partial class Evidence
	{
		static bool IsAuthenticodePresent (Assembly a)
		{
			throw new System.NotImplementedException();
		}

	}
}
