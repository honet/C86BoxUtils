/***
	C86BoxUtil
	
	Copyright (c) 2015, honet. All rights reserved.
	This software is licensed under the BSD license.

	honet.kk(at)gmail.com
 */

#include "stdafx.h"
#include <setupapi.h>
#include <winusb.h>
#include <initguid.h>
#include <string>
#include <tchar.h>
#include "C86BoxUtil.h"

/*----------------------------------------------------------------------------
	追加ライブラリ
----------------------------------------------------------------------------*/
#pragma comment(lib, "setupapi.lib")
#pragma comment(lib, "winusb.lib")

/*----------------------------------------------------------------------------
	定義いろいろ
----------------------------------------------------------------------------*/

// ----------------------------------------
// デバイスドライバのinf内で定義したGUID
// (WinUSB.sys使用デバイスに対する識別子）
// {b0320d09-0791-4c3f-a741-9ef97c8885d6}
DEFINE_GUID(GUID_DEVINTERFACE_C86BOX_WINUSB_TARGET, 
  0xb0320d09, 0x0791, 0x4c3f, 0xa7, 0x41, 0x9e, 0xf9, 0x7c, 0x88, 0x85, 0xd6);

// VENDOR REQUEST ----------------------------------
#define C86_VENDOR_GET_BOARD_INFO		0x81
// SETUP:
//   bmRequestType: DeviceToHost, vendor, device
//   bRequest     : C86_VENDOR_GET_BOARD_INFO
//   wValue       : ignore
//   wIndex       : ボード番号(0~4)
//   wLength      : sizeof(BOARD_INFO)
// DATA STAGE:
//   BOARD_INFO

#define C86_VENDOR_GET_FW_VER			0x82
// SETUP:
//   bmRequestType: DeviceToHost, vendor, device
//   bRequest     : C86_VENDOR_GET_FW_VER
//   wValue       : ignore
//   wIndex       : ignore
//   wLength      : 4
// DATA STAGE:
//   (uint32_t)verison

#define C86_VENDOR_GET_CONF_BOARD_TYPE		0x13
// SETUP:
//   bmRequestType: DeviceToHost, vendor, device
//   bRequest     : C86_VENDOR_GET_BOARD_INFO
//   wValue       : ignore
//   wIndex       : ボード番号(0~4)
//   wLength      : 4
// DATA STAGE:
//   (uint32_t)board_type

#define C86_VENDOR_SET_CONF_BOARD_TYPE		0x14
// SETUP:
//   bmRequestType: HostToDevice, vendor, device
//   bRequest     : C86_VENDOR_CBUS_RESET
//   wValue       : ignore
//   wIndex       : ボード番号(0~4)
//   wLength      : 4
// DATA STAGE:
//   (uint32_t)board_type

#define C86_VENDOR_SYSTEM_RESET			0x11
// SETUP:
//   bmRequestType: HostToDevice, vendor, device
//   bRequest     : C86_VENDOR_SYSTEM_RESET
//   wValue       : ignore
//   wIndex       : ignore
//   wLength      : 0



/*----------------------------------------------------------------------------
	構造体・変数
----------------------------------------------------------------------------*/

struct C86DEV{
	HANDLE hDev;
	HANDLE hWinUsb;
	std::basic_string<TCHAR> devPath;
	UCHAR inPipeId;
	USHORT inPipeMaxPktSize;
	UCHAR outPipeId;
	USHORT outPipeMaxPktSize;
};

HDEVINFO devinf = INVALID_HANDLE_VALUE;
int findIndex = 0;


/*----------------------------------------------------------------------------
	実装
----------------------------------------------------------------------------*/
static VOID C86BOXFindDeviceClose()
{
	if (devinf!=INVALID_HANDLE_VALUE)
		SetupDiDestroyDeviceInfoList(devinf);

	devinf = INVALID_HANDLE_VALUE;
	findIndex = 0;
}

HANDLE __stdcall C86BOXFindFirstDevice(WCHAR *devnode, UINT nbuf)
{
	C86BOXFindDeviceClose();
	
	devinf = SetupDiGetClassDevsW(
		(LPGUID)&GUID_DEVINTERFACE_C86BOX_WINUSB_TARGET,
		NULL,
		0,
		DIGCF_PRESENT | DIGCF_DEVICEINTERFACE);
	
	if (devinf==INVALID_HANDLE_VALUE)
		return NULL;

	findIndex = 0;

	BOOL ret = C86BOXFindNextDevice(devinf, devnode, nbuf);

	return ret ? devinf : NULL;
}

