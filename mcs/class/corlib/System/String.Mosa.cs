/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Text;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;

using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Mono.Globalization.Unicode;

namespace System
{
	public partial class String
	{
		unsafe public String (char *value)
		{
			throw new System.NotImplementedException();
		}
		unsafe public String (char *value, int startIndex, int length)
		{
			throw new System.NotImplementedException();
		}
		unsafe public String (sbyte *value)
		{
			throw new System.NotImplementedException();
		}
		unsafe public String (sbyte *value, int startIndex, int length)
		{
			throw new System.NotImplementedException();
		}
		unsafe public String (sbyte *value, int startIndex, int length, Encoding enc)
		{
			throw new System.NotImplementedException();
		}
		public String (char [] value, int startIndex, int length)
		{
			throw new System.NotImplementedException();
		}
		public String (char [] value)
		{
			throw new System.NotImplementedException();
		}
		public String (char c, int count)
		{
			throw new System.NotImplementedException();
		}
		private String[] InternalSplit (char[] separator, int count, int options)
		{
			throw new System.NotImplementedException();
		}
		internal static String InternalAllocateStr (int length)
		{
			throw new System.NotImplementedException();
		}
		private static string InternalIntern (string str)
		{
			throw new System.NotImplementedException();
		}
		private static string InternalIsInterned (string str)
		{
			throw new System.NotImplementedException();
		}
		private static int GetLOSLimit ()
		{
			throw new System.NotImplementedException();
		}

	}
}
