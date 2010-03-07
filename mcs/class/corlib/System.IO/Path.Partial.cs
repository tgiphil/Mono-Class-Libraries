using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;

namespace System.IO
{
	public partial class Path
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern string get_temp_path ();

	}
}
