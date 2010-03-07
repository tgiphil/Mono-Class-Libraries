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
		
		[DllImport ("moon")]
		extern static long isolated_storage_get_current_usage (string root);

	}
}
