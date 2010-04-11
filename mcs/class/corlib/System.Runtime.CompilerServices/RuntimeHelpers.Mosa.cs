/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.ConstrainedExecution;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	public partial class RuntimeHelpers
	{
		static void InitializeArray (Array array, IntPtr fldHandle)
		{
			throw new System.NotImplementedException();
		}
		public static int OffsetToStringData {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static object GetObjectValue (object obj)
		{
			throw new System.NotImplementedException();
		}
		static void RunClassConstructor (IntPtr type)
		{
			throw new System.NotImplementedException();
		}
		static bool SufficientExecutionStack ()
		{
			throw new System.NotImplementedException();
		}
		public static void RunModuleConstructor (IntPtr module)
		{
			throw new System.NotImplementedException();
		}

	}
}
