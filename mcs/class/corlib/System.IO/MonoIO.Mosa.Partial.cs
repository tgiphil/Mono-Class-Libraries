using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.IsolatedStorage;

namespace System.IO
{
	unsafe partial class MonoIO
	{
		public static bool CreateDirectory (string path, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool RemoveDirectory (string path, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static string [] GetFileSystemEntries (string path, string path_with_pattern, int attrs, int mask, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static string GetCurrentDirectory (out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetCurrentDirectory (string path, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool MoveFile (string path, string dest,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool CopyFile (string path, string dest,
		bool overwrite,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool DeleteFile (string path,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool ReplaceFile (string sourceFileName,
		string destinationFileName,
		string destinationBackupFileName,
		bool ignoreMetadataErrors,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static FileAttributes GetFileAttributes (string path, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetFileAttributes (string path, FileAttributes attrs, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static MonoFileType GetFileType (IntPtr handle, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool GetFileStat (string path,
		out MonoIOStat stat,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr Open (string filename,
		FileMode mode,
		FileAccess access,
		FileShare share,
		FileOptions options,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool Close (IntPtr handle,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static int Read (IntPtr handle, byte [] dest,
		int dest_offset, int count,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static int Write (IntPtr handle, [In] byte [] src,
		int src_offset, int count,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static long Seek (IntPtr handle, long offset,
		SeekOrigin origin,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool Flush (IntPtr handle,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static long GetLength (IntPtr handle,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetLength (IntPtr handle,
		long length,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static bool SetFileTime (IntPtr handle,
		long creation_time,
		long last_access_time,
		long last_write_time,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static void Lock (IntPtr handle,
		long position, long length,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static void Unlock (IntPtr handle,
		long position, long length,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr ConsoleOutput {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static IntPtr ConsoleInput {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static IntPtr ConsoleError {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static bool CreatePipe (out IntPtr read_handle, out IntPtr write_handle)
		{
			throw new System.NotImplementedException();
		}
		public static bool DuplicateHandle (IntPtr source_process_handle, IntPtr source_handle,
		IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options)
		{
			throw new System.NotImplementedException();
		}
		public static char VolumeSeparatorChar {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static char DirectorySeparatorChar {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static char AltDirectorySeparatorChar {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static char PathSeparator {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static int GetTempPath(out string path)
		{
			throw new System.NotImplementedException();
		}

	}
}
