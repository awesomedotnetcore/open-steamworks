// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamFriends005VTable
	{
		public IntPtr GetPersonaName0;
		public IntPtr SetPersonaName1;
		public IntPtr GetPersonaState2;
		public IntPtr GetFriendCount3;
		public IntPtr GetFriendByIndex4;
		public IntPtr GetFriendRelationship5;
		public IntPtr GetFriendPersonaState6;
		public IntPtr GetFriendPersonaName7;
		public IntPtr GetFriendAvatar8;
		public IntPtr GetFriendGamePlayed9;
		public IntPtr GetFriendPersonaNameHistory10;
		public IntPtr HasFriend11;
		public IntPtr GetClanCount12;
		public IntPtr GetClanByIndex13;
		public IntPtr GetClanName14;
		public IntPtr GetFriendCountFromSource15;
		public IntPtr GetFriendFromSourceByIndex16;
		public IntPtr IsUserInSource17;
		public IntPtr SetInGameVoiceSpeaking18;
		public IntPtr ActivateGameOverlay19;
		public IntPtr ActivateGameOverlayToUser20;
		public IntPtr ActivateGameOverlayToWebPage21;
		public IntPtr ActivateGameOverlayToStore22;
		public IntPtr SetPlayedWith23;
		private IntPtr DTorISteamFriends00524;
	};
	
	[InteropHelp.InterfaceVersion("SteamFriends005")]
	public class ISteamFriends005 : InteropHelp.NativeWrapper<ISteamFriends005VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetPersonaName( IntPtr thisptr );
		public string GetPersonaName(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetPersonaName>( this.Functions.GetPersonaName0 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPersonaNameS( IntPtr thisptr, string pchPersonaName );
		public void SetPersonaName( string pchPersonaName ) 
		{
			this.GetFunction<NativeSetPersonaNameS>( this.Functions.SetPersonaName1 )( this.ObjectAddress, pchPersonaName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetPersonaState( IntPtr thisptr );
		public EPersonaState GetPersonaState(  ) 
		{
			return this.GetFunction<NativeGetPersonaState>( this.Functions.GetPersonaState2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountE( IntPtr thisptr, EFriendFlags eFriendFlags );
		public Int32 GetFriendCount( EFriendFlags eFriendFlags ) 
		{
			return this.GetFunction<NativeGetFriendCountE>( this.Functions.GetFriendCount3 )( this.ObjectAddress, eFriendFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendByIndexII( IntPtr thisptr, ref UInt64 retarg, Int32 iFriend, Int32 iFriendFlags );
		public CSteamID GetFriendByIndex( Int32 iFriend, Int32 iFriendFlags ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendByIndexII>( this.Functions.GetFriendByIndex4 )( this.ObjectAddress, ref ret, iFriend, iFriendFlags ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EFriendRelationship NativeGetFriendRelationshipC( IntPtr thisptr, UInt64 steamIDFriend );
		public EFriendRelationship GetFriendRelationship( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendRelationshipC>( this.Functions.GetFriendRelationship5 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetFriendPersonaStateC( IntPtr thisptr, UInt64 steamIDFriend );
		public EPersonaState GetFriendPersonaState( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendPersonaStateC>( this.Functions.GetFriendPersonaState6 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetFriendPersonaNameC( IntPtr thisptr, UInt64 steamIDFriend );
		public string GetFriendPersonaName( CSteamID steamIDFriend ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetFriendPersonaNameC>( this.Functions.GetFriendPersonaName7 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendAvatarCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 eAvatarSize );
		public Int32 GetFriendAvatar( CSteamID steamIDFriend, Int32 eAvatarSize ) 
		{
			return this.GetFunction<NativeGetFriendAvatarCI>( this.Functions.GetFriendAvatar8 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), eAvatarSize ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFriendGamePlayedCF( IntPtr thisptr, UInt64 steamIDFriend, ref FriendGameInfo_t pFriendGameInfo );
		public bool GetFriendGamePlayed( CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo ) 
		{
			return this.GetFunction<NativeGetFriendGamePlayedCF>( this.Functions.GetFriendGamePlayed9 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), ref pFriendGameInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetFriendPersonaNameHistoryCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iPersonaName );
		public string GetFriendPersonaNameHistory( CSteamID steamIDFriend, Int32 iPersonaName ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetFriendPersonaNameHistoryCI>( this.Functions.GetFriendPersonaNameHistory10 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iPersonaName ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHasFriendCE( IntPtr thisptr, UInt64 steamIDFriend, EFriendFlags eFriendFlags );
		public bool HasFriend( CSteamID steamIDFriend, EFriendFlags eFriendFlags ) 
		{
			return this.GetFunction<NativeHasFriendCE>( this.Functions.HasFriend11 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), eFriendFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanCount( IntPtr thisptr );
		public Int32 GetClanCount(  ) 
		{
			return this.GetFunction<NativeGetClanCount>( this.Functions.GetClanCount12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iClan );
		public CSteamID GetClanByIndex( Int32 iClan ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanByIndexI>( this.Functions.GetClanByIndex13 )( this.ObjectAddress, ref ret, iClan ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetClanNameC( IntPtr thisptr, UInt64 steamIDClan );
		public string GetClanName( CSteamID steamIDClan ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetClanNameC>( this.Functions.GetClanName14 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountFromSourceC( IntPtr thisptr, UInt64 steamIDSource );
		public Int32 GetFriendCountFromSource( CSteamID steamIDSource ) 
		{
			return this.GetFunction<NativeGetFriendCountFromSourceC>( this.Functions.GetFriendCountFromSource15 )( this.ObjectAddress, steamIDSource.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendFromSourceByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDSource, Int32 iFriend );
		public CSteamID GetFriendFromSourceByIndex( CSteamID steamIDSource, Int32 iFriend ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendFromSourceByIndexCI>( this.Functions.GetFriendFromSourceByIndex16 )( this.ObjectAddress, ref ret, steamIDSource.ConvertToUint64(), iFriend ); return new CSteamID(ret);
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsUserInSourceCC( IntPtr thisptr, UInt64 steamIDUser, UInt64 steamIDSource );
		public bool IsUserInSource( CSteamID steamIDUser, CSteamID steamIDSource ) 
		{
			return this.GetFunction<NativeIsUserInSourceCC>( this.Functions.IsUserInSource17 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), steamIDSource.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetInGameVoiceSpeakingCB( IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking );
		public void SetInGameVoiceSpeaking( CSteamID steamIDUser, bool bSpeaking ) 
		{
			this.GetFunction<NativeSetInGameVoiceSpeakingCB>( this.Functions.SetInGameVoiceSpeaking18 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), bSpeaking ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayS( IntPtr thisptr, string pchDialog );
		public void ActivateGameOverlay( string pchDialog ) 
		{
			this.GetFunction<NativeActivateGameOverlayS>( this.Functions.ActivateGameOverlay19 )( this.ObjectAddress, pchDialog ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToUserSC( IntPtr thisptr, string pchDialog, UInt64 steamID );
		public void ActivateGameOverlayToUser( string pchDialog, CSteamID steamID ) 
		{
			this.GetFunction<NativeActivateGameOverlayToUserSC>( this.Functions.ActivateGameOverlayToUser20 )( this.ObjectAddress, pchDialog, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToWebPageS( IntPtr thisptr, string pchURL );
		public void ActivateGameOverlayToWebPage( string pchURL ) 
		{
			this.GetFunction<NativeActivateGameOverlayToWebPageS>( this.Functions.ActivateGameOverlayToWebPage21 )( this.ObjectAddress, pchURL ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToStoreU( IntPtr thisptr, UInt32 nAppID );
		public void ActivateGameOverlayToStore( UInt32 nAppID ) 
		{
			this.GetFunction<NativeActivateGameOverlayToStoreU>( this.Functions.ActivateGameOverlayToStore22 )( this.ObjectAddress, nAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPlayedWithC( IntPtr thisptr, UInt64 steamIDUserPlayedWith );
		public void SetPlayedWith( CSteamID steamIDUserPlayedWith ) 
		{
			this.GetFunction<NativeSetPlayedWithC>( this.Functions.SetPlayedWith23 )( this.ObjectAddress, steamIDUserPlayedWith.ConvertToUint64() ); 
		}
		
	};
}
