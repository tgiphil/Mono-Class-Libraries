using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Configuration.Assemblies;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;

namespace System
{
	public partial class Activator
	{
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern object CreateInstanceInternal (Type type);

	}
}
