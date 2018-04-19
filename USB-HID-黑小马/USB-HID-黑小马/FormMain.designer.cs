namespace HIDTester
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.fraDeviceIdentifiers = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.cmdOpenDevice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCloseDevice = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.fdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuStrip = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fraDeviceIdentifiers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.aboutMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputListBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 12;
            this.outputListBox.Items.AddRange(new object[] {
            "lstResults"});
            this.outputListBox.Location = new System.Drawing.Point(21, 208);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(354, 112);
            this.outputListBox.TabIndex = 0;
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.outputListBox_SelectedIndexChanged);
            // 
            // fraDeviceIdentifiers
            // 
            this.fraDeviceIdentifiers.Controls.Add(this.txtProductID);
            this.fraDeviceIdentifiers.Controls.Add(this.lblProductID);
            this.fraDeviceIdentifiers.Controls.Add(this.txtVendorID);
            this.fraDeviceIdentifiers.Controls.Add(this.lblVendorID);
            this.fraDeviceIdentifiers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fraDeviceIdentifiers.Location = new System.Drawing.Point(12, 119);
            this.fraDeviceIdentifiers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fraDeviceIdentifiers.Name = "fraDeviceIdentifiers";
            this.fraDeviceIdentifiers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fraDeviceIdentifiers.Size = new System.Drawing.Size(179, 81);
            this.fraDeviceIdentifiers.TabIndex = 11;
            this.fraDeviceIdentifiers.TabStop = false;
            this.fraDeviceIdentifiers.Text = "设备ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.Location = new System.Drawing.Point(119, 51);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(49, 23);
            this.txtProductID.TabIndex = 3;
            this.txtProductID.Text = "16A9";
            // 
            // lblProductID
            // 
            this.lblProductID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProductID.Location = new System.Drawing.Point(6, 51);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(131, 21);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID (hex):";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorID.Location = new System.Drawing.Point(119, 24);
            this.txtVendorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(49, 23);
            this.txtVendorID.TabIndex = 1;
            this.txtVendorID.Text = "0451";
            // 
            // lblVendorID
            // 
            this.lblVendorID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblVendorID.Location = new System.Drawing.Point(6, 24);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(107, 19);
            this.lblVendorID.TabIndex = 0;
            this.lblVendorID.Text = "Vendor ID (hex):";
            // 
            // cmdOpenDevice
            // 
            this.cmdOpenDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOpenDevice.Location = new System.Drawing.Point(12, 8);
            this.cmdOpenDevice.Name = "cmdOpenDevice";
            this.cmdOpenDevice.Size = new System.Drawing.Size(74, 33);
            this.cmdOpenDevice.TabIndex = 12;
            this.cmdOpenDevice.Text = "打开设备";
            this.cmdOpenDevice.UseVisualStyleBackColor = true;
            this.cmdOpenDevice.Click += new System.EventHandler(this.cmdOpenDevice_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(336, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 26);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(207, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 185);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据 控制";
            // 
            // cmdCloseDevice
            // 
            this.cmdCloseDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCloseDevice.Location = new System.Drawing.Point(106, 8);
            this.cmdCloseDevice.Name = "cmdCloseDevice";
            this.cmdCloseDevice.Size = new System.Drawing.Size(74, 33);
            this.cmdCloseDevice.TabIndex = 19;
            this.cmdCloseDevice.Text = "关闭设备";
            this.cmdCloseDevice.UseVisualStyleBackColor = true;
            this.cmdCloseDevice.Click += new System.EventHandler(this.cmdCloseDevice_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stateLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stateLabel.Location = new System.Drawing.Point(15, 65);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(110, 31);
            this.stateLabel.TabIndex = 20;
            this.stateLabel.Text = "设备关闭";
            // 
            // fdToolStripMenuItem
            // 
            this.fdToolStripMenuItem.Name = "fdToolStripMenuItem";
            this.fdToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(44, 21);
            this.aboutMenu.Text = "关于";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // aboutMenuStrip
            // 
            this.aboutMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.aboutMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.aboutMenuStrip.Location = new System.Drawing.Point(26, 331);
            this.aboutMenuStrip.Name = "aboutMenuStrip";
            this.aboutMenuStrip.Size = new System.Drawing.Size(52, 25);
            this.aboutMenuStrip.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "获取Mac";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "开启服务";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 365);
            this.Controls.Add(this.aboutMenuStrip);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cmdCloseDevice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmdOpenDevice);
            this.Controls.Add(this.fraDeviceIdentifiers);
            this.Controls.Add(this.outputListBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.aboutMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "USB调试----黑小马";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.fraDeviceIdentifiers.ResumeLayout(false);
            this.fraDeviceIdentifiers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.aboutMenuStrip.ResumeLayout(false);
            this.aboutMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        internal System.Windows.Forms.GroupBox fraDeviceIdentifiers;
        internal System.Windows.Forms.TextBox txtProductID;
        internal System.Windows.Forms.Label lblProductID;
        internal System.Windows.Forms.TextBox txtVendorID;
        internal System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Button cmdOpenDevice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button cmdCloseDevice;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem fdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.MenuStrip aboutMenuStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

