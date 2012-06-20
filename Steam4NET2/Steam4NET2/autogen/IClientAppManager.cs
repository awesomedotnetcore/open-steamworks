// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientAppManagerVTable
	{
		public IntPtr InstallApp0;
		public IntPtr ConvertFromSteam21;
		public IntPtr UninstallApp2;
		public IntPtr LaunchApp3;
		public IntPtr ShutdownApp4;
		public IntPtr GetAppState5;
		public IntPtr GetAppSizeOnDisk6;
		public IntPtr GetAppDir7;
		public IntPtr GetAppDependency8;
		public IntPtr GetDependentApps9;
		public IntPtr GetUpdateInfo10;
		public IntPtr SetContentLocked11;
		public IntPtr StartValidatingApp12;
		public IntPtr SetAppConfig13;
		public IntPtr BIsAppUpToDate14;
		public IntPtr BCheckBetaPassword15;
		public IntPtr SetDownloadingEnabled16;
		public IntPtr BIsDownloadingEnabled17;
		public IntPtr GetDownloadStats18;
		public IntPtr GetDownloadingAppID19;
		public IntPtr ChangeAppPriority20;
		public IntPtr AddSteam2Update21;
		public IntPtr RemoveSteam2Update22;
		public IntPtr StalledSteam2Update23;
		public IntPtr BHasLocalContentServer24;
		public IntPtr BuildBackup25;
		public IntPtr BuildInstaller26;
		public IntPtr CancelBackup27;
		public IntPtr RestoreApp28;
		public IntPtr BNeedsFile29;
		public IntPtr BAddFileOnDisk30;
		public IntPtr FinishAddingFiles31;
		private IntPtr DTorIClientAppManager32;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTAPPMANAGER_INTERFACE_VERSION001")]
	public class IClientAppManager : InteropHelp.NativeWrapper<IClientAppManagerVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EAppUpdateError NativeInstallAppUB( IntPtr thisptr, UInt32 unAppID, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		public EAppUpdateError InstallApp( UInt32 unAppID, bool arg1 ) 
		{
			return this.GetFunction<NativeInstallAppUB>( this.Functions.InstallApp0 )( this.ObjectAddress, unAppID, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EAppUpdateError NativeConvertFromSteam2US( IntPtr thisptr, UInt32 unAppID, string cszPath );
		public EAppUpdateError ConvertFromSteam2( UInt32 unAppID, string cszPath ) 
		{
			return this.GetFunction<NativeConvertFromSteam2US>( this.Functions.ConvertFromSteam21 )( this.ObjectAddress, unAppID, cszPath ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EAppUpdateError NativeUninstallAppUB( IntPtr thisptr, UInt32 unAppID, [MarshalAs(UnmanagedType.I1)] bool bComplete );
		public EAppUpdateError UninstallApp( UInt32 unAppID, bool bComplete ) 
		{
			return this.GetFunction<NativeUninstallAppUB>( this.Functions.UninstallApp2 )( this.ObjectAddress, unAppID, bComplete ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EAppUpdateError NativeLaunchAppUUS( IntPtr thisptr, UInt32 unAppID, UInt32 uLaunchOption, string pszUserArgs );
		public EAppUpdateError LaunchApp( UInt32 unAppID, UInt32 uLaunchOption, string pszUserArgs ) 
		{
			return this.GetFunction<NativeLaunchAppUUS>( this.Functions.LaunchApp3 )( this.ObjectAddress, unAppID, uLaunchOption, pszUserArgs ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeShutdownAppUB( IntPtr thisptr, UInt32 unAppID, [MarshalAs(UnmanagedType.I1)] bool bForce );
		public bool ShutdownApp( UInt32 unAppID, bool bForce ) 
		{
			return this.GetFunction<NativeShutdownAppUB>( this.Functions.ShutdownApp4 )( this.ObjectAddress, unAppID, bForce ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EAppState NativeGetAppStateU( IntPtr thisptr, UInt32 unAppID );
		public EAppState GetAppState( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeGetAppStateU>( this.Functions.GetAppState5 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAppSizeOnDiskUUU( IntPtr thisptr, UInt32 unAppID, ref UInt64 pullAppSize, ref UInt64 pullUnk );
		public bool GetAppSizeOnDisk( UInt32 unAppID, ref UInt64 pullAppSize, ref UInt64 pullUnk ) 
		{
			return this.GetFunction<NativeGetAppSizeOnDiskUUU>( this.Functions.GetAppSizeOnDisk6 )( this.ObjectAddress, unAppID, ref pullAppSize, ref pullUnk ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppDirUSU( IntPtr thisptr, UInt32 unAppID, StringBuilder pchPath, UInt32 cbPath );
		public UInt32 GetAppDir( UInt32 unAppID, StringBuilder pchPath ) 
		{
			return this.GetFunction<NativeGetAppDirUSU>( this.Functions.GetAppDir7 )( this.ObjectAddress, unAppID, pchPath, (UInt32) pchPath.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppDependencyU( IntPtr thisptr, UInt32 unAppID );
		public UInt32 GetAppDependency( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeGetAppDependencyU>( this.Functions.GetAppDependency8 )( this.ObjectAddress, unAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetDependentAppsUUI( IntPtr thisptr, UInt32 unAppID, ref UInt32 punAppIDs, Int32 cAppIDsMax );
		public UInt32 GetDependentApps( UInt32 unAppID, ref UInt32 punAppIDs, Int32 cAppIDsMax ) 
		{
			return this.GetFunction<NativeGetDependentAppsUUI>( this.Functions.GetDependentApps9 )( this.ObjectAddress, unAppID, ref punAppIDs, cAppIDsMax ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetUpdateInfoUA( IntPtr thisptr, UInt32 unAppID, ref AppUpdateInfo_s pUpdateInfo );
		public UInt32 GetUpdateInfo( UInt32 unAppID, ref AppUpdateInfo_s pUpdateInfo ) 
		{
			return this.GetFunction<NativeGetUpdateInfoUA>( this.Functions.GetUpdateInfo10 )( this.ObjectAddress, unAppID, ref pUpdateInfo ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetContentLockedUB( IntPtr thisptr, UInt32 unAppID, [MarshalAs(UnmanagedType.I1)] bool bLockContent );
		public bool SetContentLocked( UInt32 unAppID, bool bLockContent ) 
		{
			return this.GetFunction<NativeSetContentLockedUB>( this.Functions.SetContentLocked11 )( this.ObjectAddress, unAppID, bLockContent ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStartValidatingAppU( IntPtr thisptr, UInt32 unAppID );
		public bool StartValidatingApp( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeStartValidatingAppU>( this.Functions.StartValidatingApp12 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAppConfigUBIB( IntPtr thisptr, UInt32 unAppID, Byte[] pchBuffer, Int32 cbBuffer, [MarshalAs(UnmanagedType.I1)] bool bSharedKVSymbols );
		public bool SetAppConfig( UInt32 unAppID, Byte[] pchBuffer, bool bSharedKVSymbols ) 
		{
			return this.GetFunction<NativeSetAppConfigUBIB>( this.Functions.SetAppConfig13 )( this.ObjectAddress, unAppID, pchBuffer, (Int32) pchBuffer.Length, bSharedKVSymbols ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsAppUpToDateU( IntPtr thisptr, UInt32 unAppID );
		public bool BIsAppUpToDate( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBIsAppUpToDateU>( this.Functions.BIsAppUpToDate14 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBCheckBetaPasswordUSS( IntPtr thisptr, UInt32 unAppID, string cszBetaKey, string cszBetaPassword );
		public bool BCheckBetaPassword( UInt32 unAppID, string cszBetaKey, string cszBetaPassword ) 
		{
			return this.GetFunction<NativeBCheckBetaPasswordUSS>( this.Functions.BCheckBetaPassword15 )( this.ObjectAddress, unAppID, cszBetaKey, cszBetaPassword ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetDownloadingEnabledB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bState );
		public bool SetDownloadingEnabled( bool bState ) 
		{
			return this.GetFunction<NativeSetDownloadingEnabledB>( this.Functions.SetDownloadingEnabled16 )( this.ObjectAddress, bState ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsDownloadingEnabled( IntPtr thisptr );
		public bool BIsDownloadingEnabled(  ) 
		{
			return this.GetFunction<NativeBIsDownloadingEnabled>( this.Functions.BIsDownloadingEnabled17 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetDownloadStatsD( IntPtr thisptr, ref DownloadStats_s pDownloadStats );
		public bool GetDownloadStats( ref DownloadStats_s pDownloadStats ) 
		{
			return this.GetFunction<NativeGetDownloadStatsD>( this.Functions.GetDownloadStats18 )( this.ObjectAddress, ref pDownloadStats ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetDownloadingAppID( IntPtr thisptr );
		public UInt32 GetDownloadingAppID(  ) 
		{
			return this.GetFunction<NativeGetDownloadingAppID>( this.Functions.GetDownloadingAppID19 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeChangeAppPriorityUE( IntPtr thisptr, UInt32 unAppID, EAppDownloadPriority ePriority );
		public bool ChangeAppPriority( UInt32 unAppID, EAppDownloadPriority ePriority ) 
		{
			return this.GetFunction<NativeChangeAppPriorityUE>( this.Functions.ChangeAppPriority20 )( this.ObjectAddress, unAppID, ePriority ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddSteam2UpdateU( IntPtr thisptr, UInt32 unAppID );
		public bool AddSteam2Update( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeAddSteam2UpdateU>( this.Functions.AddSteam2Update21 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveSteam2UpdateU( IntPtr thisptr, UInt32 unAppID );
		public bool RemoveSteam2Update( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeRemoveSteam2UpdateU>( this.Functions.RemoveSteam2Update22 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStalledSteam2UpdateU( IntPtr thisptr, UInt32 unAppID );
		public bool StalledSteam2Update( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeStalledSteam2UpdateU>( this.Functions.StalledSteam2Update23 )( this.ObjectAddress, unAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBHasLocalContentServer( IntPtr thisptr );
		public bool BHasLocalContentServer(  ) 
		{
			return this.GetFunction<NativeBHasLocalContentServer>( this.Functions.BHasLocalContentServer24 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBuildBackupUUS( IntPtr thisptr, UInt32 unAppID, UInt64 ullMaxFileSize, string cszBackupPath );
		public bool BuildBackup( UInt32 unAppID, UInt64 ullMaxFileSize, string cszBackupPath ) 
		{
			return this.GetFunction<NativeBuildBackupUUS>( this.Functions.BuildBackup25 )( this.ObjectAddress, unAppID, ullMaxFileSize, cszBackupPath ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBuildInstallerSSS( IntPtr thisptr, string cszProjectFile, string cszBackupPath, string arg2 );
		public bool BuildInstaller( string cszProjectFile, string cszBackupPath, string arg2 ) 
		{
			return this.GetFunction<NativeBuildInstallerSSS>( this.Functions.BuildInstaller26 )( this.ObjectAddress, cszProjectFile, cszBackupPath, arg2 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCancelBackup( IntPtr thisptr );
		public bool CancelBackup(  ) 
		{
			return this.GetFunction<NativeCancelBackup>( this.Functions.CancelBackup27 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EAppUpdateError NativeRestoreAppUS( IntPtr thisptr, UInt32 unAppID, string cszBackupPath );
		public EAppUpdateError RestoreApp( UInt32 unAppID, string cszBackupPath ) 
		{
			return this.GetFunction<NativeRestoreAppUS>( this.Functions.RestoreApp28 )( this.ObjectAddress, unAppID, cszBackupPath ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBNeedsFileUSUU( IntPtr thisptr, UInt32 unAppID, string cszFilePath, UInt64 ullFileSize, UInt32 uUnk );
		public bool BNeedsFile( UInt32 unAppID, string cszFilePath, UInt64 ullFileSize, UInt32 uUnk ) 
		{
			return this.GetFunction<NativeBNeedsFileUSUU>( this.Functions.BNeedsFile29 )( this.ObjectAddress, unAppID, cszFilePath, ullFileSize, uUnk ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBAddFileOnDiskUSUUS( IntPtr thisptr, UInt32 unAppID, string cszFilePath, UInt64 ullFileSize, UInt32 uUnk, SHADigestWrapper_t ubSha1 );
		public bool BAddFileOnDisk( UInt32 unAppID, string cszFilePath, UInt64 ullFileSize, UInt32 uUnk, SHADigestWrapper_t ubSha1 ) 
		{
			return this.GetFunction<NativeBAddFileOnDiskUSUUS>( this.Functions.BAddFileOnDisk30 )( this.ObjectAddress, unAppID, cszFilePath, ullFileSize, uUnk, ubSha1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFinishAddingFilesU( IntPtr thisptr, UInt32 unAppID );
		public UInt64 FinishAddingFiles( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeFinishAddingFilesU>( this.Functions.FinishAddingFiles31 )( this.ObjectAddress, unAppID ); 
		}
		
	};
}
