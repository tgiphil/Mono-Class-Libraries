//
// System.WindowsConsoleDriver
//
// Author:
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) 2005 Novell, Inc. (http://www.novell.com)
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
#if !NET_2_1
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	unsafe partial class WindowsConsoleDriver
	{
		
		[DllImport ("kernel32.dll", EntryPoint="GetStdHandle", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static IntPtr GetStdHandle (Handles handle);
		
		[DllImport ("kernel32.dll", EntryPoint="Beep", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static void _Beep (int frequency, int duration);
		
		[DllImport ("kernel32.dll", EntryPoint="GetConsoleScreenBufferInfo", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool GetConsoleScreenBufferInfo (IntPtr handle, out ConsoleScreenBufferInfo info);
		
		[DllImport ("kernel32.dll", EntryPoint="FillConsoleOutputCharacter", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool FillConsoleOutputCharacter (IntPtr handle, char c, int size, Coord coord, out int written);
		
		[DllImport ("kernel32.dll", EntryPoint="FillConsoleOutputAttribute", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool FillConsoleOutputAttribute (IntPtr handle, short c, int size, Coord coord, out int written);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleCursorPosition", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleCursorPosition (IntPtr handle, Coord coord);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleTextAttribute", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleTextAttribute (IntPtr handle, short attribute);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleScreenBufferSize", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleScreenBufferSize (IntPtr handle, Coord newSize);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleWindowInfo", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleWindowInfo (IntPtr handle, bool absolute, ref SmallRect rect);
		
		[DllImport ("kernel32.dll", EntryPoint="GetConsoleTitle", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static int GetConsoleTitle (StringBuilder sb, int size);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleTitle", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleTitle (string title);
		
		[DllImport ("kernel32.dll", EntryPoint="GetConsoleCursorInfo", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool GetConsoleCursorInfo (IntPtr handle, out ConsoleCursorInfo info);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleCursorInfo", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleCursorInfo (IntPtr handle, ref ConsoleCursorInfo info);
		
		[DllImport ("user32.dll", EntryPoint="GetKeyState", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static short GetKeyState (int virtKey);
		
		[DllImport ("kernel32.dll", EntryPoint="GetConsoleMode", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool GetConsoleMode (IntPtr handle, out int mode);
		
		[DllImport ("kernel32.dll", EntryPoint="SetConsoleMode", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool SetConsoleMode (IntPtr handle, int mode);
		
		[DllImport ("kernel32.dll", EntryPoint="PeekConsoleInput", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool PeekConsoleInput (IntPtr handle, out InputRecord record, int length, out int eventsRead);
		
		[DllImport ("kernel32.dll", EntryPoint="ReadConsoleInput", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool ReadConsoleInput (IntPtr handle, out InputRecord record, int length, out int nread);
		
		[DllImport ("kernel32.dll", EntryPoint="GetLargestConsoleWindowSize", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static Coord GetLargestConsoleWindowSize (IntPtr handle);
		
		[DllImport ("kernel32.dll", EntryPoint="ReadConsoleOutput", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool ReadConsoleOutput (IntPtr handle, void *buffer, Coord bsize, Coord bpos, ref SmallRect region);
		
		[DllImport ("kernel32.dll", EntryPoint="WriteConsoleOutput", SetLastError=true, CharSet=CharSet.Unicode)]
		extern static bool WriteConsoleOutput (IntPtr handle, CharInfo [] buffer, Coord bsize, Coord bpos, ref SmallRect region);

	}
}
