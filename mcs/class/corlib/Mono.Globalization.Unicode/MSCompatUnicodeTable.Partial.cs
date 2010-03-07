using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UUtil = Mono.Globalization.Unicode.MSCompatUnicodeTableUtil;

namespace Mono.Globalization.Unicode
{
	unsafe partial class MSCompatUnicodeTable
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern void load_collation_resource (int resource_index, byte** data);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern void load_collation_resource (string path, int resource_index, byte** data, int* size);

	}
}
