using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	public partial class SignatureHelper
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern byte[] get_signature_local ();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern byte[] get_signature_field ();

	}
}
