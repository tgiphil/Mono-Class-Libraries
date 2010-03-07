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
