/***
	C86BoxUtil
	
	Copyright (c) 2015, honet. All rights reserved.
	This software is licensed under the BSD license.

	honet.kk(at)gmail.com
 */

#pragma once

#include <windows.h>
#include <stdint.h>
#include "cbus_boardtype.h"

#define C86UTIL_ERR_NONE					0
#define C86UTIL_ERR_UNKNOWN					-1
#define C86UTIL_ERR_INVALID_PARAM			-2
#define C86UTIL_ERR_UNSUPPORTED				-3
#define C86UTIL_ERR_NODEVICE				-1000
#define C86UTIL_ERR_NOT_IMPLEMENTED			-9999

HANDLE __stdcall C86BOXFindFirstDevice(WCHAR *devnode, UINT bufsize);
BOOL __stdcall C86BOXFindNextDevice(HANDLE findHandle, WCHAR *devnode, UINT bufsize);

HANDLE __stdcall C86BOXOpenDevice(WCHAR *devnode);
void __stdcall C86BOXCloseDevice(HANDLE hdev);

INT __stdcall C86BOXGetBoardType(HANDLE dev, uint8_t slot, CBUS_BOARD_TYPE *board_type);
INT __stdcall C86BOXGetBoardConf(HANDLE dev, uint8_t slot, CBUS_BOARD_TYPE *board_type);
INT __stdcall C86BOXSetBoardConf(HANDLE dev, uint8_t slot, CBUS_BOARD_TYPE type);

INT __stdcall C86BOXWriteBus(HANDLE dev, uint8_t slot, uint32_t addr, uint16_t data);
INT __stdcall C86BOXReadBus(HANDLE dev, uint8_t slot, uint32_t addr, uint16_t *data);

