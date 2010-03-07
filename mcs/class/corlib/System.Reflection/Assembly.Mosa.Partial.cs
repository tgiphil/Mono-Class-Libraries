using System.Security;
using System.Security.Policy;
using System.Security.Permissions;
using System.Runtime.Serialization;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections;
using System.Configuration.Assemblies;
using Mono.Security;

namespace System.Reflection
{
	public partial class Assembly
	{
		private string get_code_base (bool escaped)
		{
			throw new System.NotImplementedException();
		}
		private string get_fullname ()
		{
			throw new System.NotImplementedException();
		}
		private string get_location ()
		{
			throw new System.NotImplementedException();
		}
		private string InternalImageRuntimeVersion ()
		{
			throw new System.NotImplementedException();
		}
		public virtual MethodInfo EntryPoint {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		private bool get_global_assembly_cache ()
		{
			throw new System.NotImplementedException();
		}
		private object GetFilesInternal (String name, bool getResourceModules)
		{
			throw new System.NotImplementedException();
		}
		internal IntPtr GetManifestResourceInternal (String name, out int size, out Module module)
		{
			throw new System.NotImplementedException();
		}
		internal virtual Type[] GetTypes (bool exportedOnly)
		{
			throw new System.NotImplementedException();
		}
		internal Type InternalGetType (Module module, String name, Boolean throwOnError, Boolean ignoreCase)
		{
			throw new System.NotImplementedException();
		}
		internal static void InternalGetAssemblyName (string assemblyFile, AssemblyName aname)
		{
			throw new System.NotImplementedException();
		}
		static void FillName (Assembly ass, AssemblyName aname)
		{
			throw new System.NotImplementedException();
		}
		public static Assembly GetEntryAssembly()
		{
			throw new System.NotImplementedException();
		}
		private static Assembly LoadFrom (String assemblyFile, bool refonly)
		{
			throw new System.NotImplementedException();
		}
		private static Assembly load_with_partial_name (string name, Evidence e)
		{
			throw new System.NotImplementedException();
		}
		internal virtual Module[] GetModulesInternal ()
		{
			throw new System.NotImplementedException();
		}
		internal string[] GetNamespaces ()
		{
			throw new System.NotImplementedException();
		}
		public virtual String[] GetManifestResourceNames ()
		{
			throw new System.NotImplementedException();
		}
		public static Assembly GetExecutingAssembly ()
		{
			throw new System.NotImplementedException();
		}
		public static Assembly GetCallingAssembly ()
		{
			throw new System.NotImplementedException();
		}
		public AssemblyName[] GetReferencedAssemblies ()
		{
			throw new System.NotImplementedException();
		}
		private bool GetManifestResourceInfoInternal (String name, ManifestResourceInfo info)
		{
			throw new System.NotImplementedException();
		}
		internal static int MonoDebugger_GetMethodToken (MethodBase method)
		{
			throw new System.NotImplementedException();
		}
		internal Module GetManifestModuleInternal ()
		{
			throw new System.NotImplementedException();
		}
		public virtual bool ReflectionOnly {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		internal static bool LoadPermissions (Assembly a,
		ref IntPtr minimum, ref int minLength,
		ref IntPtr optional, ref int optLength,
		ref IntPtr refused, ref int refLength)
		{
			throw new System.NotImplementedException();
		}

	}
}
