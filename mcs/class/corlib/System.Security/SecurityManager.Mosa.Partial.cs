/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if !NET_2_1 || MONOTOUCH

using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;

using Mono.Xml;

namespace System.Security
{
	public partial class SecurityManager
	{
		public static bool CheckExecutionRights {
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
				throw new System.NotImplementedException();
			}
		}
		public static bool SecurityEnabled {
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
				throw new System.NotImplementedException();
			}
		}
		private static unsafe bool GetLinkDemandSecurity (MethodBase method, RuntimeDeclSecurityActions *cdecl, RuntimeDeclSecurityActions *mdecl)
		{
			throw new System.NotImplementedException();
		}

	}
}
