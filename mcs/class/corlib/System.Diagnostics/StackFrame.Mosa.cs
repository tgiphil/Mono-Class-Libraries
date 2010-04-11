/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	public partial class StackFrame
	{
		static bool get_frame_info (int skip, bool needFileInfo, out MethodBase method,
		out int iloffset, out int native_offset,
		out string file, out int line, out int column)
		{
			throw new System.NotImplementedException();
		}

	}
}
