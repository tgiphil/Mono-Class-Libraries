/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if !NET_2_1
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	unsafe partial class WindowsConsoleDriver
	{
		static IntPtr GetStdHandle (Handles handle)
		{
			throw new System.NotImplementedException();
		}
		static void _Beep (int frequency, int duration)
		{
			throw new System.NotImplementedException();
		}
		static bool GetConsoleScreenBufferInfo (IntPtr handle, out ConsoleScreenBufferInfo info)
		{
			throw new System.NotImplementedException();
		}
		static bool FillConsoleOutputCharacter (IntPtr handle, char c, int size, Coord coord, out int written)
		{
			throw new System.NotImplementedException();
		}
		static bool FillConsoleOutputAttribute (IntPtr handle, short c, int size, Coord coord, out int written)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleCursorPosition (IntPtr handle, Coord coord)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleTextAttribute (IntPtr handle, short attribute)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleScreenBufferSize (IntPtr handle, Coord newSize)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleWindowInfo (IntPtr handle, bool absolute, ref SmallRect rect)
		{
			throw new System.NotImplementedException();
		}
		static int GetConsoleTitle (StringBuilder sb, int size)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleTitle (string title)
		{
			throw new System.NotImplementedException();
		}
		static bool GetConsoleCursorInfo (IntPtr handle, out ConsoleCursorInfo info)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleCursorInfo (IntPtr handle, ref ConsoleCursorInfo info)
		{
			throw new System.NotImplementedException();
		}
		static short GetKeyState (int virtKey)
		{
			throw new System.NotImplementedException();
		}
		static bool GetConsoleMode (IntPtr handle, out int mode)
		{
			throw new System.NotImplementedException();
		}
		static bool SetConsoleMode (IntPtr handle, int mode)
		{
			throw new System.NotImplementedException();
		}
		static bool PeekConsoleInput (IntPtr handle, out InputRecord record, int length, out int eventsRead)
		{
			throw new System.NotImplementedException();
		}
		static bool ReadConsoleInput (IntPtr handle, out InputRecord record, int length, out int nread)
		{
			throw new System.NotImplementedException();
		}
		static Coord GetLargestConsoleWindowSize (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		static bool ReadConsoleOutput (IntPtr handle, void *buffer, Coord bsize, Coord bpos, ref SmallRect region)
		{
			throw new System.NotImplementedException();
		}
		static bool WriteConsoleOutput (IntPtr handle, CharInfo [] buffer, Coord bsize, Coord bpos, ref SmallRect region)
		{
			throw new System.NotImplementedException();
		}

	}
}
