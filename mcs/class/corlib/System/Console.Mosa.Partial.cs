/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#endif

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
			private static int GetConsoleCP ()
			{
				throw new System.NotImplementedException();
			}
			private static int GetConsoleOutputCP ()
			{
				throw new System.NotImplementedException();
			}

		}
	}
}
