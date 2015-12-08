namespace AndonSerial
{
    partial class AndonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTZW = new System.Windows.Forms.ComboBox();
            this.cbJYW = new System.Windows.Forms.ComboBox();
            this.cbSJW = new System.Windows.Forms.ComboBox();
            this.cbBTL = new System.Windows.Forms.ComboBox();
            this.cbDK = new System.Windows.Forms.ComboBox();
            this.labTZW = new System.Windows.Forms.Label();
            this.labJYW = new System.Windows.Forms.Label();
            this.labSJW = new System.Windows.Forms.Label();
            this.labBTL = new System.Windows.Forms.Label();
            this.labDK = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvCOMShow = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerComGet = new System.Windows.Forms.Timer(this.components);
            this.btnOpenOrClose = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.cbClear = new System.Windows.Forms.CheckBox();
            this.cbSend = new System.Windows.Forms.CheckBox();
            this.cbDispHex = new System.Windows.Forms.CheckBox();
            this.txtMessageGet = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendSet = new System.Windows.Forms.TextBox();
            this.labSend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labGet = new System.Windows.Forms.Label();
            this.txtMessageSend = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNumClear = new System.Windows.Forms.Button();
            this.btnMessageGetClear = new System.Windows.Forms.Button();
            this.timerSendSet = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTZW);
            this.groupBox2.Controls.Add(this.cbJYW);
            this.groupBox2.Controls.Add(this.cbSJW);
            this.groupBox2.Controls.Add(this.cbBTL);
            this.groupBox2.Controls.Add(this.cbDK);
            this.groupBox2.Controls.Add(this.labTZW);
            this.groupBox2.Controls.Add(this.labJYW);
            this.groupBox2.Controls.Add(this.labSJW);
            this.groupBox2.Controls.Add(this.labBTL);
            this.groupBox2.Controls.Add(this.labDK);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始化";
            // 
            // cbTZW
            // 
            this.cbTZW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTZW.FormattingEnabled = true;
            this.cbTZW.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbTZW.Location = new System.Drawing.Point(52, 111);
            this.cbTZW.Name = "cbTZW";
            this.cbTZW.Size = new System.Drawing.Size(62, 20);
            this.cbTZW.TabIndex = 10;
            // 
            // cbJYW
            // 
            this.cbJYW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJYW.FormattingEnabled = true;
            this.cbJYW.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbJYW.Location = new System.Drawing.Point(52, 87);
            this.cbJYW.Name = "cbJYW";
            this.cbJYW.Size = new System.Drawing.Size(62, 20);
            this.cbJYW.TabIndex = 9;
            // 
            // cbSJW
            // 
            this.cbSJW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSJW.FormattingEnabled = true;
            this.cbSJW.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbSJW.Location = new System.Drawing.Point(52, 64);
            this.cbSJW.Name = "cbSJW";
            this.cbSJW.Size = new System.Drawing.Size(62, 20);
            this.cbSJW.TabIndex = 8;
            // 
            // cbBTL
            // 
            this.cbBTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBTL.FormattingEnabled = true;
            this.cbBTL.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbBTL.Location = new System.Drawing.Point(52, 41);
            this.cbBTL.Name = "cbBTL";
            this.cbBTL.Size = new System.Drawing.Size(62, 20);
            this.cbBTL.TabIndex = 7;
            // 
            // cbDK
            // 
            this.cbDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDK.FormattingEnabled = true;
            this.cbDK.Location = new System.Drawing.Point(52, 18);
            this.cbDK.Name = "cbDK";
            this.cbDK.Size = new System.Drawing.Size(62, 20);
            this.cbDK.TabIndex = 6;
            // 
            // labTZW
            // 
            this.labTZW.AutoSize = true;
            this.labTZW.Location = new System.Drawing.Point(5, 114);
            this.labTZW.Name = "labTZW";
            this.labTZW.Size = new System.Drawing.Size(41, 12);
            this.labTZW.TabIndex = 3;
            this.labTZW.Text = "停止位";
            // 
            // labJYW
            // 
            this.labJYW.AutoSize = true;
            this.labJYW.Location = new System.Drawing.Point(5, 90);
            this.labJYW.Name = "labJYW";
            this.labJYW.Size = new System.Drawing.Size(41, 12);
            this.labJYW.TabIndex = 5;
            this.labJYW.Text = "校验位";
            // 
            // labSJW
            // 
            this.labSJW.AutoSize = true;
            this.labSJW.Location = new System.Drawing.Point(5, 67);
            this.labSJW.Name = "labSJW";
            this.labSJW.Size = new System.Drawing.Size(41, 12);
            this.labSJW.TabIndex = 4;
            this.labSJW.Text = "数据位";
            // 
            // labBTL
            // 
            this.labBTL.AutoSize = true;
            this.labBTL.Location = new System.Drawing.Point(5, 44);
            this.labBTL.Name = "labBTL";
            this.labBTL.Size = new System.Drawing.Size(41, 12);
            this.labBTL.TabIndex = 3;
            this.labBTL.Text = "波特率";
            // 
            // labDK
            // 
            this.labDK.AutoSize = true;
            this.labDK.Location = new System.Drawing.Point(17, 21);
            this.labDK.Name = "labDK";
            this.labDK.Size = new System.Drawing.Size(29, 12);
            this.labDK.TabIndex = 3;
            this.labDK.Text = "端口";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvCOMShow);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口状态";
            // 
            // lvCOMShow
            // 
            this.lvCOMShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.state});
            this.lvCOMShow.FullRowSelect = true;
            this.lvCOMShow.Location = new System.Drawing.Point(6, 17);
            this.lvCOMShow.Name = "lvCOMShow";
            this.lvCOMShow.Size = new System.Drawing.Size(114, 65);
            this.lvCOMShow.TabIndex = 3;
            this.lvCOMShow.UseCompatibleStateImageBehavior = false;
            this.lvCOMShow.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 55;
            // 
            // state
            // 
            this.state.Text = "状态";
            this.state.Width = 55;
            // 
            // timerComGet
            // 
            this.timerComGet.Enabled = true;
            this.timerComGet.Interval = 2000;
            this.timerComGet.Tick += new System.EventHandler(this.timerComGet_Tick);
            // 
            // btnOpenOrClose
            // 
            this.btnOpenOrClose.Location = new System.Drawing.Point(296, 318);
            this.btnOpenOrClose.Name = "btnOpenOrClose";
            this.btnOpenOrClose.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOrClose.TabIndex = 4;
            this.btnOpenOrClose.Text = "打开串口";
            this.btnOpenOrClose.UseVisualStyleBackColor = true;
            this.btnOpenOrClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbReturn);
            this.groupBox4.Controls.Add(this.cbClear);
            this.groupBox4.Controls.Add(this.cbSend);
            this.groupBox4.Controls.Add(this.cbDispHex);
            this.groupBox4.Location = new System.Drawing.Point(12, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 109);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(15, 83);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(96, 16);
            this.cbReturn.TabIndex = 1;
            this.cbReturn.Text = "发送行末回车";
            this.cbReturn.UseVisualStyleBackColor = true;
            // 
            // cbClear
            // 
            this.cbClear.AutoSize = true;
            this.cbClear.Location = new System.Drawing.Point(15, 61);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(96, 16);
            this.cbClear.TabIndex = 8;
            this.cbClear.Text = "自动清空接收";
            this.cbClear.UseVisualStyleBackColor = true;
            // 
            // cbSend
            // 
            this.cbSend.AutoSize = true;
            this.cbSend.Location = new System.Drawing.Point(15, 39);
            this.cbSend.Name = "cbSend";
            this.cbSend.Size = new System.Drawing.Size(96, 16);
            this.cbSend.TabIndex = 8;
            this.cbSend.Text = "十六进制发送";
            this.cbSend.UseVisualStyleBackColor = true;
            // 
            // cbDispHex
            // 
            this.cbDispHex.AutoSize = true;
            this.cbDispHex.Location = new System.Drawing.Point(15, 17);
            this.cbDispHex.Name = "cbDispHex";
            this.cbDispHex.Size = new System.Drawing.Size(96, 16);
            this.cbDispHex.TabIndex = 7;
            this.cbDispHex.Text = "十六进制显示";
            this.cbDispHex.UseVisualStyleBackColor = true;
            // 
            // txtMessageGet
            // 
            this.txtMessageGet.Location = new System.Drawing.Point(6, 18);
            this.txtMessageGet.Multiline = true;
            this.txtMessageGet.Name = "txtMessageGet";
            this.txtMessageGet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageGet.Size = new System.Drawing.Size(223, 104);
            this.txtMessageGet.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(296, 343);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "接收字符";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSendSet);
            this.groupBox1.Controls.Add(this.labSend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labGet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(152, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnSendSet
            // 
            this.btnSendSet.Location = new System.Drawing.Point(19, 54);
            this.btnSendSet.Name = "btnSendSet";
            this.btnSendSet.Size = new System.Drawing.Size(75, 23);
            this.btnSendSet.TabIndex = 15;
            this.btnSendSet.Text = "自动发送";
            this.btnSendSet.UseVisualStyleBackColor = true;
            this.btnSendSet.Click += new System.EventHandler(this.btnSendSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "ms";
            // 
            // txtSendSet
            // 
            this.txtSendSet.Location = new System.Drawing.Point(19, 80);
            this.txtSendSet.Name = "txtSendSet";
            this.txtSendSet.Size = new System.Drawing.Size(65, 21);
            this.txtSendSet.TabIndex = 13;
            // 
            // labSend
            // 
            this.labSend.AutoSize = true;
            this.labSend.Location = new System.Drawing.Point(80, 38);
            this.labSend.Name = "labSend";
            this.labSend.Size = new System.Drawing.Size(29, 12);
            this.labSend.TabIndex = 11;
            this.labSend.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "发送字符";
            // 
            // labGet
            // 
            this.labGet.AutoSize = true;
            this.labGet.Location = new System.Drawing.Point(80, 18);
            this.labGet.Name = "labGet";
            this.labGet.Size = new System.Drawing.Size(29, 12);
            this.labGet.TabIndex = 9;
            this.labGet.Text = "----";
            // 
            // txtMessageSend
            // 
            this.txtMessageSend.Location = new System.Drawing.Point(6, 19);
            this.txtMessageSend.Multiline = true;
            this.txtMessageSend.Name = "txtMessageSend";
            this.txtMessageSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageSend.Size = new System.Drawing.Size(223, 85);
            this.txtMessageSend.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMessageGet);
            this.groupBox5.Location = new System.Drawing.Point(152, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 128);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据接收区域";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMessageSend);
            this.groupBox6.Location = new System.Drawing.Point(152, 141);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 110);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "数据发送区域";
            // 
            // btnNumClear
            // 
            this.btnNumClear.Location = new System.Drawing.Point(296, 292);
            this.btnNumClear.Name = "btnNumClear";
            this.btnNumClear.Size = new System.Drawing.Size(75, 23);
            this.btnNumClear.TabIndex = 12;
            this.btnNumClear.Text = "清空计数";
            this.btnNumClear.UseVisualStyleBackColor = true;
            this.btnNumClear.Click += new System.EventHandler(this.btnNumClear_Click);
            // 
            // btnMessageGetClear
            // 
            this.btnMessageGetClear.Location = new System.Drawing.Point(296, 265);
            this.btnMessageGetClear.Name = "btnMessageGetClear";
            this.btnMessageGetClear.Size = new System.Drawing.Size(75, 23);
            this.btnMessageGetClear.TabIndex = 13;
            this.btnMessageGetClear.Text = "清空接收";
            this.btnMessageGetClear.UseVisualStyleBackColor = true;
            this.btnMessageGetClear.Click += new System.EventHandler(this.btnMessageGetClear_Click);
            // 
            // timerSendSet
            // 
            this.timerSendSet.Tick += new System.EventHandler(this.timerSendSet_Tick);
            // 
            // AndonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 385);
            this.Controls.Add(this.btnMessageGetClear);
            this.Controls.Add(this.btnNumClear);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnOpenOrClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AndonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试器";
            this.Load += new System.EventHandler(this.AndonForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTZW;
        private System.Windows.Forms.ComboBox cbJYW;
        private System.Windows.Forms.ComboBox cbSJW;
        private System.Windows.Forms.ComboBox cbBTL;
        private System.Windows.Forms.ComboBox cbDK;
        private System.Windows.Forms.Label labTZW;
        private System.Windows.Forms.Label labJYW;
        private System.Windows.Forms.Label labSJW;
        private System.Windows.Forms.Label labBTL;
        private System.Windows.Forms.Label labDK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvCOMShow;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.Timer timerComGet;
        private System.Windows.Forms.Button btnOpenOrClose;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbDispHex;
        private System.Windows.Forms.TextBox txtMessageGet;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox cbClear;
        private System.Windows.Forms.CheckBox cbSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labGet;
        private System.Windows.Forms.TextBox txtMessageSend;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnNumClear;
        private System.Windows.Forms.Button btnMessageGetClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendSet;
        private System.Windows.Forms.Timer timerSendSet;
        private System.Windows.Forms.Button btnSendSet;
    }
}