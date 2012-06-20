// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamClient011VTable
	{
		public IntPtr CreateSteamPipe0;
		public IntPtr BReleaseSteamPipe1;
		public IntPtr ConnectToGlobalUser2;
		public IntPtr CreateLocalUser3;
		public IntPtr ReleaseUser4;
		public IntPtr GetISteamUser5;
		public IntPtr GetISteamGameServer6;
		public IntPtr SetLocalIPBinding7;
		public IntPtr GetISteamFriends8;
		public IntPtr GetISteamUtils9;
		public IntPtr GetISteamMatchmaking10;
		public IntPtr GetISteamMasterServerUpdater11;
		public IntPtr GetISteamMatchmakingServers12;
		public IntPtr GetISteamGenericInterface13;
		public IntPtr GetISteamUserStats14;
		public IntPtr GetISteamGameServerStats15;
		public IntPtr GetISteamApps16;
		public IntPtr GetISteamNetworking17;
		public IntPtr GetISteamRemoteStorage18;
		public IntPtr GetISteamScreenshots19;
		public IntPtr RunFrame20;
		public IntPtr GetIPCCallCount21;
		public IntPtr SetWarningMessageHook22;
		public IntPtr BShutdownIfAllPipesClosed23;
		public IntPtr GetISteamHTTP24;
		private IntPtr DTorISteamClient01125;
	};
	
	[InteropHelp.InterfaceVersion("SteamClient011")]
	public class ISteamClient011 : InteropHelp.NativeWrapper<ISteamClient011VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateSteamPipe( IntPtr thisptr );
		public Int32 CreateSteamPipe(  ) 
		{
			return this.GetFunction<NativeCreateSteamPipe>( this.Functions.CreateSteamPipe0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBReleaseSteamPipeI( IntPtr thisptr, Int32 hSteamPipe );
		public bool BReleaseSteamPipe( Int32 hSteamPipe ) 
		{
			return this.GetFunction<NativeBReleaseSteamPipeI>( this.Functions.BReleaseSteamPipe1 )( this.ObjectAddress, hSteamPipe ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeConnectToGlobalUserI( IntPtr thisptr, Int32 hSteamPipe );
		public Int32 ConnectToGlobalUser( Int32 hSteamPipe ) 
		{
			return this.GetFunction<NativeConnectToGlobalUserI>( this.Functions.ConnectToGlobalUser2 )( this.ObjectAddress, hSteamPipe ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateLocalUserIE( IntPtr thisptr, ref Int32 phSteamPipe, EAccountType eAccountType );
		public Int32 CreateLocalUser( ref Int32 phSteamPipe, EAccountType eAccountType ) 
		{
			return this.GetFunction<NativeCreateLocalUserIE>( this.Functions.CreateLocalUser3 )( this.ObjectAddress, ref phSteamPipe, eAccountType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeReleaseUserII( IntPtr thisptr, Int32 hSteamPipe, Int32 hUser );
		public void ReleaseUser( Int32 hSteamPipe, Int32 hUser ) 
		{
			this.GetFunction<NativeReleaseUserII>( this.Functions.ReleaseUser4 )( this.ObjectAddress, hSteamPipe, hUser ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamUserIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamUser<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamUserIIS>( this.Functions.GetISteamUser5 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamGameServerIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamGameServer<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamGameServerIIS>( this.Functions.GetISteamGameServer6 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLocalIPBindingUU( IntPtr thisptr, UInt32 unIP, UInt16 usPort );
		public void SetLocalIPBinding( UInt32 unIP, UInt16 usPort ) 
		{
			this.GetFunction<NativeSetLocalIPBindingUU>( this.Functions.SetLocalIPBinding7 )( this.ObjectAddress, unIP, usPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamFriendsIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamFriends<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamFriendsIIS>( this.Functions.GetISteamFriends8 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamUtilsIS( IntPtr thisptr, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamUtils<TClass>( Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamUtilsIS>( this.Functions.GetISteamUtils9 )( this.ObjectAddress, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamMatchmakingIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamMatchmaking<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamMatchmakingIIS>( this.Functions.GetISteamMatchmaking10 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamMasterServerUpdaterIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamMasterServerUpdater<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamMasterServerUpdaterIIS>( this.Functions.GetISteamMasterServerUpdater11 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamMatchmakingServersIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamMatchmakingServers<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamMatchmakingServersIIS>( this.Functions.GetISteamMatchmakingServers12 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamGenericInterfaceIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamGenericInterface<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamGenericInterfaceIIS>( this.Functions.GetISteamGenericInterface13 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamUserStatsIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamUserStats<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamUserStatsIIS>( this.Functions.GetISteamUserStats14 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamGameServerStatsIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamGameServerStats<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamGameServerStatsIIS>( this.Functions.GetISteamGameServerStats15 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamAppsIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamApps<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamAppsIIS>( this.Functions.GetISteamApps16 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamNetworkingIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamNetworking<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamNetworkingIIS>( this.Functions.GetISteamNetworking17 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamRemoteStorageIIS( IntPtr thisptr, Int32 hSteamuser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamRemoteStorage<TClass>( Int32 hSteamuser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamRemoteStorageIIS>( this.Functions.GetISteamRemoteStorage18 )( this.ObjectAddress, hSteamuser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamScreenshotsIIS( IntPtr thisptr, Int32 hSteamuser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamScreenshots<TClass>( Int32 hSteamuser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamScreenshotsIIS>( this.Functions.GetISteamScreenshots19 )( this.ObjectAddress, hSteamuser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRunFrame( IntPtr thisptr );
		public void RunFrame(  ) 
		{
			this.GetFunction<NativeRunFrame>( this.Functions.RunFrame20 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetIPCCallCount( IntPtr thisptr );
		public UInt32 GetIPCCallCount(  ) 
		{
			return this.GetFunction<NativeGetIPCCallCount>( this.Functions.GetIPCCallCount21 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetWarningMessageHookI( IntPtr thisptr, ref IntPtr pFunction );
		public void SetWarningMessageHook( ref IntPtr pFunction ) 
		{
			this.GetFunction<NativeSetWarningMessageHookI>( this.Functions.SetWarningMessageHook22 )( this.ObjectAddress, ref pFunction ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBShutdownIfAllPipesClosed( IntPtr thisptr );
		public bool BShutdownIfAllPipesClosed(  ) 
		{
			return this.GetFunction<NativeBShutdownIfAllPipesClosed>( this.Functions.BShutdownIfAllPipesClosed23 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamHTTPIIS( IntPtr thisptr, Int32 hSteamuser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamHTTP<TClass>( Int32 hSteamuser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamHTTPIIS>( this.Functions.GetISteamHTTP24 )( this.ObjectAddress, hSteamuser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
	};
}
