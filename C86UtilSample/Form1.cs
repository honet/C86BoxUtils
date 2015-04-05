using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C86BoxUtil;

namespace C86BoxUtilSample
{
    public partial class Form1 : Form
    {
        IntPtr devHandle = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();

            System.Diagnostics.FileVersionInfo ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text += "  ver." + ver.ProductVersion.ToString();
        }

        private void buttonFindDevice_Click(object sender, EventArgs e)
        {
            List<string> devnodes = C86BoxUtilDelegate.C86BOXGetDevices();
            comboBoxDeviceList.Items.Clear();
            devnodes.ForEach(delegate(string x) { comboBoxDeviceList.Items.Add(x); });
            if (comboBoxDeviceList.Items.Count > 0) { comboBoxDeviceList.SelectedIndex = 0; }
        }

        private void buttonOpenDevice_Click(object sender, EventArgs e)
        {
            if (devHandle != IntPtr.Zero)
                return;

            if (comboBoxDeviceList.SelectedIndex >= 0) {
                devHandle = C86BoxUtilDelegate.C86BOXOpenDevice(comboBoxDeviceList.SelectedItem.ToString());
                comboBoxDeviceList.Enabled = false;

                if (devHandle!=IntPtr.Zero) {
                    textBoxResult.Text = "OpenDevice: success\r\n" + "  devHandle=0x" +String.Format("{0:X}",devHandle);
                } else {
                    textBoxResult.Text = "OpenDevice: failed.";
                }
            }
        }

        private void buttonCloseDevice_Click(object sender, EventArgs e)
        {
            if (devHandle != IntPtr.Zero) {
                C86BoxUtilDelegate.C86BOXCloseDevice(devHandle);
                devHandle = IntPtr.Zero;

                comboBoxDeviceList.Enabled = true;
            }
            textBoxResult.Text = "CloseDevice.";

        }

        private void buttonBusRead_Click(object sender, EventArgs e)
        {
            if (devHandle != IntPtr.Zero) {
                byte slot = byte.Parse(textBoxSlotNo.Text, System.Globalization.NumberStyles.HexNumber);
                UInt32 addr = UInt32.Parse(textBoxBusAddress.Text, System.Globalization.NumberStyles.HexNumber);
                UInt16 data;
                int result = C86BoxUtilDelegate.C86BOXReadBus(devHandle, slot, addr, out data);

                textBoxResult.Text = "ReadBus: result=" + result.ToString() + "   ";
                textBoxResult.Text += String.Format("slot:{0:d}, addr:{1:X} => {2:X}", slot, addr, data);
            }

        }

        private void buttonBusWrite_Click(object sender, EventArgs e)
        {
            if (devHandle != IntPtr.Zero) {
                byte slot = byte.Parse(textBoxSlotNo.Text, System.Globalization.NumberStyles.HexNumber);
                UInt32 addr = UInt32.Parse(textBoxBusAddress.Text, System.Globalization.NumberStyles.HexNumber);
                UInt16 data = UInt16.Parse(textBoxBusData.Text, System.Globalization.NumberStyles.HexNumber);
                int result = C86BoxUtilDelegate.C86BOXWriteBus(devHandle, slot, addr, data);

                textBoxResult.Text = "WriteBus: result=" + result.ToString() + "   ";
                textBoxResult.Text += String.Format("slot:{0:d}, addr:{1:X} <= {2:X}", slot, addr, data);
            }

        }
    }
}
