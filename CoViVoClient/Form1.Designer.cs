namespace WindowsFormsApplication1
{
    partial class CoViVo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoViVo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Options = new System.Windows.Forms.ToolStripMenuItem();
            this.connectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.ToolStripMenuItem();
            this.AvailableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BeBackTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DisturbTool = new System.Windows.Forms.ToolStripMenuItem();
            this.UnavailableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.createChannel = new System.Windows.Forms.Button();
            this.channelNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.channelList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.join = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Options,
            this.Status,
            this.Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 334);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_Clicked);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectTool,
            this.disconnectTool});
            this.Options.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Options.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(61, 20);
            this.Options.Text = "Options";
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // connectTool
            // 
            this.connectTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.connectTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.connectTool.Image = ((System.Drawing.Image)(resources.GetObject("connectTool.Image")));
            this.connectTool.Name = "connectTool";
            this.connectTool.Size = new System.Drawing.Size(152, 22);
            this.connectTool.Text = "Connect";
            this.connectTool.Click += new System.EventHandler(this.connectTool_Click);
            // 
            // disconnectTool
            // 
            this.disconnectTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.disconnectTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.disconnectTool.Image = ((System.Drawing.Image)(resources.GetObject("disconnectTool.Image")));
            this.disconnectTool.Name = "disconnectTool";
            this.disconnectTool.Size = new System.Drawing.Size(133, 22);
            this.disconnectTool.Text = "Disconnect";
            this.disconnectTool.Click += new System.EventHandler(this.disconnectTool_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Status.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AvailableTool,
            this.BeBackTool,
            this.DisturbTool,
            this.UnavailableTool});
            this.Status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Status.ImageTransparentColor = System.Drawing.Color.White;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(51, 20);
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // AvailableTool
            // 
            this.AvailableTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AvailableTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AvailableTool.Image = ((System.Drawing.Image)(resources.GetObject("AvailableTool.Image")));
            this.AvailableTool.Name = "AvailableTool";
            this.AvailableTool.Size = new System.Drawing.Size(143, 22);
            this.AvailableTool.Text = "Available";
            this.AvailableTool.Click += new System.EventHandler(this.Available_Click);
            // 
            // BeBackTool
            // 
            this.BeBackTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BeBackTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BeBackTool.Image = ((System.Drawing.Image)(resources.GetObject("BeBackTool.Image")));
            this.BeBackTool.Name = "BeBackTool";
            this.BeBackTool.Size = new System.Drawing.Size(143, 22);
            this.BeBackTool.Text = "Be right back";
            this.BeBackTool.Click += new System.EventHandler(this.BeBack_Click);
            // 
            // DisturbTool
            // 
            this.DisturbTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DisturbTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DisturbTool.Image = ((System.Drawing.Image)(resources.GetObject("DisturbTool.Image")));
            this.DisturbTool.Name = "DisturbTool";
            this.DisturbTool.Size = new System.Drawing.Size(143, 22);
            this.DisturbTool.Text = "Don\'t disturb";
            this.DisturbTool.Click += new System.EventHandler(this.Disturb_Click);
            // 
            // UnavailableTool
            // 
            this.UnavailableTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UnavailableTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UnavailableTool.Image = ((System.Drawing.Image)(resources.GetObject("UnavailableTool.Image")));
            this.UnavailableTool.Name = "UnavailableTool";
            this.UnavailableTool.Size = new System.Drawing.Size(143, 22);
            this.UnavailableTool.Text = "Unavailable";
            this.UnavailableTool.Click += new System.EventHandler(this.Unavailable_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutTool});
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(61, 20);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // LogoutTool
            // 
            this.LogoutTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LogoutTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoutTool.Name = "LogoutTool";
            this.LogoutTool.Size = new System.Drawing.Size(115, 22);
            this.LogoutTool.Text = "Log out";
            this.LogoutTool.Click += new System.EventHandler(this.logout_Click);
            // 
            // createChannel
            // 
            this.createChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createChannel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createChannel.ForeColor = System.Drawing.Color.DimGray;
            this.createChannel.Location = new System.Drawing.Point(15, 51);
            this.createChannel.Name = "createChannel";
            this.createChannel.Size = new System.Drawing.Size(100, 31);
            this.createChannel.TabIndex = 6;
            this.createChannel.Text = "Create channel";
            this.createChannel.UseVisualStyleBackColor = false;
            this.createChannel.Click += new System.EventHandler(this.createChannel_Click);
            // 
            // channelNameBox
            // 
            this.channelNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.channelNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelNameBox.Location = new System.Drawing.Point(15, 25);
            this.channelNameBox.Name = "channelNameBox";
            this.channelNameBox.Size = new System.Drawing.Size(100, 20);
            this.channelNameBox.TabIndex = 7;
            this.channelNameBox.TextChanged += new System.EventHandler(this.channelNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Write channel\'s name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // channelList
            // 
            this.channelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.channelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelList.FormattingEnabled = true;
            this.channelList.Location = new System.Drawing.Point(206, 94);
            this.channelList.Margin = new System.Windows.Forms.Padding(5);
            this.channelList.Name = "channelList";
            this.channelList.Size = new System.Drawing.Size(210, 119);
            this.channelList.TabIndex = 11;
            this.channelList.SelectedIndexChanged += new System.EventHandler(this.channelList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(203, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose channel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.join.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.join.ForeColor = System.Drawing.Color.DimGray;
            this.join.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.join.Location = new System.Drawing.Point(206, 228);
            this.join.Margin = new System.Windows.Forms.Padding(10);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(80, 29);
            this.join.TabIndex = 13;
            this.join.Text = "Join";
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refresh.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresh.ForeColor = System.Drawing.Color.DimGray;
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh.Location = new System.Drawing.Point(289, 228);
            this.refresh.Margin = new System.Windows.Forms.Padding(10);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(127, 29);
            this.refresh.TabIndex = 14;
            this.refresh.Text = "Refresh list";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CoViVo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.join);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.channelList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.channelNameBox);
            this.Controls.Add(this.createChannel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoViVo";
            this.Text = "CoViVo";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.form_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Options;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem Status;
        private System.Windows.Forms.ToolStripMenuItem LogoutTool;
        private System.Windows.Forms.ToolStripMenuItem AvailableTool;
        private System.Windows.Forms.ToolStripMenuItem BeBackTool;
        private System.Windows.Forms.ToolStripMenuItem DisturbTool;
        private System.Windows.Forms.ToolStripMenuItem UnavailableTool;
        private System.Windows.Forms.ToolStripMenuItem connectTool;
        private System.Windows.Forms.ToolStripMenuItem disconnectTool;
        private System.Windows.Forms.Button createChannel;
        private System.Windows.Forms.TextBox channelNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListBox channelList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button1;
    }


}