BOOL __stdcall C86BOXFindNextDevice(HANDLE findHandle, WCHAR *devnode, UINT nbuf)
{
	SP_DEVICE_INTERFACE_DATA spid;
	BOOL ret = FALSE;

	if( devinf==NULL || devinf==INVALID_HANDLE_VALUE )
		return FALSE;

	for (;;){
		ZeroMemory(&spid, sizeof(spid));
		spid.cbSize = sizeof(SP_DEVICE_INTERFACE_DATA);
		if ( !SetupDiEnumDeviceInterfaces(devinf, NULL,
			  (LPGUID) &GUID_DEVINTERFACE_C86BOX_WINUSB_TARGET, findIndex++, &spid) ){
			C86BOXFindDeviceClose();
			break;
		}

		unsigned long sz=0;
		std::basic_string<TCHAR> devpath;

		// 必要なバッファサイズ取得
		SetupDiGetDeviceInterfaceDetailW(devinf, &spid, NULL, 0, &sz, NULL);

		PSP_INTERFACE_DEVICE_DETAIL_DATA dev_det = (PSP_INTERFACE_DEVICE_DETAIL_DATA)(malloc(sz));
		if (dev_det){
			dev_det->cbSize = sizeof(SP_INTERFACE_DEVICE_DETAIL_DATA);

			// デバイスノード取得
			if (SetupDiGetDeviceInterfaceDetailW(devinf, &spid, dev_det, sz, &sz, NULL)){
				wcsncpy_s( devnode, nbuf, dev_det->DevicePath, wcslen(dev_det->DevicePath) );
				ret = TRUE;
			}
			free(dev_det);
			dev_det = NULL;
		}
		
		if (ret)
			break;
	}
	
	return ret;
}

HANDLE __stdcall C86BOXOpenDevice(WCHAR *devnode)
{
	HANDLE hNewDev = CreateFile(
		devnode,
		GENERIC_READ|GENERIC_WRITE,
		0 /*FILE_SHARE_READ|FILE_SHARE_WRITE*/,
		NULL,
		OPEN_EXISTING,
		FILE_FLAG_OVERLAPPED, //FILE_FLAG_NO_BUFFERING,
		NULL);

	if(hNewDev == INVALID_HANDLE_VALUE)
		return NULL;

	HANDLE hNewWinUsb = NULL;
	if (!WinUsb_Initialize(hNewDev, &hNewWinUsb)){
		//DWORD err = GetLastError();
		CloseHandle(hNewDev);
		return NULL;
	}
	
	// エンドポイント情報取得
	USB_INTERFACE_DESCRIPTOR desc;
	if (!WinUsb_QueryInterfaceSettings(hNewWinUsb, 0, &desc)){
		WinUsb_Free(hNewWinUsb);
		CloseHandle(hNewDev);
		return NULL;
	}

	C86DEV *dev = new C86DEV;
	dev->hDev = hNewDev;
	dev->hWinUsb = hNewWinUsb;
	dev->devPath = devnode;
	dev->inPipeId = 0;
	dev->inPipeMaxPktSize = 0;
	dev->outPipeId = 0;
	dev->outPipeMaxPktSize = 0;
	
	for ( int i=0; i<desc.bNumEndpoints; i++ ){
		WINUSB_PIPE_INFORMATION pipeInfo;
		if (WinUsb_QueryPipe(hNewWinUsb, 0, (UCHAR)i, &pipeInfo)){
			if( pipeInfo.PipeType == UsbdPipeTypeBulk &&
				USB_ENDPOINT_DIRECTION_OUT(pipeInfo.PipeId) ){
				dev->outPipeId = pipeInfo.PipeId;
				dev->outPipeMaxPktSize = pipeInfo.MaximumPacketSize;
			}else if ( pipeInfo.PipeType == UsbdPipeTypeBulk &&
				USB_ENDPOINT_DIRECTION_IN(pipeInfo.PipeId) ){
				dev->inPipeId = pipeInfo.PipeId;
				dev->inPipeMaxPktSize = pipeInfo.MaximumPacketSize;
			}
		}
	}

	WinUsb_FlushPipe(dev->hWinUsb, dev->outPipeId);
	WinUsb_FlushPipe(dev->hWinUsb, dev->inPipeId);
	
	// タイムアウト設定
	ULONG timeout = 500; //ms
	::WinUsb_SetPipePolicy( dev->hWinUsb, dev->outPipeId, PIPE_TRANSFER_TIMEOUT, sizeof(ULONG), &timeout );
	::WinUsb_SetPipePolicy( dev->hWinUsb, dev->inPipeId, PIPE_TRANSFER_TIMEOUT, sizeof(ULONG), &timeout );



	return reinterpret_cast<HANDLE>(dev);
}

