// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamClient006VTable
	{
		public IntPtr CreateSteamPipe0;
		public IntPtr BReleaseSteamPipe1;
		public IntPtr CreateGlobalUser2;
		public IntPtr ConnectToGlobalUser3;
		public IntPtr CreateLocalUser4;
		public IntPtr ReleaseUser5;
		public IntPtr GetISteamUser6;
		public IntPtr GetIVAC7;
		public IntPtr GetISteamGameServer8;
		public IntPtr SetLocalIPBinding9;
		public IntPtr GetUniverseName10;
		public IntPtr GetISteamFriends11;
		public IntPtr GetISteamUtils12;
		public IntPtr GetISteamBilling13;
		public IntPtr GetISteamMatchmaking14;
		public IntPtr GetISteamContentServer15;
		public IntPtr GetISteamApps16;
		public IntPtr GetISteamMasterServerUpdater17;
		public IntPtr GetISteamMatchmakingServers18;
		public IntPtr RunFrame19;
		public IntPtr GetIPCCallCount20;
		private IntPtr DTorISteamClient00621;
	};
	
	[InteropHelp.InterfaceVersion("SteamClient006")]
	public class ISteamClient006 : InteropHelp.NativeWrapper<ISteamClient006VTable>
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
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateGlobalUserI( IntPtr thisptr, ref Int32 phSteamPipe );
		public Int32 CreateGlobalUser( ref Int32 phSteamPipe ) 
		{
			return this.GetFunction<NativeCreateGlobalUserI>( this.Functions.CreateGlobalUser2 )( this.ObjectAddress, ref phSteamPipe ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeConnectToGlobalUserI( IntPtr thisptr, Int32 hSteamPipe );
		public Int32 ConnectToGlobalUser( Int32 hSteamPipe ) 
		{
			return this.GetFunction<NativeConnectToGlobalUserI>( this.Functions.ConnectToGlobalUser3 )( this.ObjectAddress, hSteamPipe ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateLocalUserI( IntPtr thisptr, ref Int32 phSteamPipe );
		public Int32 CreateLocalUser( ref Int32 phSteamPipe ) 
		{
			return this.GetFunction<NativeCreateLocalUserI>( this.Functions.CreateLocalUser4 )( this.ObjectAddress, ref phSteamPipe ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeReleaseUserII( IntPtr thisptr, Int32 hSteamPipe, Int32 hUser );
		public void ReleaseUser( Int32 hSteamPipe, Int32 hUser ) 
		{
			this.GetFunction<NativeReleaseUserII>( this.Functions.ReleaseUser5 )( this.ObjectAddress, hSteamPipe, hUser ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamUserIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamUser<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamUserIIS>( this.Functions.GetISteamUser6 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIVACI( IntPtr thisptr, Int32 hSteamUser );
		public TClass GetIVAC<TClass>( Int32 hSteamUser ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetIVACI>( this.Functions.GetIVAC7 )( this.ObjectAddress, hSteamUser ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamGameServerIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamGameServer<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamGameServerIIS>( this.Functions.GetISteamGameServer8 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLocalIPBindingUU( IntPtr thisptr, UInt32 unIP, UInt16 usPort );
		public void SetLocalIPBinding( UInt32 unIP, UInt16 usPort ) 
		{
			this.GetFunction<NativeSetLocalIPBindingUU>( this.Functions.SetLocalIPBinding9 )( this.ObjectAddress, unIP, usPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetUniverseNameE( IntPtr thisptr, EUniverse eUniverse );
		public string GetUniverseName( EUniverse eUniverse ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetUniverseNameE>( this.Functions.GetUniverseName10 )( this.ObjectAddress, eUniverse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamFriendsIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamFriends<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamFriendsIIS>( this.Functions.GetISteamFriends11 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamUtilsIS( IntPtr thisptr, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamUtils<TClass>( Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamUtilsIS>( this.Functions.GetISteamUtils12 )( this.ObjectAddress, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamBillingIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamBilling<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamBillingIIS>( this.Functions.GetISteamBilling13 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamMatchmakingIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamMatchmaking<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamMatchmakingIIS>( this.Functions.GetISteamMatchmaking14 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamContentServerIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamContentServer<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamContentServerIIS>( this.Functions.GetISteamContentServer15 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamAppsIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamApps<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamAppsIIS>( this.Functions.GetISteamApps16 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamMasterServerUpdaterIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamMasterServerUpdater<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamMasterServerUpdaterIIS>( this.Functions.GetISteamMasterServerUpdater17 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetISteamMatchmakingServersIIS( IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion );
		public TClass GetISteamMatchmakingServers<TClass>( Int32 hSteamUser, Int32 hSteamPipe ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeGetISteamMatchmakingServersIIS>( this.Functions.GetISteamMatchmakingServers18 )( this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier( typeof( TClass ) ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRunFrame( IntPtr thisptr );
		public void RunFrame(  ) 
		{
			this.GetFunction<NativeRunFrame>( this.Functions.RunFrame19 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetIPCCallCount( IntPtr thisptr );
		public UInt32 GetIPCCallCount(  ) 
		{
			return this.GetFunction<NativeGetIPCCallCount>( this.Functions.GetIPCCallCount20 )( this.ObjectAddress ); 
		}
		
	};
}
