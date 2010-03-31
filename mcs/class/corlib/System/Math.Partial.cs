//
// System.Math.cs
//
// Authors:
//   Bob Smith (bob@thestuff.net)
//   Dan Lewis (dihlewis@yahoo.co.uk)
//   Pedro Martínez Juliá (yoros@wanadoo.es)
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2001 Bob Smith.  http://www.thestuff.net
// Copyright (C) 2003 Pedro Martínez Juliá <yoros@wanadoo.es>
// Copyright (C) 2004 Novell (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Runtime.CompilerServices;

#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System
{
	public partial class Math
	{
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Floor (double d);
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Round (double a);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static double Round2 (double value, int digits, bool away_from_zero);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Sin (double a);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Cos (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Tan (double a);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Sinh (double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Cosh (double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Tanh (double value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Acos (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Asin (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Atan (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Atan2 (double y, double x);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Exp (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Log (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Log10 (double d);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static double Pow (double x, double y);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
#if NET_2_0
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
#endif
		public extern static double Sqrt (double d);

	}
}
