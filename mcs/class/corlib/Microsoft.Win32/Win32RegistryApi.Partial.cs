//
// Microsoft.Win32/Win32RegistryApi.cs: wrapper for win32 registry API
//
// Authos:
//	Erik LeBel (eriklebel@yahoo.ca)
//      Jackson Harper (jackson@ximian.com)
//      Miguel de Icaza (miguel@gnome.org)
//
// Copyright (C) Erik LeBel 2004
// (C) 2004, 2005 Novell, Inc (http://www.novell.com)
// 

//
// Copyright (C) 2004, 2005 Novell, Inc (http://www.novell.com)
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

using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Win32
{
	 partial class Win32RegistryApi
	{
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegCreateKey")]
		static extern int RegCreateKey (IntPtr keyBase, string keyName, out IntPtr keyHandle);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegCloseKey")]
		static extern int RegCloseKey (IntPtr keyHandle);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode)]
		static extern int RegConnectRegistry (string machineName, IntPtr hKey,
		out IntPtr keyHandle);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegFlushKey")]
		private static extern int RegFlushKey (IntPtr keyHandle);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegOpenKeyEx")]
		private static extern int RegOpenKeyEx (IntPtr keyBase,
		string keyName, IntPtr reserved, int access,
		out IntPtr keyHandle);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegDeleteKey")]
		private static extern int RegDeleteKey (IntPtr keyHandle, string valueName);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegDeleteValue")]
		private static extern int RegDeleteValue (IntPtr keyHandle, string valueName);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegEnumKey")]
		private static extern int RegEnumKey (IntPtr keyBase, int index, StringBuilder nameBuffer, int bufferLength);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegEnumValue")]
		private static extern int RegEnumValue (IntPtr keyBase, 
		int index, StringBuilder nameBuffer, 
		ref int nameLength, IntPtr reserved, 
		ref RegistryValueKind type, IntPtr data, IntPtr dataLength);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegSetValueEx")]
		private static extern int RegSetValueEx (IntPtr keyBase, 
		string valueName, IntPtr reserved, RegistryValueKind type,
		string data, int rawDataLength);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegSetValueEx")]
		private static extern int RegSetValueEx (IntPtr keyBase, 
		string valueName, IntPtr reserved, RegistryValueKind type,
		byte[] rawData, int rawDataLength);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegSetValueEx")]
		private static extern int RegSetValueEx (IntPtr keyBase, 
		string valueName, IntPtr reserved, RegistryValueKind type,
		ref int data, int rawDataLength);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegQueryValueEx")]
		private static extern int RegQueryValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, ref RegistryValueKind type,
		IntPtr zero, ref int dataSize);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegQueryValueEx")]
		private static extern int RegQueryValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, ref RegistryValueKind type,
		[Out] byte[] data, ref int dataSize);
		
		[DllImport ("advapi32.dll", CharSet=CharSet.Unicode, EntryPoint="RegQueryValueEx")]
		private static extern int RegQueryValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, ref RegistryValueKind type,
		ref int data, ref int dataSize);

	}
}
