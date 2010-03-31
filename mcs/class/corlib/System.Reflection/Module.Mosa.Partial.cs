/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;

namespace System.Reflection
{
	public partial class Module
	{
		public int MetadataToken {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		internal static int GetMDStreamVersion (IntPtr module_handle)
		{
			throw new System.NotImplementedException();
		}
		private Type[] InternalGetTypes ()
		{
			throw new System.NotImplementedException();
		}
		internal IntPtr GetHINSTANCE ()
		{
			throw new System.NotImplementedException();
		}
		private string GetGuidInternal ()
		{
			throw new System.NotImplementedException();
		}
		private Type GetGlobalType ()
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr ResolveTypeToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error)
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr ResolveMethodToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error)
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr ResolveFieldToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error)
		{
			throw new System.NotImplementedException();
		}
		internal static string ResolveStringToken (IntPtr module, int token, out ResolveTokenError error)
		{
			throw new System.NotImplementedException();
		}
		internal static MemberInfo ResolveMemberToken (IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error)
		{
			throw new System.NotImplementedException();
		}
		internal static byte[] ResolveSignature (IntPtr module, int metadataToken, out ResolveTokenError error)
		{
			throw new System.NotImplementedException();
		}
		internal static void GetPEKind (IntPtr module, out PortableExecutableKinds peKind, out ImageFileMachine machine)
		{
			throw new System.NotImplementedException();
		}

	}
}
