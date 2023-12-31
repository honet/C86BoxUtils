/***
	C86BoxConfig
	
	Copyright (c) 2015, honet. All rights reserved.
	This software is licensed under the BSD license.

	honet.kk(at)gmail.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace C86BoxUtil
{
    class C86BoxUtilDelegate
    {
        [DllImport("C86BoxUtil.dll", CharSet=CharSet.Unicode)]
        private static extern IntPtr C86BOXFindFirstDevice(StringBuilder devnode, uint nsize);

        public static IntPtr C86BOXFindFirstDevice(out string devnode)
        {
            StringBuilder buf = new StringBuilder(1024);
            IntPtr handle = C86BOXFindFirstDevice(buf, (uint)(buf.Capacity));
            devnode = buf.ToString();
            return handle;
        }
        
        [DllImport("C86BoxUtil.dll", CharSet=CharSet.Unicode)]
        private static extern bool C86BOXFindNextDevice(IntPtr findHandle, StringBuilder devnode, uint nsize);

        public static bool C86BOXFindNextDevice(IntPtr findHandle, out string devnode)
        {
            StringBuilder buf = new StringBuilder(1024);
            bool ret = C86BOXFindNextDevice(findHandle, buf, (uint)(buf.Capacity));
            devnode = buf.ToString();
            return ret;
        }

        public static List<string> C86BOXGetDevices()
        {
            List<string> devnodes = new List<string>();
            string devnode;
            IntPtr handle = C86BOXFindFirstDevice(out devnode);
            if (handle == IntPtr.Zero)
                return devnodes;

            devnodes.Add(devnode);

            bool ret;
            do {
                ret = C86BOXFindNextDevice(handle, out devnode);
                if (ret) devnodes.Add(devnode);
            } while (ret);

            return devnodes;
        }

        [DllImport("C86BoxUtil.dll", CharSet=CharSet.Unicode)]
        public static extern IntPtr C86BOXOpenDevice(string devnode);
        
        [DllImport("C86BoxUtil.dll")]
        public static extern void C86BOXCloseDevice(IntPtr hdev);


        [DllImport("C86BoxUtil.dll")]
        public static extern int C86BOXGetBoardType(IntPtr dev,  byte slot, out UInt32 board_type);

        [DllImport("C86BoxUtil.dll")]
        public static extern int C86BOXGetBoardConf(IntPtr dev, byte slot, out UInt32 board_type);

        [DllImport("C86BoxUtil.dll")]
        public static extern int C86BOXSetBoardConf(IntPtr dev, byte slot, UInt32 type);

        [DllImport("C86BoxUtil.dll")]
        public static extern int C86BOXWriteBus(IntPtr dev, byte slot, UInt32 addr, UInt16 data);

        [DllImport("C86BoxUtil.dll")]
        public static extern int C86BOXReadBus(IntPtr dev, byte slot, UInt32 addr, out UInt16 data);

    }
}
