/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if NET_2_1 && !MONOTOUCH
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace System.IO.IsolatedStorage
{
	public partial class IsolatedStorageFile
	{
		static bool isolated_storage_increase_quota_to (string primary_text, string secondary_text)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif