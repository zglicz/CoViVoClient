namespace CoViVoClient
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.connectButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.coViVoLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Window;
            this.connectButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.ForeColor = System.Drawing.Color.DimGray;
            this.connectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.connectButton.Location = new System.Drawing.Point(101, 144);
            this.connectButton.Margin = new System.Windows.Forms.Padding(10);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(80, 29);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portBox.Location = new System.Drawing.Point(101, 92);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(147, 26);
            this.portBox.TabIndex = 5;
            this.portBox.TextChanged += new System.EventHandler(this.portBox_TextChanged);
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameBox.Location = new System.Drawing.Point(101, 51);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(147, 25);
            this.usernameBox.TabIndex = 6;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // coViVoLabel
            // 
            this.coViVoLabel.AutoSize = true;
            this.coViVoLabel.BackColor = System.Drawing.Color.Transparent;
            this.coViVoLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coViVoLabel.Location = new System.Drawing.Point(85, 9);
            this.coViVoLabel.Name = "coViVoLabel";
            this.coViVoLabel.Size = new System.Drawing.Size(74, 23);
            this.coViVoLabel.TabIndex = 7;
            this.coViVoLabel.Text = "CoViVo";
            this.coViVoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portLabel.Location = new System.Drawing.Point(27, 100);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(39, 18);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Port";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(14, 54);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 18);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(260, 206);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.coViVoLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.connectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "log";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label coViVoLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}