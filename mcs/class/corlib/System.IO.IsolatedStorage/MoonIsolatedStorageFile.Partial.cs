using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace System.IO.IsolatedStorage
{
	public partial class IsolatedStorageFile
	{
		
		[DllImport ("moon")]
		[return: MarshalAs (UnmanagedType.Bool)]
		extern static bool isolated_storage_increase_quota_to (string primary_text, string secondary_text);

	}
}
