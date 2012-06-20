// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteam2Bridge001VTable
	{
		public IntPtr SetSteam2Ticket0;
		public IntPtr SetAccountName1;
		public IntPtr SetPassword2;
		public IntPtr SetAccountCreationTime3;
		public IntPtr CreateProcess4;
		public IntPtr GetConnectedUniverse5;
		public IntPtr GetIPCountry6;
		public IntPtr GetNumLicenses7;
		public IntPtr GetLicensePackageID8;
		public IntPtr GetLicenseTimeCreated9;
		public IntPtr GetLicenseTimeNextProcess10;
		public IntPtr GetLicenseMinuteLimit11;
		public IntPtr GetLicenseMinutesUsed12;
		public IntPtr GetLicensePaymentMethod13;
		public IntPtr GetLicenseFlags14;
		public IntPtr GetLicensePurchaseCountryCode15;
		public IntPtr SetOfflineMode16;
		private IntPtr DTorISteam2Bridge00117;
	};
	
	[InteropHelp.InterfaceVersion("STEAM2BRIDGE_INTERFACE_VERSION001")]
	public class ISteam2Bridge001 : InteropHelp.NativeWrapper<ISteam2Bridge001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSteam2TicketBI( IntPtr thisptr, Byte[] pubTicket, Int32 cubTicket );
		public void SetSteam2Ticket( Byte[] pubTicket ) 
		{
			this.GetFunction<NativeSetSteam2TicketBI>( this.Functions.SetSteam2Ticket0 )( this.ObjectAddress, pubTicket, (Int32) pubTicket.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAccountNameS( IntPtr thisptr, string pchAccountName );
		public bool SetAccountName( string pchAccountName ) 
		{
			return this.GetFunction<NativeSetAccountNameS>( this.Functions.SetAccountName1 )( this.ObjectAddress, pchAccountName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetPasswordS( IntPtr thisptr, string pchPassword );
		public bool SetPassword( string pchPassword ) 
		{
			return this.GetFunction<NativeSetPasswordS>( this.Functions.SetPassword2 )( this.ObjectAddress, pchPassword ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAccountCreationTimeU( IntPtr thisptr, UInt32 rt );
		public bool SetAccountCreationTime( UInt32 rt ) 
		{
			return this.GetFunction<NativeSetAccountCreationTimeU>( this.Functions.SetAccountCreationTime3 )( this.ObjectAddress, rt ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCreateProcessBUSSUBSU( IntPtr thisptr, Byte[] lpVACBlob, UInt32 cbBlobSize, string lpApplicationName, StringBuilder lpCommandLine, UInt32 dwCreationFlags, Byte[] lpEnvironment, StringBuilder lpCurrentDirectory, UInt32 nGameID );
		public bool CreateProcess( Byte[] lpVACBlob, string lpApplicationName, StringBuilder lpCommandLine, UInt32 dwCreationFlags, Byte[] lpEnvironment, StringBuilder lpCurrentDirectory, UInt32 nGameID ) 
		{
			return this.GetFunction<NativeCreateProcessBUSSUBSU>( this.Functions.CreateProcess4 )( this.ObjectAddress, lpVACBlob, (UInt32) lpVACBlob.Length, lpApplicationName, lpCommandLine, dwCreationFlags, lpEnvironment, lpCurrentDirectory, nGameID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse( IntPtr thisptr );
		public EUniverse GetConnectedUniverse(  ) 
		{
			return this.GetFunction<NativeGetConnectedUniverse>( this.Functions.GetConnectedUniverse5 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetIPCountry( IntPtr thisptr );
		public string GetIPCountry(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetIPCountry>( this.Functions.GetIPCountry6 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumLicenses( IntPtr thisptr );
		public UInt32 GetNumLicenses(  ) 
		{
			return this.GetFunction<NativeGetNumLicenses>( this.Functions.GetNumLicenses7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicensePackageIDU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicensePackageID( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicensePackageIDU>( this.Functions.GetLicensePackageID8 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeCreatedU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicenseTimeCreated( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTimeCreatedU>( this.Functions.GetLicenseTimeCreated9 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeNextProcessU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicenseTimeNextProcess( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTimeNextProcessU>( this.Functions.GetLicenseTimeNextProcess10 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseMinuteLimitU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseMinuteLimit( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseMinuteLimitU>( this.Functions.GetLicenseMinuteLimit11 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseMinutesUsedU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseMinutesUsed( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseMinutesUsedU>( this.Functions.GetLicenseMinutesUsed12 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPaymentMethod NativeGetLicensePaymentMethodU( IntPtr thisptr, UInt32 nLicenseIndex );
		public EPaymentMethod GetLicensePaymentMethod( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicensePaymentMethodU>( this.Functions.GetLicensePaymentMethod13 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELicenseFlags NativeGetLicenseFlagsU( IntPtr thisptr, UInt32 nLicenseIndex );
		public ELicenseFlags GetLicenseFlags( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseFlagsU>( this.Functions.GetLicenseFlags14 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLicensePurchaseCountryCodeU( IntPtr thisptr, UInt32 nLicenseIndex );
		public string GetLicensePurchaseCountryCode( UInt32 nLicenseIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLicensePurchaseCountryCodeU>( this.Functions.GetLicensePurchaseCountryCode15 )( this.ObjectAddress, nLicenseIndex ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetOfflineModeB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bOffline );
		public bool SetOfflineMode( bool bOffline ) 
		{
			return this.GetFunction<NativeSetOfflineModeB>( this.Functions.SetOfflineMode16 )( this.ObjectAddress, bOffline ); 
		}
		
	};
}
