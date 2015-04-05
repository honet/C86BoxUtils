namespace C86BoxUtilSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFindDevice = new System.Windows.Forms.Button();
            this.textBoxSlotNo = new System.Windows.Forms.TextBox();
            this.textBoxBusAddress = new System.Windows.Forms.TextBox();
            this.textBoxBusData = new System.Windows.Forms.TextBox();
            this.comboBoxDeviceList = new System.Windows.Forms.ComboBox();
            this.buttonOpenDevice = new System.Windows.Forms.Button();
            this.buttonBusWrite = new System.Windows.Forms.Button();
            this.buttonBusRead = new System.Windows.Forms.Button();
            this.buttonCloseDevice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindDevice
            // 
            this.buttonFindDevice.Location = new System.Drawing.Point(263, 49);
            this.buttonFindDevice.Name = "buttonFindDevice";
            this.buttonFindDevice.Size = new System.Drawing.Size(88, 23);
            this.buttonFindDevice.TabIndex = 0;
            this.buttonFindDevice.Text = "FindDevice";
            this.buttonFindDevice.UseVisualStyleBackColor = true;
            this.buttonFindDevice.Click += new System.EventHandler(this.buttonFindDevice_Click);
            // 
            // textBoxSlotNo
            // 
            this.textBoxSlotNo.Location = new System.Drawing.Point(55, 29);
            this.textBoxSlotNo.Name = "textBoxSlotNo";
            this.textBoxSlotNo.Size = new System.Drawing.Size(44, 19);
            this.textBoxSlotNo.TabIndex = 1;
            this.textBoxSlotNo.Text = "0";
            // 
            // textBoxBusAddress
            // 
            this.textBoxBusAddress.Location = new System.Drawing.Point(172, 29);
            this.textBoxBusAddress.Name = "textBoxBusAddress";
            this.textBoxBusAddress.Size = new System.Drawing.Size(64, 19);
            this.textBoxBusAddress.TabIndex = 2;
            this.textBoxBusAddress.Text = "a460";
            // 
            // textBoxBusData
            // 
            this.textBoxBusData.Location = new System.Drawing.Point(283, 29);
            this.textBoxBusData.Name = "textBoxBusData";
            this.textBoxBusData.Size = new System.Drawing.Size(62, 19);
            this.textBoxBusData.TabIndex = 3;
            this.textBoxBusData.Text = "0";
            // 
            // comboBoxDeviceList
            // 
            this.comboBoxDeviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceList.FormattingEnabled = true;
            this.comboBoxDeviceList.Location = new System.Drawing.Point(19, 18);
            this.comboBoxDeviceList.Name = "comboBoxDeviceList";
            this.comboBoxDeviceList.Size = new System.Drawing.Size(520, 20);
            this.comboBoxDeviceList.TabIndex = 4;
            // 
            // buttonOpenDevice
            // 
            this.buttonOpenDevice.Location = new System.Drawing.Point(357, 49);
            this.buttonOpenDevice.Name = "buttonOpenDevice";
            this.buttonOpenDevice.Size = new System.Drawing.Size(88, 23);
            this.buttonOpenDevice.TabIndex = 5;
            this.buttonOpenDevice.Text = "OpenDevice";
            this.buttonOpenDevice.UseVisualStyleBackColor = true;
            this.buttonOpenDevice.Click += new System.EventHandler(this.buttonOpenDevice_Click);
            // 
            // buttonBusWrite
            // 
            this.buttonBusWrite.Location = new System.Drawing.Point(364, 27);
            this.buttonBusWrite.Name = "buttonBusWrite";
            this.buttonBusWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonBusWrite.TabIndex = 6;
            this.buttonBusWrite.Text = "Write";
            this.buttonBusWrite.UseVisualStyleBackColor = true;
            this.buttonBusWrite.Click += new System.EventHandler(this.buttonBusWrite_Click);
            // 
            // buttonBusRead
            // 
            this.buttonBusRead.Location = new System.Drawing.Point(445, 27);
            this.buttonBusRead.Name = "buttonBusRead";
            this.buttonBusRead.Size = new System.Drawing.Size(75, 23);
            this.buttonBusRead.TabIndex = 7;
            this.buttonBusRead.Text = "Read";
            this.buttonBusRead.UseVisualStyleBackColor = true;
            this.buttonBusRead.Click += new System.EventHandler(this.buttonBusRead_Click);
            // 
            // buttonCloseDevice
            // 
            this.buttonCloseDevice.Location = new System.Drawing.Point(451, 49);
            this.buttonCloseDevice.Name = "buttonCloseDevice";
            this.buttonCloseDevice.Size = new System.Drawing.Size(88, 23);
            this.buttonCloseDevice.TabIndex = 8;
            this.buttonCloseDevice.Text = "CloseDevice";
            this.buttonCloseDevice.UseVisualStyleBackColor = true;
            this.buttonCloseDevice.Click += new System.EventHandler(this.buttonCloseDevice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCloseDevice);
            this.groupBox1.Controls.Add(this.buttonOpenDevice);
            this.groupBox1.Controls.Add(this.comboBoxDeviceList);
            this.groupBox1.Controls.Add(this.buttonFindDevice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 88);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonBusRead);
            this.groupBox2.Controls.Add(this.buttonBusWrite);
            this.groupBox2.Controls.Add(this.textBoxBusData);
            this.groupBox2.Controls.Add(this.textBoxBusAddress);
            this.groupBox2.Controls.Add(this.textBoxSlotNo);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bus Access (HEX)";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(14, 193);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(551, 68);
            this.textBoxResult.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C86BoxUtil Sample Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindDevice;
        private System.Windows.Forms.TextBox textBoxSlotNo;
        private System.Windows.Forms.TextBox textBoxBusAddress;
        private System.Windows.Forms.TextBox textBoxBusData;
        private System.Windows.Forms.ComboBox comboBoxDeviceList;
        private System.Windows.Forms.Button buttonOpenDevice;
        private System.Windows.Forms.Button buttonBusWrite;
        private System.Windows.Forms.Button buttonBusRead;
        private System.Windows.Forms.Button buttonCloseDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
    }
}

