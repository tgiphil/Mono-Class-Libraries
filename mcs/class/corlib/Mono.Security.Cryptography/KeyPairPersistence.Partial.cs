using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using Mono.Xml;

namespace Mono.Security.Cryptography
{
	public partial class KeyPairPersistence
	{
		
#if INSIDE_CORLIB
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern bool _CanSecure (string root);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern bool _ProtectUser (string path);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern bool _ProtectMachine (string path);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern bool _IsUserProtected (string path);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern bool _IsMachineProtected (string path);

	}
}
