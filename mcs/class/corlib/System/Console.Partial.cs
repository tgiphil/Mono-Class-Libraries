using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System
{
	public partial class Console
	{

		private partial class WindowsConsole
		{
			[DllImport ("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
			private static extern int GetConsoleCP ();
			[DllImport ("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
			private static extern int GetConsoleOutputCP ();

		}
	}
}
