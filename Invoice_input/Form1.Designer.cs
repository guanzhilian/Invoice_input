namespace Invoice_input
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVCode = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.btnQRCodeDecode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTaxMoney = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTaxM2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkAutoNext = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.lblNo = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lblzuofei = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(97, 45);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(82, 21);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "044001507111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "发票代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "发票号码：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(256, 45);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(57, 21);
            this.txtNum.TabIndex = 3;
            this.txtNum.Text = "22525479";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "开票日期：";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(390, 45);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(72, 21);
            this.txtDate.TabIndex = 5;
            this.txtDate.Text = "2017-10-02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "开票金额：";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(539, 45);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(75, 21);
            this.txtMoney.TabIndex = 7;
            this.txtMoney.Text = "553.18";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "验证码：";
            // 
            // txtVCode
            // 
            this.txtVCode.Location = new System.Drawing.Point(679, 45);
            this.txtVCode.Name = "txtVCode";
            this.txtVCode.Size = new System.Drawing.Size(100, 21);
            this.txtVCode.TabIndex = 9;
            this.txtVCode.Text = "14232 73793 54851 65176";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(786, 44);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "填写";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(97, 13);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(450, 21);
            this.txtQRCode.TabIndex = 13;
            this.txtQRCode.Text = "01,04,1300171320,14951268,97086.41,20170912,65801623071025963461,7E0F,";
            // 
            // btnQRCodeDecode
            // 
            this.btnQRCodeDecode.Location = new System.Drawing.Point(554, 11);
            this.btnQRCodeDecode.Name = "btnQRCodeDecode";
            this.btnQRCodeDecode.Size = new System.Drawing.Size(75, 23);
            this.btnQRCodeDecode.TabIndex = 14;
            this.btnQRCodeDecode.Text = "QRCodeDecode";
            this.btnQRCodeDecode.UseVisualStyleBackColor = true;
            this.btnQRCodeDecode.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 645);
            this.panel1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(990, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "打开调试器";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTaxMoney
            // 
            this.txtTaxMoney.Location = new System.Drawing.Point(1071, 44);
            this.txtTaxMoney.Name = "txtTaxMoney";
            this.txtTaxMoney.Size = new System.Drawing.Size(100, 21);
            this.txtTaxMoney.TabIndex = 17;
            this.txtTaxMoney.Text = "14232 73793 54851 65176";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(705, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "取金额";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(786, 12);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(198, 21);
            this.txtScript.TabIndex = 19;
            this.txtScript.Text = "$(\'#jshjxx_dzfp\').text();";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTaxM2
            // 
            this.txtTaxM2.AllowDrop = true;
            this.txtTaxM2.Location = new System.Drawing.Point(1002, 13);
            this.txtTaxM2.Name = "txtTaxM2";
            this.txtTaxM2.Size = new System.Drawing.Size(198, 21);
            this.txtTaxM2.TabIndex = 20;
            this.txtTaxM2.Text = "$(\'#jshjxx_dzfp\').text();";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "发票二维码：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "打开文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(554, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "手工跳过";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkAutoNext
            // 
            this.chkAutoNext.AutoSize = true;
            this.chkAutoNext.Location = new System.Drawing.Point(470, 80);
            this.chkAutoNext.Name = "chkAutoNext";
            this.chkAutoNext.Size = new System.Drawing.Size(72, 16);
            this.chkAutoNext.TabIndex = 24;
            this.chkAutoNext.Text = "自动一行";
            this.chkAutoNext.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(187, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "开始验证";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerRun
            // 
            this.timerRun.Interval = 2000;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(282, 78);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(41, 12);
            this.lblNo.TabIndex = 25;
            this.lblNo.Text = "label7";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(867, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "ExecScript";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblzuofei
            // 
            this.lblzuofei.AutoSize = true;
            this.lblzuofei.BackColor = System.Drawing.SystemColors.Window;
            this.lblzuofei.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblzuofei.ForeColor = System.Drawing.Color.Red;
            this.lblzuofei.Location = new System.Drawing.Point(1068, 73);
            this.lblzuofei.Name = "lblzuofei";
            this.lblzuofei.Size = new System.Drawing.Size(49, 19);
            this.lblzuofei.TabIndex = 27;
            this.lblzuofei.Text = "作废";
            this.lblzuofei.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 766);
            this.Controls.Add(this.lblzuofei);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chkAutoNext);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTaxM2);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTaxMoney);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQRCodeDecode);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVCode;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnQRCodeDecode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTaxMoney;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTaxM2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkAutoNext;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblzuofei;
    }
}

