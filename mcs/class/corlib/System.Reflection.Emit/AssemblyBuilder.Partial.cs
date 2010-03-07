using System;
using System.Reflection;
using System.Resources;
using System.IO;
using System.Security.Policy;
using System.Runtime.Serialization;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Reflection.Emit
{
	public partial class AssemblyBuilder
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void basic_init (AssemblyBuilder ab);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern Module InternalAddModule (string fileName);

	}
}
