//
// System.Reflection/Module.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
// Copyright (C) 2004-2005 Novell, Inc (http://www.novell.com)
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

using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Collections.Generic;

namespace System.Reflection
{
	public partial class Module
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern int get_MetadataToken (Module module);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern int GetMDStreamVersion (IntPtr module_handle);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Type[] InternalGetTypes ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern IntPtr GetHINSTANCE ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string GetGuidInternal ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Type GetGlobalType ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveTypeToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveMethodToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveFieldToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern string ResolveStringToken (IntPtr module, int token, out ResolveTokenError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern MemberInfo ResolveMemberToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern byte[] ResolveSignature (IntPtr module, int metadataToken, out ResolveTokenError error);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern void GetPEKind (IntPtr module, out PortableExecutableKinds peKind, out ImageFileMachine machine);

	}
}
