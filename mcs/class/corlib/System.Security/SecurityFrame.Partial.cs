using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;

namespace System.Security
{
	 partial struct SecurityFrame
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static RuntimeSecurityFrame _GetSecurityFrame (int skip);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static Array _GetSecurityStack (int skip);

	}
}
