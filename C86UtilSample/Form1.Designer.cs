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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonChipRead = new System.Windows.Forms.Button();
            this.buttonChipWrite = new System.Windows.Forms.Button();
            this.textBoxChipData = new System.Windows.Forms.TextBox();
            this.textBoxARegADDR = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDRegADDR = new System.Windows.Forms.TextBox();
            this.textBoxChipAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.textBoxResult.Location = new System.Drawing.Point(12, 301);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(551, 68);
            this.textBoxResult.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Result";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxChipAddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxDRegADDR);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonChipRead);
            this.groupBox3.Controls.Add(this.buttonChipWrite);
            this.groupBox3.Controls.Add(this.textBoxChipData);
            this.groupBox3.Controls.Add(this.textBoxARegADDR);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(14, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 94);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chip Access (HEX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "AREG ADDR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "slot";
            // 
            // buttonChipRead
            // 
            this.buttonChipRead.Location = new System.Drawing.Point(443, 61);
            this.buttonChipRead.Name = "buttonChipRead";
            this.buttonChipRead.Size = new System.Drawing.Size(75, 23);
            this.buttonChipRead.TabIndex = 7;
            this.buttonChipRead.Text = "Read";
            this.buttonChipRead.UseVisualStyleBackColor = true;
            this.buttonChipRead.Click += new System.EventHandler(this.buttonChipRead_Click);
            // 
            // buttonChipWrite
            // 
            this.buttonChipWrite.Location = new System.Drawing.Point(362, 61);
            this.buttonChipWrite.Name = "buttonChipWrite";
            this.buttonChipWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonChipWrite.TabIndex = 6;
            this.buttonChipWrite.Text = "Write";
            this.buttonChipWrite.UseVisualStyleBackColor = true;
            this.buttonChipWrite.Click += new System.EventHandler(this.buttonChipWrite_Click);
            // 
            // textBoxChipData
            // 
            this.textBoxChipData.Location = new System.Drawing.Point(281, 63);
            this.textBoxChipData.Name = "textBoxChipData";
            this.textBoxChipData.Size = new System.Drawing.Size(62, 19);
            this.textBoxChipData.TabIndex = 3;
            this.textBoxChipData.Text = "0";
            // 
            // textBoxARegADDR
            // 
            this.textBoxARegADDR.Location = new System.Drawing.Point(190, 29);
            this.textBoxARegADDR.Name = "textBoxARegADDR";
            this.textBoxARegADDR.Size = new System.Drawing.Size(64, 19);
            this.textBoxARegADDR.TabIndex = 2;
            this.textBoxARegADDR.Text = "188";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 19);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "DREG ADDR";
            // 
            // textBoxDRegADDR
            // 
            this.textBoxDRegADDR.Location = new System.Drawing.Point(346, 29);
            this.textBoxDRegADDR.Name = "textBoxDRegADDR";
            this.textBoxDRegADDR.Size = new System.Drawing.Size(64, 19);
            this.textBoxDRegADDR.TabIndex = 13;
            this.textBoxDRegADDR.Text = "18a";
            // 
            // textBoxChipAddress
            // 
            this.textBoxChipAddress.Location = new System.Drawing.Point(172, 63);
            this.textBoxChipAddress.Name = "textBoxChipAddress";
            this.textBoxChipAddress.Size = new System.Drawing.Size(62, 19);
            this.textBoxChipAddress.TabIndex = 15;
            this.textBoxChipAddress.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 384);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C86BoxUtil Sample Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDRegADDR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonChipRead;
        private System.Windows.Forms.Button buttonChipWrite;
        private System.Windows.Forms.TextBox textBoxChipData;
        private System.Windows.Forms.TextBox textBoxARegADDR;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxChipAddress;
    }
}

