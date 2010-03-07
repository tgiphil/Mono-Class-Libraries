using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography
{
	public partial class RNGCryptoServiceProvider
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern bool RngOpen ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern IntPtr RngInitialize (byte[] seed);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern IntPtr RngGetBytes (IntPtr handle, byte[] data);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void RngClose (IntPtr handle);

	}
}
