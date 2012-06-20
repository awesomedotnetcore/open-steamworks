// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserStats006VTable
	{
		public IntPtr RequestCurrentStats0;
		public IntPtr GetStat1;
		public IntPtr GetStat2;
		public IntPtr SetStat3;
		public IntPtr SetStat4;
		public IntPtr UpdateAvgRateStat5;
		public IntPtr GetAchievement6;
		public IntPtr SetAchievement7;
		public IntPtr ClearAchievement8;
		public IntPtr StoreStats9;
		public IntPtr GetAchievementIcon10;
		public IntPtr GetAchievementDisplayAttribute11;
		public IntPtr IndicateAchievementProgress12;
		public IntPtr RequestUserStats13;
		public IntPtr GetUserStat14;
		public IntPtr GetUserStat15;
		public IntPtr GetUserAchievement16;
		public IntPtr ResetAllStats17;
		public IntPtr FindOrCreateLeaderboard18;
		public IntPtr FindLeaderboard19;
		public IntPtr GetLeaderboardName20;
		public IntPtr GetLeaderboardEntryCount21;
		public IntPtr GetLeaderboardSortMethod22;
		public IntPtr GetLeaderboardDisplayType23;
		public IntPtr DownloadLeaderboardEntries24;
		public IntPtr GetDownloadedLeaderboardEntry25;
		public IntPtr UploadLeaderboardScore26;
		public IntPtr GetNumberOfCurrentPlayers27;
		private IntPtr DTorISteamUserStats00628;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUSERSTATS_INTERFACE_VERSION006")]
	public class ISteamUserStats006 : InteropHelp.NativeWrapper<ISteamUserStats006VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestCurrentStats( IntPtr thisptr );
		public bool RequestCurrentStats(  ) 
		{
			return this.GetFunction<NativeRequestCurrentStats>( this.Functions.RequestCurrentStats0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatSF( IntPtr thisptr, string pchName, ref float pData );
		public bool GetStat( string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetStatSF>( this.Functions.GetStat1 )( this.ObjectAddress, pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatSI( IntPtr thisptr, string pchName, ref Int32 pData );
		public bool GetStat( string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetStatSI>( this.Functions.GetStat2 )( this.ObjectAddress, pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatSF( IntPtr thisptr, string pchName, float fData );
		public bool SetStat( string pchName, float fData ) 
		{
			return this.GetFunction<NativeSetStatSF>( this.Functions.SetStat3 )( this.ObjectAddress, pchName, fData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatSI( IntPtr thisptr, string pchName, Int32 nData );
		public bool SetStat( string pchName, Int32 nData ) 
		{
			return this.GetFunction<NativeSetStatSI>( this.Functions.SetStat4 )( this.ObjectAddress, pchName, nData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateAvgRateStatSFD( IntPtr thisptr, string pchName, float flCountThisSession, double dSessionLength );
		public bool UpdateAvgRateStat( string pchName, float flCountThisSession, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateAvgRateStatSFD>( this.Functions.UpdateAvgRateStat5 )( this.ObjectAddress, pchName, flCountThisSession, dSessionLength ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementSB( IntPtr thisptr, string pchName, ref bool pbAchieved );
		public bool GetAchievement( string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetAchievementSB>( this.Functions.GetAchievement6 )( this.ObjectAddress, pchName, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAchievementS( IntPtr thisptr, string pchName );
		public bool SetAchievement( string pchName ) 
		{
			return this.GetFunction<NativeSetAchievementS>( this.Functions.SetAchievement7 )( this.ObjectAddress, pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearAchievementS( IntPtr thisptr, string pchName );
		public bool ClearAchievement( string pchName ) 
		{
			return this.GetFunction<NativeClearAchievementS>( this.Functions.ClearAchievement8 )( this.ObjectAddress, pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStoreStats( IntPtr thisptr );
		public bool StoreStats(  ) 
		{
			return this.GetFunction<NativeStoreStats>( this.Functions.StoreStats9 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAchievementIconS( IntPtr thisptr, string pchName );
		public Int32 GetAchievementIcon( string pchName ) 
		{
			return this.GetFunction<NativeGetAchievementIconS>( this.Functions.GetAchievementIcon10 )( this.ObjectAddress, pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetAchievementDisplayAttributeSS( IntPtr thisptr, string pchName, string pchKey );
		public string GetAchievementDisplayAttribute( string pchName, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetAchievementDisplayAttributeSS>( this.Functions.GetAchievementDisplayAttribute11 )( this.ObjectAddress, pchName, pchKey ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIndicateAchievementProgressSUU( IntPtr thisptr, string pchName, UInt32 nCurProgress, UInt32 nMaxProgress );
		public bool IndicateAchievementProgress( string pchName, UInt32 nCurProgress, UInt32 nMaxProgress ) 
		{
			return this.GetFunction<NativeIndicateAchievementProgressSUU>( this.Functions.IndicateAchievementProgress12 )( this.ObjectAddress, pchName, nCurProgress, nMaxProgress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsC( IntPtr thisptr, UInt64 steamIDUser );
		public UInt64 RequestUserStats( CSteamID steamIDUser ) 
		{
			return this.GetFunction<NativeRequestUserStatsC>( this.Functions.RequestUserStats13 )( this.ObjectAddress, steamIDUser.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSF( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref float pData );
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSF>( this.Functions.GetUserStat14 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSI( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref Int32 pData );
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSI>( this.Functions.GetUserStat15 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCSB( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved );
		public bool GetUserAchievement( CSteamID steamIDUser, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetUserAchievementCSB>( this.Functions.GetUserAchievement16 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeResetAllStatsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo );
		public bool ResetAllStats( bool bAchievementsToo ) 
		{
			return this.GetFunction<NativeResetAllStatsB>( this.Functions.ResetAllStats17 )( this.ObjectAddress, bAchievementsToo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindOrCreateLeaderboardSEE( IntPtr thisptr, string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType );
		public UInt64 FindOrCreateLeaderboard( string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType ) 
		{
			return this.GetFunction<NativeFindOrCreateLeaderboardSEE>( this.Functions.FindOrCreateLeaderboard18 )( this.ObjectAddress, pchLeaderboardName, eLeaderboardSortMethod, eLeaderboardDisplayType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindLeaderboardS( IntPtr thisptr, string pchLeaderboardName );
		public UInt64 FindLeaderboard( string pchLeaderboardName ) 
		{
			return this.GetFunction<NativeFindLeaderboardS>( this.Functions.FindLeaderboard19 )( this.ObjectAddress, pchLeaderboardName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLeaderboardNameU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public string GetLeaderboardName( UInt64 hSteamLeaderboard ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLeaderboardNameU>( this.Functions.GetLeaderboardName20 )( this.ObjectAddress, hSteamLeaderboard ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLeaderboardEntryCountU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public Int32 GetLeaderboardEntryCount( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardEntryCountU>( this.Functions.GetLeaderboardEntryCount21 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardSortMethod NativeGetLeaderboardSortMethodU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardSortMethod GetLeaderboardSortMethod( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardSortMethodU>( this.Functions.GetLeaderboardSortMethod22 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardDisplayType NativeGetLeaderboardDisplayTypeU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardDisplayType GetLeaderboardDisplayType( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardDisplayTypeU>( this.Functions.GetLeaderboardDisplayType23 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesUEII( IntPtr thisptr, UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd );
		public UInt64 DownloadLeaderboardEntries( UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd ) 
		{
			return this.GetFunction<NativeDownloadLeaderboardEntriesUEII>( this.Functions.DownloadLeaderboardEntries24 )( this.ObjectAddress, hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetDownloadedLeaderboardEntryUILII( IntPtr thisptr, UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry001_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax );
		public bool GetDownloadedLeaderboardEntry( UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry001_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax ) 
		{
			return this.GetFunction<NativeGetDownloadedLeaderboardEntryUILII>( this.Functions.GetDownloadedLeaderboardEntry25 )( this.ObjectAddress, hSteamLeaderboardEntries, index, ref pLeaderboardEntry, ref pDetails, cDetailsMax ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUploadLeaderboardScoreUEIII( IntPtr thisptr, UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount );
		public UInt64 UploadLeaderboardScore( UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount ) 
		{
			return this.GetFunction<NativeUploadLeaderboardScoreUEIII>( this.Functions.UploadLeaderboardScore26 )( this.ObjectAddress, hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, ref pScoreDetails, cScoreDetailsCount ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetNumberOfCurrentPlayers( IntPtr thisptr );
		public UInt64 GetNumberOfCurrentPlayers(  ) 
		{
			return this.GetFunction<NativeGetNumberOfCurrentPlayers>( this.Functions.GetNumberOfCurrentPlayers27 )( this.ObjectAddress ); 
		}
		
	};
}
