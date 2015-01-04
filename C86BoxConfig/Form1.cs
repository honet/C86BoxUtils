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

namespace C86BoxConfig
{
    public partial class Form1 : Form, IDisposable
    {
        IntPtr hdev = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();
        }


        void IDisposable.Dispose()
        {
            if(hdev!=IntPtr.Zero)
                C86BoxUtilDelegate.C86BOXCloseDevice(hdev);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BoardTypeDef.list.ForEach(delegate(BoardTypeDef.BoardInfo info) {
                comboBoxBoardTypeA.Items.Add(info.name);
                comboBoxBoardTypeB.Items.Add(info.name);
            });

            System.Diagnostics.FileVersionInfo ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text += "  ver." + ver.ProductVersion.ToString();

            List<string> devnodes = C86BoxUtilDelegate.C86BOXGetDevices();
            if (devnodes.Count > 0) {
                hdev = C86BoxUtilDelegate.C86BOXOpenDevice(devnodes[0]);
            } else {
                MessageBox.Show("C86BOXが接続されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (hdev != IntPtr.Zero) {
                UInt32 btype;
                C86BoxUtilDelegate.C86BOXGetBoardConf(hdev, 0, out btype);
                comboBoxBoardTypeA.SelectedIndex = BoardTypeDef.FindIndexByID(btype);

                C86BoxUtilDelegate.C86BOXGetBoardConf(hdev, 1, out btype);
                comboBoxBoardTypeB.SelectedIndex = BoardTypeDef.FindIndexByID(btype);
            }
        }

        private void buttonWriteConfig_Click(object sender, EventArgs e)
        {
            int aindex;
            UInt32 btype;

            aindex = comboBoxBoardTypeA.SelectedIndex;
            btype = BoardTypeDef.Get(aindex).id;
            int ret = C86BoxUtilDelegate.C86BOXSetBoardConf(hdev, 0, btype);
            System.Diagnostics.Debug.WriteLine(ret);

            aindex = comboBoxBoardTypeB.SelectedIndex;
            btype = BoardTypeDef.Get(aindex).id;
            int ret2 = C86BoxUtilDelegate.C86BOXSetBoardConf(hdev, 1, btype);
            System.Diagnostics.Debug.WriteLine(ret2);

            MessageBox.Show("設定を完了しました。\r\n本アプリケーションを終了し、C86BOXの電源を入れなおしてください。", "設定完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxBoardTypeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aindex = comboBoxBoardTypeA.SelectedIndex;
            pictureBoxManualA.Image = (Image)Properties.Resources.ResourceManager.GetObject(BoardTypeDef.Get(aindex).resname);
        }

        private void comboBoxBoardTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aindex = comboBoxBoardTypeB.SelectedIndex;
            pictureBoxManualB.Image = (Image)Properties.Resources.ResourceManager.GetObject(BoardTypeDef.Get(aindex).resname);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
