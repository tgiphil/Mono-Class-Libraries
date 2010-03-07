using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Authenticode;

namespace System.Security.Policy
{
	public partial class Evidence
	{
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern bool IsAuthenticodePresent (Assembly a);

	}
}
