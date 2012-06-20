// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUtils002VTable
	{
		public IntPtr GetSecondsSinceAppActive0;
		public IntPtr GetSecondsSinceComputerActive1;
		public IntPtr GetConnectedUniverse2;
		public IntPtr GetServerRealTime3;
		public IntPtr GetIPCountry4;
		public IntPtr GetImageSize5;
		public IntPtr GetImageRGBA6;
		public IntPtr GetCSERIPPort7;
		public IntPtr GetCurrentBatteryPower8;
		private IntPtr DTorISteamUtils0029;
	};
	
	[InteropHelp.InterfaceVersion("SteamUtils002")]
	public class ISteamUtils002 : InteropHelp.NativeWrapper<ISteamUtils002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceAppActive( IntPtr thisptr );
		public UInt32 GetSecondsSinceAppActive(  ) 
		{
			return this.GetFunction<NativeGetSecondsSinceAppActive>( this.Functions.GetSecondsSinceAppActive0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceComputerActive( IntPtr thisptr );
		public UInt32 GetSecondsSinceComputerActive(  ) 
		{
			return this.GetFunction<NativeGetSecondsSinceComputerActive>( this.Functions.GetSecondsSinceComputerActive1 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse( IntPtr thisptr );
		public EUniverse GetConnectedUniverse(  ) 
		{
			return this.GetFunction<NativeGetConnectedUniverse>( this.Functions.GetConnectedUniverse2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetServerRealTime( IntPtr thisptr );
		public UInt32 GetServerRealTime(  ) 
		{
			return this.GetFunction<NativeGetServerRealTime>( this.Functions.GetServerRealTime3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetIPCountry( IntPtr thisptr );
		public string GetIPCountry(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetIPCountry>( this.Functions.GetIPCountry4 )( this.ObjectAddress ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageSizeIUU( IntPtr thisptr, Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight );
		public bool GetImageSize( Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight ) 
		{
			return this.GetFunction<NativeGetImageSizeIUU>( this.Functions.GetImageSize5 )( this.ObjectAddress, iImage, ref pnWidth, ref pnHeight ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageRGBAIBI( IntPtr thisptr, Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize );
		public bool GetImageRGBA( Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize ) 
		{
			return this.GetFunction<NativeGetImageRGBAIBI>( this.Functions.GetImageRGBA6 )( this.ObjectAddress, iImage, pubDest, nDestBufferSize ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCSERIPPortUU( IntPtr thisptr, ref UInt32 unIP, ref UInt16 usPort );
		public bool GetCSERIPPort( ref UInt32 unIP, ref UInt16 usPort ) 
		{
			return this.GetFunction<NativeGetCSERIPPortUU>( this.Functions.GetCSERIPPort7 )( this.ObjectAddress, ref unIP, ref usPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Byte NativeGetCurrentBatteryPower( IntPtr thisptr );
		public Byte GetCurrentBatteryPower(  ) 
		{
			return this.GetFunction<NativeGetCurrentBatteryPower>( this.Functions.GetCurrentBatteryPower8 )( this.ObjectAddress ); 
		}
		
	};
}
