namespace C86BoxConfig
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBoardTypeA = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxBoardTypeB = new System.Windows.Forms.ComboBox();
            this.buttonWriteConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxManualB = new System.Windows.Forms.PictureBox();
            this.pictureBoxManualA = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManualB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManualA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxManualA);
            this.groupBox1.Controls.Add(this.comboBoxBoardTypeA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SLOT A";
            // 
            // comboBoxBoardTypeA
            // 
            this.comboBoxBoardTypeA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoardTypeA.FormattingEnabled = true;
            this.comboBoxBoardTypeA.Location = new System.Drawing.Point(18, 24);
            this.comboBoxBoardTypeA.Name = "comboBoxBoardTypeA";
            this.comboBoxBoardTypeA.Size = new System.Drawing.Size(350, 20);
            this.comboBoxBoardTypeA.TabIndex = 2;
            this.comboBoxBoardTypeA.SelectedIndexChanged += new System.EventHandler(this.comboBoxBoardTypeA_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxManualB);
            this.groupBox2.Controls.Add(this.comboBoxBoardTypeB);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 279);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SLOT B";
            // 
            // comboBoxBoardTypeB
            // 
            this.comboBoxBoardTypeB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoardTypeB.FormattingEnabled = true;
            this.comboBoxBoardTypeB.Location = new System.Drawing.Point(18, 24);
            this.comboBoxBoardTypeB.Name = "comboBoxBoardTypeB";
            this.comboBoxBoardTypeB.Size = new System.Drawing.Size(351, 20);
            this.comboBoxBoardTypeB.TabIndex = 2;
            this.comboBoxBoardTypeB.SelectedIndexChanged += new System.EventHandler(this.comboBoxBoardTypeB_SelectedIndexChanged);
            // 
            // buttonWriteConfig
            // 
            this.buttonWriteConfig.Location = new System.Drawing.Point(548, 297);
            this.buttonWriteConfig.Name = "buttonWriteConfig";
            this.buttonWriteConfig.Size = new System.Drawing.Size(118, 50);
            this.buttonWriteConfig.TabIndex = 5;
            this.buttonWriteConfig.Text = "設定実行";
            this.buttonWriteConfig.UseVisualStyleBackColor = true;
            this.buttonWriteConfig.Click += new System.EventHandler(this.buttonWriteConfig_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 44);
            this.label1.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(672, 297);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 50);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxManualB
            // 
            this.pictureBoxManualB.Image = global::C86BoxConfig.Properties.Resources.none;
            this.pictureBoxManualB.Location = new System.Drawing.Point(18, 59);
            this.pictureBoxManualB.Name = "pictureBoxManualB";
            this.pictureBoxManualB.Size = new System.Drawing.Size(351, 200);
            this.pictureBoxManualB.TabIndex = 3;
            this.pictureBoxManualB.TabStop = false;
            // 
            // pictureBoxManualA
            // 
            this.pictureBoxManualA.Image = global::C86BoxConfig.Properties.Resources.none;
            this.pictureBoxManualA.InitialImage = null;
            this.pictureBoxManualA.Location = new System.Drawing.Point(18, 59);
            this.pictureBoxManualA.Name = "pictureBoxManualA";
            this.pictureBoxManualA.Size = new System.Drawing.Size(350, 200);
            this.pictureBoxManualA.TabIndex = 3;
            this.pictureBoxManualA.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 359);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWriteConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "C86BOX ボード種別設定ユーティリティ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManualB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManualA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxManualA;
        private System.Windows.Forms.ComboBox comboBoxBoardTypeA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxManualB;
        private System.Windows.Forms.ComboBox comboBoxBoardTypeB;
        private System.Windows.Forms.Button buttonWriteConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
    }
}

