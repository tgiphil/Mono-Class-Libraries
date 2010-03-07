using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit
{
	public partial class MethodBuilder
	{
		
#if NET_2_0 || BOOTSTRAP_NET_2_0
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public override extern MethodInfo MakeGenericMethod (params Type [] typeArguments);

	}
}
