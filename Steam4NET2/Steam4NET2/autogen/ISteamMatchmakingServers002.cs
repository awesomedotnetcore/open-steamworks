// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamMatchmakingServers002VTable
	{
		public IntPtr RequestInternetServerList0;
		public IntPtr RequestLANServerList1;
		public IntPtr RequestFriendsServerList2;
		public IntPtr RequestFavoritesServerList3;
		public IntPtr RequestHistoryServerList4;
		public IntPtr RequestSpectatorServerList5;
		public IntPtr ReleaseRequest6;
		public IntPtr GetServerDetails7;
		public IntPtr CancelQuery8;
		public IntPtr RefreshQuery9;
		public IntPtr IsRefreshing10;
		public IntPtr GetServerCount11;
		public IntPtr RefreshServer12;
		public IntPtr PingServer13;
		public IntPtr PlayerDetails14;
		public IntPtr ServerRules15;
		public IntPtr CancelServerQuery16;
		private IntPtr DTorISteamMatchmakingServers00217;
	};
	
	[InteropHelp.InterfaceVersion("SteamMatchMakingServers002")]
	public class ISteamMatchmakingServers002 : InteropHelp.NativeWrapper<ISteamMatchmakingServers002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeRequestInternetServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse );
		public TClass RequestInternetServerList<TClass>( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeRequestInternetServerListUMUI>( this.Functions.RequestInternetServerList0 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeRequestLANServerListUI( IntPtr thisptr, UInt32 iApp, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse );
		public TClass RequestLANServerList<TClass>( UInt32 iApp, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeRequestLANServerListUI>( this.Functions.RequestLANServerList1 )( this.ObjectAddress, iApp, ref pRequestServersResponse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeRequestFriendsServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse );
		public TClass RequestFriendsServerList<TClass>( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeRequestFriendsServerListUMUI>( this.Functions.RequestFriendsServerList2 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeRequestFavoritesServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse );
		public TClass RequestFavoritesServerList<TClass>( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeRequestFavoritesServerListUMUI>( this.Functions.RequestFavoritesServerList3 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeRequestHistoryServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse );
		public TClass RequestHistoryServerList<TClass>( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeRequestHistoryServerListUMUI>( this.Functions.RequestHistoryServerList4 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeRequestSpectatorServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse );
		public TClass RequestSpectatorServerList<TClass>( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse002 pRequestServersResponse ) where TClass : InteropHelp.INativeWrapper, new()
		{
			return InteropHelp.CastInterface<TClass>( this.GetFunction<NativeRequestSpectatorServerListUMUI>( this.Functions.RequestSpectatorServerList5 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeReleaseRequestB( IntPtr thisptr, Byte[] hServerListRequest );
		public void ReleaseRequest( Byte[] hServerListRequest ) 
		{
			this.GetFunction<NativeReleaseRequestB>( this.Functions.ReleaseRequest6 )( this.ObjectAddress, hServerListRequest ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate gameserveritem_t NativeGetServerDetailsBI( IntPtr thisptr, Byte[] hRequest, Int32 iServer );
		public gameserveritem_t GetServerDetails( Byte[] hRequest ) 
		{
			return this.GetFunction<NativeGetServerDetailsBI>( this.Functions.GetServerDetails7 )( this.ObjectAddress, hRequest, (Int32) hRequest.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelQueryB( IntPtr thisptr, Byte[] hRequest );
		public void CancelQuery( Byte[] hRequest ) 
		{
			this.GetFunction<NativeCancelQueryB>( this.Functions.CancelQuery8 )( this.ObjectAddress, hRequest ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRefreshQueryB( IntPtr thisptr, Byte[] hRequest );
		public void RefreshQuery( Byte[] hRequest ) 
		{
			this.GetFunction<NativeRefreshQueryB>( this.Functions.RefreshQuery9 )( this.ObjectAddress, hRequest ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsRefreshingB( IntPtr thisptr, Byte[] hRequest );
		public bool IsRefreshing( Byte[] hRequest ) 
		{
			return this.GetFunction<NativeIsRefreshingB>( this.Functions.IsRefreshing10 )( this.ObjectAddress, hRequest ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetServerCountB( IntPtr thisptr, Byte[] hRequest );
		public Int32 GetServerCount( Byte[] hRequest ) 
		{
			return this.GetFunction<NativeGetServerCountB>( this.Functions.GetServerCount11 )( this.ObjectAddress, hRequest ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRefreshServerBI( IntPtr thisptr, Byte[] hRequest, Int32 iServer );
		public void RefreshServer( Byte[] hRequest ) 
		{
			this.GetFunction<NativeRefreshServerBI>( this.Functions.RefreshServer12 )( this.ObjectAddress, hRequest, (Int32) hRequest.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativePingServerUUI( IntPtr thisptr, UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPingResponse pRequestServersResponse );
		public Int32 PingServer( UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPingResponse pRequestServersResponse ) 
		{
			return this.GetFunction<NativePingServerUUI>( this.Functions.PingServer13 )( this.ObjectAddress, unIP, usPort, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativePlayerDetailsUUI( IntPtr thisptr, UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPlayersResponse pRequestServersResponse );
		public Int32 PlayerDetails( UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPlayersResponse pRequestServersResponse ) 
		{
			return this.GetFunction<NativePlayerDetailsUUI>( this.Functions.PlayerDetails14 )( this.ObjectAddress, unIP, usPort, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeServerRulesUUI( IntPtr thisptr, UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingRulesResponse pRequestServersResponse );
		public Int32 ServerRules( UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingRulesResponse pRequestServersResponse ) 
		{
			return this.GetFunction<NativeServerRulesUUI>( this.Functions.ServerRules15 )( this.ObjectAddress, unIP, usPort, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelServerQueryI( IntPtr thisptr, Int32 hServerQuery );
		public void CancelServerQuery( Int32 hServerQuery ) 
		{
			this.GetFunction<NativeCancelServerQueryI>( this.Functions.CancelServerQuery16 )( this.ObjectAddress, hServerQuery ); 
		}
		
	};
}
