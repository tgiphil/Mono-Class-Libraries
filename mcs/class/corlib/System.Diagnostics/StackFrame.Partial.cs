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
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static bool get_frame_info (int skip, bool needFileInfo, out MethodBase method,
		out int iloffset, out int native_offset,
		out string file, out int line, out int column);

	}
}
