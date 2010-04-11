/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if MOONLIGHT

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace System.IO.IsolatedStorage
{
	 partial class IsolatedStorage
	{
		static long isolated_storage_get_current_usage (string root)
		{
			throw new System.NotImplementedException();
		}

	}
}
