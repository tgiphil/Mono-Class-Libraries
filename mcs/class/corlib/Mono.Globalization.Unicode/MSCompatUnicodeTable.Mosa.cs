/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

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
		static void load_collation_resource (int resource_index, byte** data)
		{
			throw new System.NotImplementedException();
		}
		static void load_collation_resource (string path, int resource_index, byte** data, int* size)
		{
			throw new System.NotImplementedException();
		}

	}
}
