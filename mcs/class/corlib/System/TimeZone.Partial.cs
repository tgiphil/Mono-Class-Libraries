//
// System.TimeZone.cs
//
// Authors:
//   Duncan Mak (duncan@ximian.com)
//   Ajay Kumar Dwivedi (adwiv@yahoo.com)
//   Martin Baulig (martin@gnome.org)
//
// (C) Ximian, Inc.
// Copyright (C) 2004-2006 Novell, Inc (http://www.novell.com)
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
//
// TODO:
//
//    Rewrite ToLocalTime to use GetLocalTimeDiff(DateTime,TimeSpan),
//    this should only leave the validation at the beginning (for MaxValue)
//    and then call the helper function.  This would remove all the
//    ifdefs in that code, and replace it with only one, for the construction
//    of the object.
//
//    Rewrite ToUniversalTime to use a similar setup to that
//
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace System
{
	 partial class CurrentSystemTimeZone
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern bool GetTimeZoneData (int year, out Int64[] data, out string[] names);

	}
}