void __stdcall C86BOXCloseDevice(HANDLE hdev)
{
	C86DEV *dev = reinterpret_cast<C86DEV*>(hdev);
	if (dev->hDev)
		CloseHandle(dev->hDev);
	if (dev->hWinUsb)
		WinUsb_Free(dev->hWinUsb);
	
	delete dev;
}


INT __stdcall C86BOXGetBoardType(HANDLE hdev, uint8_t slot, CBUS_BOARD_TYPE *board_type)
{
	C86DEV *dev = reinterpret_cast<C86DEV*>(hdev);
	
	if (!dev->hDev || !dev->hWinUsb)
		return C86UTIL_ERR_NODEVICE;
	if (4<=slot)
		return C86UTIL_ERR_INVALID_PARAM;
	
	USHORT msg_sz = 24;
	UCHAR *msg = new UCHAR[msg_sz];
	if (!msg) return C86UTIL_ERR_UNKNOWN;
	
	WINUSB_SETUP_PACKET setup;
	setup.RequestType = 0xc0;
	setup.Request = C86_VENDOR_GET_BOARD_INFO;
	setup.Index = slot;
	setup.Value = 0;
	setup.Length = msg_sz;
	
	ULONG ntransferred;
	BOOL retval = ::WinUsb_ControlTransfer( dev->hWinUsb, setup, msg, msg_sz, &ntransferred, NULL );

	if (retval == TRUE && ntransferred == msg_sz){
		*board_type = static_cast<CBUS_BOARD_TYPE>(*reinterpret_cast<uint32_t*>(msg+0));
	}else{
		retval = FALSE;
	}
	
	delete[] msg;
	
	return (retval==TRUE) ? C86UTIL_ERR_NONE : C86UTIL_ERR_UNKNOWN;
}


INT __stdcall C86BOXGetBoardConf(HANDLE hdev, uint8_t slot, CBUS_BOARD_TYPE *board_type)
{
	C86DEV *dev = reinterpret_cast<C86DEV*>(hdev);
	
	if (!dev->hDev || !dev->hWinUsb)
		return C86UTIL_ERR_NODEVICE;
	if (4<=slot)
		return C86UTIL_ERR_INVALID_PARAM;
	
	USHORT msg_sz = 4;
	UCHAR *msg = new UCHAR[msg_sz];
	if (!msg) return C86UTIL_ERR_UNKNOWN;
	
	WINUSB_SETUP_PACKET setup;
	setup.RequestType = 0xc0;
	setup.Request = C86_VENDOR_GET_CONF_BOARD_TYPE;
	setup.Index = slot;
	setup.Value = 0;
	setup.Length = msg_sz;
	
	ULONG ntransferred;
	BOOL retval = ::WinUsb_ControlTransfer( dev->hWinUsb, setup, msg, msg_sz, &ntransferred, NULL );

	if (retval == TRUE && ntransferred == msg_sz){
		*board_type = static_cast<CBUS_BOARD_TYPE>(*reinterpret_cast<uint32_t*>(msg+0));
	}else{
		retval = FALSE;
	}
	
	delete[] msg;
	
	return (retval==TRUE) ? C86UTIL_ERR_NONE : C86UTIL_ERR_UNKNOWN;
}


