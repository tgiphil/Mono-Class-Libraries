using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	public partial class Convert
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static byte [] InternalFromBase64String (string str, bool allowWhitespaceOnly);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static byte [] InternalFromBase64CharArray (char [] arr, int offset, int length);

	}
}
