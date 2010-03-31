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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System.Threading
{
	public partial class Interlocked
	{
		public static int CompareExchange(ref int location1, int value, int comparand)
		{
			throw new System.NotImplementedException();
		}
		public static object CompareExchange(ref object location1, object value, object comparand)
		{
			throw new System.NotImplementedException();
		}
		public static float CompareExchange(ref float location1, float value, float comparand)
		{
			throw new System.NotImplementedException();
		}
		public static int Decrement(ref int location)
		{
			throw new System.NotImplementedException();
		}
		public static long Decrement(ref long location)
		{
			throw new System.NotImplementedException();
		}
		public static int Increment(ref int location)
		{
			throw new System.NotImplementedException();
		}
		public static long Increment(ref long location)
		{
			throw new System.NotImplementedException();
		}
		public static int Exchange(ref int location1, int value)
		{
			throw new System.NotImplementedException();
		}
		public static object Exchange(ref object location1, object value)
		{
			throw new System.NotImplementedException();
		}
		public static float Exchange(ref float location1, float value)
		{
			throw new System.NotImplementedException();
		}
		public static long CompareExchange(ref long location1, long value, long comparand)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
		{
			throw new System.NotImplementedException();
		}
		public static double CompareExchange(ref double location1, double value, double comparand)
		{
			throw new System.NotImplementedException();
		}
		public static T CompareExchange<T> (ref T location1, T value, T comparand) where T:class
		{
			throw new System.NotImplementedException();
		}
		public static long Exchange(ref long location1, long value)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr Exchange(ref IntPtr location1, IntPtr value)
		{
			throw new System.NotImplementedException();
		}
		public static double Exchange(ref double location1, double value)
		{
			throw new System.NotImplementedException();
		}
		public static T Exchange<T> (ref T location1, T value) where T:class
		{
			throw new System.NotImplementedException();
		}
		public static long Read(ref long location)
		{
			throw new System.NotImplementedException();
		}
		public static int Add(ref int location1, int value)
		{
			throw new System.NotImplementedException();
		}
		public static long Add(ref long location1, long value)
		{
			throw new System.NotImplementedException();
		}

	}
}