INT __stdcall C86BOXSetBoardConf(HANDLE hdev, uint8_t slot, CBUS_BOARD_TYPE type)
{
	C86DEV *dev = reinterpret_cast<C86DEV*>(hdev);
	
	if (!dev->hDev || !dev->hWinUsb)
		return C86UTIL_ERR_NODEVICE;
	if (4<=slot)
		return C86UTIL_ERR_INVALID_PARAM;
	
	USHORT msg_sz = 4;
	UCHAR *msg = new UCHAR[msg_sz];
	if (!msg) return C86UTIL_ERR_UNKNOWN;
	*reinterpret_cast<UINT*>(msg) = static_cast<UINT>(type);
	
	WINUSB_SETUP_PACKET setup;
	setup.RequestType = 0x40;
	setup.Request = C86_VENDOR_SET_CONF_BOARD_TYPE;
	setup.Index = slot;
	setup.Value = 0;
	setup.Length = msg_sz;
	
	ULONG ntransferred;
	BOOL retval = ::WinUsb_ControlTransfer( dev->hWinUsb, setup, msg, msg_sz, &ntransferred, NULL );
	if (ntransferred != msg_sz){
		DWORD err = GetLastError();
		retval = FALSE;
	}
	
	delete[] msg;
	
	return (retval==TRUE) ? C86UTIL_ERR_NONE : C86UTIL_ERR_UNKNOWN;
}


INT __stdcall C86BOXWriteBus(HANDLE hdev, uint8_t slot, uint32_t addr, uint16_t data)
{
	C86DEV *dev = reinterpret_cast<C86DEV*>(hdev);

	if (!dev->hDev || !dev->hWinUsb)
		return C86UTIL_ERR_NODEVICE;
	if (4<=slot)
		return C86UTIL_ERR_INVALID_PARAM;

	// build message packet.
	UCHAR packet[64];
	memset( &packet[0], 0, 64 );
	packet[3] = 0xf0; // write address
	packet[2] = (addr>>16)&0xf;
	packet[1] = (addr>>8)&0xff;
	packet[0] = addr&0xff;
	
	packet[7] = 0xf1; // write data
	packet[6] = slot<<4;
	packet[5] = (data>>8)&0xff;
	packet[4] = data&0xff;
	
	DWORD wlen;
	BOOL ret = WinUsb_WritePipe( dev->hWinUsb, dev->outPipeId, (UCHAR*)packet, 8, &wlen, 0);
	if(ret == FALSE || 8 != wlen)
		goto err;
	
	return C86UTIL_ERR_NONE;

err:
	WinUsb_Free(dev->hWinUsb);
	dev->hWinUsb = NULL;
	CloseHandle(dev->hDev);
	dev->hDev = NULL;
	return C86UTIL_ERR_UNKNOWN;
}


INT __stdcall C86BOXReadBus(HANDLE hdev, uint8_t slot, uint32_t addr, uint16_t *data)
{
	C86DEV *dev = reinterpret_cast<C86DEV*>(hdev);

	if (!dev->hDev || !dev->hWinUsb)
		return C86UTIL_ERR_NODEVICE;
	if (4<=slot)
		return C86UTIL_ERR_INVALID_PARAM;

	// build message packet.
	UCHAR packet[64];
	memset( &packet[0], 0, 64 );
	packet[3] = 0xf2; // read request
	packet[2] = (slot<<4) | ((addr>>16)&0xf);
	packet[1] = (addr>>8)&0xff;
	packet[0] = addr&0xff;
	
	DWORD wlen;
	BOOL ret = WinUsb_WritePipe( dev->hWinUsb, dev->outPipeId, (UCHAR*)packet, 4, &wlen, 0);
	if (ret == FALSE || 4 != wlen)
		goto err;

	DWORD rlen;
	//DWORD err = ::GetLastError();
	ret = WinUsb_ReadPipe(dev->hWinUsb, dev->inPipeId, (UCHAR*)packet, 2, &rlen, 0);
	//err = ::GetLastError();
	if (ret == FALSE || 2 != rlen)
		goto err;

	*data = *(uint16_t*)&packet[0];

	return C86UTIL_ERR_NONE;

err:
	WinUsb_Free(dev->hWinUsb);
	dev->hWinUsb = NULL;
	CloseHandle(dev->hDev);
	dev->hDev = NULL;
	return C86UTIL_ERR_UNKNOWN;
}


