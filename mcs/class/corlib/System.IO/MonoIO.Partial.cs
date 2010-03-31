// System.IO.MonoIO.cs: static interface to native filesystem.
//
// Author:
//   Dan Lewis (dihlewis@yahoo.co.uk)
//   Dick Porter (dick@ximian.com)
//
// (C) 2002
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
#if NET_2_1
using System.IO.IsolatedStorage;
#endif

namespace System.IO
{
	unsafe partial class MonoIO
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool CreateDirectory (string path, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool RemoveDirectory (string path, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static string [] GetFileSystemEntries (string path, string path_with_pattern, int attrs, int mask, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static string GetCurrentDirectory (out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool SetCurrentDirectory (string path, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool MoveFile (string path, string dest,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool CopyFile (string path, string dest,
		bool overwrite,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool DeleteFile (string path,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool ReplaceFile (string sourceFileName, 
		string destinationFileName, 
		string destinationBackupFileName, 
		bool ignoreMetadataErrors,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static FileAttributes GetFileAttributes (string path, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool SetFileAttributes (string path, FileAttributes attrs, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static MonoFileType GetFileType (IntPtr handle, out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool GetFileStat (string path,
		out MonoIOStat stat,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static IntPtr Open (string filename,
		FileMode mode,
		FileAccess access,
		FileShare share,
		FileOptions options,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool Close (IntPtr handle,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static int Read (IntPtr handle, byte [] dest,
		int dest_offset, int count,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static int Write (IntPtr handle, [In] byte [] src,
		int src_offset, int count,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static long Seek (IntPtr handle, long offset,
		SeekOrigin origin,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool Flush (IntPtr handle,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static long GetLength (IntPtr handle,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool SetLength (IntPtr handle,
		long length,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool SetFileTime (IntPtr handle,
		long creation_time,
		long last_access_time,
		long last_write_time,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static void Lock (IntPtr handle,
		long position, long length,
		out MonoIOError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static void Unlock (IntPtr handle,
		long position, long length,
		out MonoIOError error);
		
		public extern static IntPtr ConsoleOutput {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern static IntPtr ConsoleInput {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern static IntPtr ConsoleError {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool CreatePipe (out IntPtr read_handle, out IntPtr write_handle);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static bool DuplicateHandle (IntPtr source_process_handle, IntPtr source_handle,
		IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options);
		
		public extern static char VolumeSeparatorChar {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern static char DirectorySeparatorChar {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern static char AltDirectorySeparatorChar {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern static char PathSeparator {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static int GetTempPath(out string path);

	}
}
