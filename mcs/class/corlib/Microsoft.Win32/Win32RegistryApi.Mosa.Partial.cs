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
		static int RegCreateKey (IntPtr keyBase, string keyName, out IntPtr keyHandle)
		{
			throw new System.NotImplementedException();
		}
		static int RegCloseKey (IntPtr keyHandle)
		{
			throw new System.NotImplementedException();
		}
		static int RegConnectRegistry (string machineName, IntPtr hKey,
		out IntPtr keyHandle)
		{
			throw new System.NotImplementedException();
		}
		private static int RegFlushKey (IntPtr keyHandle)
		{
			throw new System.NotImplementedException();
		}
		private static int RegOpenKeyEx (IntPtr keyBase,
		string keyName, IntPtr reserved, int access,
		out IntPtr keyHandle)
		{
			throw new System.NotImplementedException();
		}
		private static int RegDeleteKey (IntPtr keyHandle, string valueName)
		{
			throw new System.NotImplementedException();
		}
		private static int RegDeleteValue (IntPtr keyHandle, string valueName)
		{
			throw new System.NotImplementedException();
		}
		private static int RegEnumKey (IntPtr keyBase, int index, StringBuilder nameBuffer, int bufferLength)
		{
			throw new System.NotImplementedException();
		}
		private static int RegEnumValue (IntPtr keyBase,
		int index, StringBuilder nameBuffer,
		ref int nameLength, IntPtr reserved,
		ref RegistryValueKind type, IntPtr data, IntPtr dataLength)
		{
			throw new System.NotImplementedException();
		}
		private static int RegSetValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, RegistryValueKind type,
		string data, int rawDataLength)
		{
			throw new System.NotImplementedException();
		}
		private static int RegSetValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, RegistryValueKind type,
		byte[] rawData, int rawDataLength)
		{
			throw new System.NotImplementedException();
		}
		private static int RegSetValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, RegistryValueKind type,
		ref int data, int rawDataLength)
		{
			throw new System.NotImplementedException();
		}
		private static int RegQueryValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, ref RegistryValueKind type,
		IntPtr zero, ref int dataSize)
		{
			throw new System.NotImplementedException();
		}
		private static int RegQueryValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, ref RegistryValueKind type,
		[Out] byte[] data, ref int dataSize)
		{
			throw new System.NotImplementedException();
		}
		private static int RegQueryValueEx (IntPtr keyBase,
		string valueName, IntPtr reserved, ref RegistryValueKind type,
		ref int data, ref int dataSize)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif