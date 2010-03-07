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
