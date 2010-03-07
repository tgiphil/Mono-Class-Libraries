using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Runtime.InteropServices;

namespace System
{
	public partial class Environment
	{
		
		public extern static int ExitCode
		{	
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		set;
		}
		
#if NET_1_1
		static
#endif
		public extern bool HasShutdownStarted
		{
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		
		public extern static string MachineName {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[EnvironmentPermission (SecurityAction.Demand, Read="COMPUTERNAME")]
		[SecurityPermission (SecurityAction.Demand, UnmanagedCode=true)]
		get;
		}
		
		public extern static string NewLine {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		internal static extern PlatformID Platform {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern string GetOSVersionString ();
#endif
		public extern static int TickCount {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		public extern static string UserName {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[EnvironmentPermission (SecurityAction.Demand, Read="USERNAME;USER")]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[SecurityPermission (SecurityAction.Demand, UnmanagedCode=true)]
		public extern static void Exit (int exitCode);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		[EnvironmentPermissionAttribute (SecurityAction.Demand, Read = "PATH")]
		public extern static string[] GetCommandLineArgs ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static string internalGetEnvironmentVariable (string variable);
#endif
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string GetWindowsFolderPath (int folder);
		
#if NET_2_0 && !NET_2_1
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern void internalBroadcastSettingChange ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern void InternalSetEnvironmentVariable (string variable, string value);
#endif
#if NET_2_0
		public static extern int ProcessorCount {
		[EnvironmentPermission (SecurityAction.Demand, Read="NUMBER_OF_PROCESSORS")]
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;			
		}
#pragma warning restore 169
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static string internalGetGacPath ();
#endif
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string [] GetLogicalDrivesInternal ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static string [] GetEnvironmentVariableNames ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static string GetMachineConfigPath ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static string internalGetHome ();

	}
}
