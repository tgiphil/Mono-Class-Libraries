using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.IO;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Reflection
{
	public partial class AssemblyName
	{
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern bool ParseName (AssemblyName aname, string assemblyName);

	}
}
