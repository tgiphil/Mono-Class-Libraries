using System;
using System.Collections;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO
{
	public partial class DriveInfo
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static bool GetDiskFreeSpaceInternal (string pathName, out ulong freeBytesAvail,
		out ulong totalNumberOfBytes, out ulong totalNumberOfFreeBytes,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static uint GetDriveTypeInternal (string rootPathName);

	}
}
