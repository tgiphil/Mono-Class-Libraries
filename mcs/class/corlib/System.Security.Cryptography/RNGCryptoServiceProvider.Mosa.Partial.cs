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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography
{
	public partial class RNGCryptoServiceProvider
	{
		private static bool RngOpen ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr RngInitialize (byte[] seed)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr RngGetBytes (IntPtr handle, byte[] data)
		{
			throw new System.NotImplementedException();
		}
		private static void RngClose (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}

	}
}
