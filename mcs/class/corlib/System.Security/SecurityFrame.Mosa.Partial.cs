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
using System.Security.Permissions;
using System.Text;

namespace System.Security
{
	 partial struct SecurityFrame
	{
		static RuntimeSecurityFrame _GetSecurityFrame (int skip)
		{
			throw new System.NotImplementedException();
		}
		static Array _GetSecurityStack (int skip)
		{
			throw new System.NotImplementedException();
		}

	}
}
