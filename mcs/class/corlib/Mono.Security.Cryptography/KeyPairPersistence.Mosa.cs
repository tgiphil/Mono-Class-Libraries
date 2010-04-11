/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if !MOONLIGHT

using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;

using Mono.Xml;

namespace Mono.Security.Cryptography
{
	public partial class KeyPairPersistence
	{
		internal static bool _CanSecure (string root)
		{
			throw new System.NotImplementedException();
		}
		internal static bool _ProtectUser (string path)
		{
			throw new System.NotImplementedException();
		}
		internal static bool _ProtectMachine (string path)
		{
			throw new System.NotImplementedException();
		}
		internal static bool _IsUserProtected (string path)
		{
			throw new System.NotImplementedException();
		}
		internal static bool _IsMachineProtected (string path)
		{
			throw new System.NotImplementedException();
		}

	}
}
