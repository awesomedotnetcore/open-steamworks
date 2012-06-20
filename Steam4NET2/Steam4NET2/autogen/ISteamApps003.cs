// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamApps003VTable
	{
		public IntPtr BIsSubscribed0;
		public IntPtr BIsLowViolence1;
		public IntPtr BIsCybercafe2;
		public IntPtr BIsVACBanned3;
		public IntPtr GetCurrentGameLanguage4;
		public IntPtr GetAvailableGameLanguages5;
		public IntPtr BIsSubscribedApp6;
		public IntPtr BIsDlcInstalled7;
		private IntPtr DTorISteamApps0038;
	};
	
	[InteropHelp.InterfaceVersion("STEAMAPPS_INTERFACE_VERSION003")]
	public class ISteamApps003 : InteropHelp.NativeWrapper<ISteamApps003VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsSubscribed( IntPtr thisptr );
		public bool BIsSubscribed(  ) 
		{
			return this.GetFunction<NativeBIsSubscribed>( this.Functions.BIsSubscribed0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsLowViolence( IntPtr thisptr );
		public bool BIsLowViolence(  ) 
		{
			return this.GetFunction<NativeBIsLowViolence>( this.Functions.BIsLowViolence1 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsCybercafe( IntPtr thisptr );
		public bool BIsCybercafe(  ) 
		{
			return this.GetFunction<NativeBIsCybercafe>( this.Functions.BIsCybercafe2 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsVACBanned( IntPtr thisptr );
		public bool BIsVACBanned(  ) 
		{
			return this.GetFunction<NativeBIsVACBanned>( this.Functions.BIsVACBanned3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetCurrentGameLanguage( IntPtr thisptr );
		public string GetCurrentGameLanguage(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetCurrentGameLanguage>( this.Functions.GetCurrentGameLanguage4 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetAvailableGameLanguages( IntPtr thisptr );
		public string GetAvailableGameLanguages(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetAvailableGameLanguages>( this.Functions.GetAvailableGameLanguages5 )( this.ObjectAddress ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsSubscribedAppU( IntPtr thisptr, UInt32 nAppID );
		public bool BIsSubscribedApp( UInt32 nAppID ) 
		{
			return this.GetFunction<NativeBIsSubscribedAppU>( this.Functions.BIsSubscribedApp6 )( this.ObjectAddress, nAppID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsDlcInstalledU( IntPtr thisptr, UInt32 nAppID );
		public bool BIsDlcInstalled( UInt32 nAppID ) 
		{
			return this.GetFunction<NativeBIsDlcInstalledU>( this.Functions.BIsDlcInstalled7 )( this.ObjectAddress, nAppID ); 
		}
		
	};
}
