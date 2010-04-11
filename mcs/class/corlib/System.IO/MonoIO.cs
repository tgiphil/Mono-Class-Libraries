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
	unsafe internal sealed partial class MonoIO {
		public static readonly FileAttributes
			InvalidFileAttributes = (FileAttributes)(-1);

		public static readonly IntPtr
			InvalidHandle = (IntPtr)(-1L);

		// error methods
		public static Exception GetException (MonoIOError error)
		{
			/* This overload is currently only called from
			 * File.MoveFile(), Directory.Move() and
			 * Directory.GetCurrentDirectory() -
			 * everywhere else supplies a path to format
			 * with the error text.
			 */
			switch(error) {
			case MonoIOError.ERROR_ACCESS_DENIED:
				return new UnauthorizedAccessException ("Access to the path is denied.");
			case MonoIOError.ERROR_FILE_EXISTS:
				string message = "Cannot create a file that already exist.";
				return new IOException (message, unchecked ((int) 0x80070000) | (int) error);
			default:
				/* Add more mappings here if other
				 * errors trigger the named but empty
				 * path bug (see bug 82141.) For
				 * everything else, fall through to
				 * the other overload
				 */
				return GetException (String.Empty, error);
			}
		}

		public static Exception GetException (string path,
						      MonoIOError error)
		{
			string message;

			switch (error) {
			// FIXME: add more exception mappings here
			case MonoIOError.ERROR_FILE_NOT_FOUND:
				message = String.Format ("Could not find file \"{0}\"", path);
#if NET_2_1
				return new IsolatedStorageException (message);
#else
				return new FileNotFoundException (message, path);
#endif

			case MonoIOError.ERROR_TOO_MANY_OPEN_FILES:
				return new IOException ("Too many open files", unchecked((int)0x80070000) | (int)error);
				
			case MonoIOError.ERROR_PATH_NOT_FOUND:
				message = String.Format ("Could not find a part of the path \"{0}\"", path);
#if NET_2_1
				return new IsolatedStorageException (message);
#else
				return new DirectoryNotFoundException (message);
#endif

			case MonoIOError.ERROR_ACCESS_DENIED:
				message = String.Format ("Access to the path \"{0}\" is denied.", path);
				return new UnauthorizedAccessException (message);

			case MonoIOError.ERROR_INVALID_HANDLE:
				message = String.Format ("Invalid handle to path \"{0}\"", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
			case MonoIOError.ERROR_INVALID_DRIVE:
				message = String.Format ("Could not find the drive  '{0}'. The drive might not be ready or might not be mapped.", path);
#if !NET_2_1
				return new DriveNotFoundException (message);
#else
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
#endif
			case MonoIOError.ERROR_FILE_EXISTS:
				message = String.Format ("Could not create file \"{0}\". File already exists.", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);

			case MonoIOError.ERROR_FILENAME_EXCED_RANGE:
				message = String.Format ("Path is too long. Path: {0}", path); 
				return new PathTooLongException (message);

			case MonoIOError.ERROR_INVALID_PARAMETER:
				message = String.Format ("Invalid parameter");
				return new IOException (message, unchecked((int)0x80070000) | (int)error);

			case MonoIOError.ERROR_WRITE_FAULT:
				message = String.Format ("Write fault on path {0}", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);

			case MonoIOError.ERROR_SHARING_VIOLATION:
				message = String.Format ("Sharing violation on path {0}", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
				
			case MonoIOError.ERROR_LOCK_VIOLATION:
				message = String.Format ("Lock violation on path {0}", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
			
			case MonoIOError.ERROR_HANDLE_DISK_FULL:
				message = String.Format ("Disk full. Path {0}", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
			
			case MonoIOError.ERROR_DIR_NOT_EMPTY:
				message = String.Format ("Directory {0} is not empty", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);

			case MonoIOError.ERROR_ENCRYPTION_FAILED:
				return new IOException ("Encryption failed", unchecked((int)0x80070000) | (int)error);

			case MonoIOError.ERROR_CANNOT_MAKE:
				message = String.Format ("Path {0} is a directory", path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
				
			case MonoIOError.ERROR_NOT_SAME_DEVICE:
				message = "Source and destination are not on the same device";
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
				
			default:
				message = String.Format ("Win32 IO returned {0}. Path: {1}", error, path);
				return new IOException (message, unchecked((int)0x80070000) | (int)error);
			}
		}

		// directory methods

		// file methods

		//
		// Find file methods
		//
		
		public static bool Exists (string path, out MonoIOError error)
		{
			FileAttributes attrs = GetFileAttributes (path,
								  out error);
			if (attrs == InvalidFileAttributes)
				return false;

			return true;
		}

		public static bool ExistsFile (string path,
					       out MonoIOError error)
		{
			FileAttributes attrs = GetFileAttributes (path,
								  out error);
			if (attrs == InvalidFileAttributes)
				return false;

			if ((attrs & FileAttributes.Directory) != 0)
				return false;

			return true;
		}

		public static bool ExistsDirectory (string path,
						    out MonoIOError error)
		{
			FileAttributes attrs = GetFileAttributes (path,
								  out error);
								  
			// Actually, we are looking for a directory, not a file
			if (error == MonoIOError.ERROR_FILE_NOT_FOUND)
				error = MonoIOError.ERROR_PATH_NOT_FOUND;
				
			if (attrs == InvalidFileAttributes)
				return false;

			if ((attrs & FileAttributes.Directory) == 0)
				return false;

			return true;
		}

		public static bool ExistsSymlink (string path,
						  out MonoIOError error)
		{
			FileAttributes attrs = GetFileAttributes (path,
								  out error);
			if (attrs == InvalidFileAttributes)
				return false;
			
			if ((attrs & FileAttributes.ReparsePoint) == 0)
				return false;

			return true;
		}

		// handle methods

		public static bool SetFileTime (string path,
						long creation_time,
						long last_access_time,
						long last_write_time,
						out MonoIOError error)
		{
			return SetFileTime (path,
				0,
				creation_time,
				last_access_time,
				last_write_time,
				DateTime.MinValue,
				out error);
		}

		public static bool SetCreationTime (string path,
						DateTime dateTime,
						out MonoIOError error)
		{
			return SetFileTime (path, 1, -1, -1, -1, dateTime, out error);
		}

		public static bool SetLastAccessTime (string path,
						DateTime dateTime,
						out MonoIOError error)
		{
			return SetFileTime (path, 2, -1, -1, -1, dateTime, out error);
		}

		public static bool SetLastWriteTime (string path,
						DateTime dateTime,
						out MonoIOError error)
		{
			return SetFileTime (path, 3, -1, -1, -1, dateTime, out error);
		}

		public static bool SetFileTime (string path,
						int type,
						long creation_time,
						long last_access_time,
						long last_write_time,
						DateTime dateTime,
						out MonoIOError error)
		{
			IntPtr handle;
			bool result;

			handle = Open (path, FileMode.Open,
				       FileAccess.ReadWrite,
				       FileShare.ReadWrite, FileOptions.None, out error);
			if (handle == MonoIO.InvalidHandle)
				return false;

			switch (type) {
			case 1:
				creation_time = dateTime.ToFileTime ();
				break;
			case 2:
				last_access_time = dateTime.ToFileTime ();
				break;
			case 3:
				last_write_time = dateTime.ToFileTime ();
				break;
			}

			result = SetFileTime (handle, creation_time,
					      last_access_time,
					      last_write_time, out error);

			MonoIOError ignore_error;
			Close (handle, out ignore_error);
			
			return result;
		}

		// console handles

		// pipe handles

		// path characters

	}
}

