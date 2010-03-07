using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;

#if NET_2_1 && !MONOTOUCH
namespace System.Security
{
	 partial class SecurityManager
	{
		public static bool SecurityEnabled {
			get
			{
				throw new System.NotImplementedException();
			}
		}

	}
}
#endif