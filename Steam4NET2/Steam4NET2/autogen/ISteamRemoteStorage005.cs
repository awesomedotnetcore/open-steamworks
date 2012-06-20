// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamRemoteStorage005VTable
	{
		public IntPtr FileWrite0;
		public IntPtr FileRead1;
		public IntPtr FileForget2;
		public IntPtr FileDelete3;
		public IntPtr FileShare4;
		public IntPtr SetSyncPlatforms5;
		public IntPtr FileExists6;
		public IntPtr FilePersisted7;
		public IntPtr GetFileSize8;
		public IntPtr GetFileTimestamp9;
		public IntPtr GetSyncPlatforms10;
		public IntPtr GetFileCount11;
		public IntPtr GetFileNameAndSize12;
		public IntPtr GetQuota13;
		public IntPtr IsCloudEnabledForAccount14;
		public IntPtr IsCloudEnabledForApp15;
		public IntPtr SetCloudEnabledForApp16;
		public IntPtr UGCDownload17;
		public IntPtr GetUGCDetails18;
		public IntPtr UGCRead19;
		public IntPtr GetCachedUGCCount20;
		public IntPtr GetCachedUGCHandle21;
		public IntPtr PublishFile22;
		public IntPtr PublishWorkshopFile23;
		public IntPtr UpdatePublishedFile24;
		public IntPtr GetPublishedFileDetails25;
		public IntPtr DeletePublishedFile26;
		public IntPtr EnumerateUserPublishedFiles27;
		public IntPtr SubscribePublishedFile28;
		public IntPtr EnumerateUserSubscribedFiles29;
		public IntPtr UnsubscribePublishedFile30;
		private IntPtr DTorISteamRemoteStorage00531;
	};
	
	[InteropHelp.InterfaceVersion("STEAMREMOTESTORAGE_INTERFACE_VERSION005")]
	public class ISteamRemoteStorage005 : InteropHelp.NativeWrapper<ISteamRemoteStorage005VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileWriteSBI( IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubData );
		public bool FileWrite( string pchFile, Byte[] pvData ) 
		{
			return this.GetFunction<NativeFileWriteSBI>( this.Functions.FileWrite0 )( this.ObjectAddress, pchFile, pvData, (Int32) pvData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeFileReadSBI( IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubDataToRead );
		public Int32 FileRead( string pchFile, Byte[] pvData ) 
		{
			return this.GetFunction<NativeFileReadSBI>( this.Functions.FileRead1 )( this.ObjectAddress, pchFile, pvData, (Int32) pvData.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileForgetS( IntPtr thisptr, string pchFile );
		public bool FileForget( string pchFile ) 
		{
			return this.GetFunction<NativeFileForgetS>( this.Functions.FileForget2 )( this.ObjectAddress, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileDeleteS( IntPtr thisptr, string pchFile );
		public bool FileDelete( string pchFile ) 
		{
			return this.GetFunction<NativeFileDeleteS>( this.Functions.FileDelete3 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFileShareS( IntPtr thisptr, string pchFile );
		public UInt64 FileShare( string pchFile ) 
		{
			return this.GetFunction<NativeFileShareS>( this.Functions.FileShare4 )( this.ObjectAddress, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetSyncPlatformsSE( IntPtr thisptr, string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform );
		public bool SetSyncPlatforms( string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform ) 
		{
			return this.GetFunction<NativeSetSyncPlatformsSE>( this.Functions.SetSyncPlatforms5 )( this.ObjectAddress, pchFile, eRemoteStoragePlatform ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileExistsS( IntPtr thisptr, string pchFile );
		public bool FileExists( string pchFile ) 
		{
			return this.GetFunction<NativeFileExistsS>( this.Functions.FileExists6 )( this.ObjectAddress, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFilePersistedS( IntPtr thisptr, string pchFile );
		public bool FilePersisted( string pchFile ) 
		{
			return this.GetFunction<NativeFilePersistedS>( this.Functions.FilePersisted7 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileSizeS( IntPtr thisptr, string pchFile );
		public Int32 GetFileSize( string pchFile ) 
		{
			return this.GetFunction<NativeGetFileSizeS>( this.Functions.GetFileSize8 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int64 NativeGetFileTimestampS( IntPtr thisptr, string pchFile );
		public Int64 GetFileTimestamp( string pchFile ) 
		{
			return this.GetFunction<NativeGetFileTimestampS>( this.Functions.GetFileTimestamp9 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ERemoteStoragePlatform NativeGetSyncPlatformsS( IntPtr thisptr, string pchFile );
		public ERemoteStoragePlatform GetSyncPlatforms( string pchFile ) 
		{
			return this.GetFunction<NativeGetSyncPlatformsS>( this.Functions.GetSyncPlatforms10 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileCount( IntPtr thisptr );
		public Int32 GetFileCount(  ) 
		{
			return this.GetFunction<NativeGetFileCount>( this.Functions.GetFileCount11 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetFileNameAndSizeII( IntPtr thisptr, Int32 iFile, ref Int32 pnFileSizeInBytes );
		public string GetFileNameAndSize( Int32 iFile, ref Int32 pnFileSizeInBytes ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetFileNameAndSizeII>( this.Functions.GetFileNameAndSize12 )( this.ObjectAddress, iFile, ref pnFileSizeInBytes ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQuotaII( IntPtr thisptr, ref Int32 pnTotalBytes, ref Int32 puAvailableBytes );
		public bool GetQuota( ref Int32 pnTotalBytes, ref Int32 puAvailableBytes ) 
		{
			return this.GetFunction<NativeGetQuotaII>( this.Functions.GetQuota13 )( this.ObjectAddress, ref pnTotalBytes, ref puAvailableBytes ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForAccount( IntPtr thisptr );
		public bool IsCloudEnabledForAccount(  ) 
		{
			return this.GetFunction<NativeIsCloudEnabledForAccount>( this.Functions.IsCloudEnabledForAccount14 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForApp( IntPtr thisptr );
		public bool IsCloudEnabledForApp(  ) 
		{
			return this.GetFunction<NativeIsCloudEnabledForApp>( this.Functions.IsCloudEnabledForApp15 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCloudEnabledForAppB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bEnabled );
		public void SetCloudEnabledForApp( bool bEnabled ) 
		{
			this.GetFunction<NativeSetCloudEnabledForAppB>( this.Functions.SetCloudEnabledForApp16 )( this.ObjectAddress, bEnabled ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUGCDownloadU( IntPtr thisptr, UInt64 hContent );
		public UInt64 UGCDownload( UInt64 hContent ) 
		{
			return this.GetFunction<NativeUGCDownloadU>( this.Functions.UGCDownload17 )( this.ObjectAddress, hContent ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUGCDetailsUUSIC( IntPtr thisptr, UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref UInt64 pSteamIDOwner );
		public bool GetUGCDetails( UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref CSteamID pSteamIDOwner ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetUGCDetailsUUSIC>( this.Functions.GetUGCDetails18 )( this.ObjectAddress, hContent, ref pnAppID, ppchName, ref pnFileSizeInBytes, ref s0 ); pSteamIDOwner = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeUGCReadUBI( IntPtr thisptr, UInt64 hContent, Byte[] pvData, Int32 cubDataToRead );
		public Int32 UGCRead( UInt64 hContent, Byte[] pvData ) 
		{
			return this.GetFunction<NativeUGCReadUBI>( this.Functions.UGCRead19 )( this.ObjectAddress, hContent, pvData, (Int32) pvData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCachedUGCCount( IntPtr thisptr );
		public Int32 GetCachedUGCCount(  ) 
		{
			return this.GetFunction<NativeGetCachedUGCCount>( this.Functions.GetCachedUGCCount20 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetCachedUGCHandleI( IntPtr thisptr, Int32 iCachedContent );
		public UInt64 GetCachedUGCHandle( Int32 iCachedContent ) 
		{
			return this.GetFunction<NativeGetCachedUGCHandleI>( this.Functions.GetCachedUGCHandle21 )( this.ObjectAddress, iCachedContent ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativePublishFileSSUSSES( IntPtr thisptr, string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags );
		public UInt64 PublishFile( string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags ) 
		{
			return this.GetFunction<NativePublishFileSSUSSES>( this.Functions.PublishFile22 )( this.ObjectAddress, pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, ref pTags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativePublishWorkshopFileSSUSSS( IntPtr thisptr, string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ref SteamParamStringArray_t pTags );
		public UInt64 PublishWorkshopFile( string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ref SteamParamStringArray_t pTags ) 
		{
			return this.GetFunction<NativePublishWorkshopFileSSUSSS>( this.Functions.PublishWorkshopFile23 )( this.ObjectAddress, pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, ref pTags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUpdatePublishedFileR( IntPtr thisptr, RemoteStorageUpdatePublishedFileRequest_t updatePublishedFileRequest );
		public UInt64 UpdatePublishedFile( RemoteStorageUpdatePublishedFileRequest_t updatePublishedFileRequest ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileR>( this.Functions.UpdatePublishedFile24 )( this.ObjectAddress, updatePublishedFileRequest ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetPublishedFileDetailsU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 GetPublishedFileDetails( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeGetPublishedFileDetailsU>( this.Functions.GetPublishedFileDetails25 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDeletePublishedFileU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 DeletePublishedFile( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeDeletePublishedFileU>( this.Functions.DeletePublishedFile26 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserPublishedFilesU( IntPtr thisptr, UInt32 unStartIndex );
		public UInt64 EnumerateUserPublishedFiles( UInt32 unStartIndex ) 
		{
			return this.GetFunction<NativeEnumerateUserPublishedFilesU>( this.Functions.EnumerateUserPublishedFiles27 )( this.ObjectAddress, unStartIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSubscribePublishedFileU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 SubscribePublishedFile( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeSubscribePublishedFileU>( this.Functions.SubscribePublishedFile28 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserSubscribedFilesU( IntPtr thisptr, UInt32 unStartIndex );
		public UInt64 EnumerateUserSubscribedFiles( UInt32 unStartIndex ) 
		{
			return this.GetFunction<NativeEnumerateUserSubscribedFilesU>( this.Functions.EnumerateUserSubscribedFiles29 )( this.ObjectAddress, unStartIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUnsubscribePublishedFileU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 UnsubscribePublishedFile( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeUnsubscribePublishedFileU>( this.Functions.UnsubscribePublishedFile30 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
	};
}
