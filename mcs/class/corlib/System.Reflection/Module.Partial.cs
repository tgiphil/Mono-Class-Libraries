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
		
		public extern int MetadataToken {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern int GetMDStreamVersion (IntPtr module_handle);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern Type[] InternalGetTypes ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern IntPtr GetHINSTANCE ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string GetGuidInternal ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern Type GetGlobalType ();
		
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
