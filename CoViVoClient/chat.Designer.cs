namespace CoViVoClient
{
    partial class chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.checkVideo = new System.Windows.Forms.CheckBox();
            this.checkVoice = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkVideo
            // 
            this.checkVideo.AutoSize = true;
            this.checkVideo.BackColor = System.Drawing.Color.Transparent;
            this.checkVideo.Location = new System.Drawing.Point(12, 233);
            this.checkVideo.Name = "checkVideo";
            this.checkVideo.Size = new System.Drawing.Size(53, 17);
            this.checkVideo.TabIndex = 0;
            this.checkVideo.Text = "Video";
            this.checkVideo.UseVisualStyleBackColor = false;
            this.checkVideo.CheckedChanged += new System.EventHandler(this.checkVideo_CheckedChanged);
            // 
            // checkVoice
            // 
            this.checkVoice.AutoSize = true;
            this.checkVoice.BackColor = System.Drawing.Color.Transparent;
            this.checkVoice.Location = new System.Drawing.Point(71, 233);
            this.checkVoice.Name = "checkVoice";
            this.checkVoice.Size = new System.Drawing.Size(53, 17);
            this.checkVoice.TabIndex = 1;
            this.checkVoice.Text = "Voice";
            this.checkVoice.UseVisualStyleBackColor = false;
            this.checkVoice.CheckedChanged += new System.EventHandler(this.checkVoice_CheckedChanged);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.Window;
            this.sendButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.ForeColor = System.Drawing.Color.DimGray;
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.Location = new System.Drawing.Point(185, 183);
            this.sendButton.Margin = new System.Windows.Forms.Padding(10);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 29);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messageBox.Location = new System.Drawing.Point(12, 183);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(160, 39);
            this.messageBox.TabIndex = 4;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chatBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chatBox.Location = new System.Drawing.Point(9, 12);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(263, 165);
            this.chatBox.TabIndex = 5;
            this.chatBox.TextChanged += new System.EventHandler(this.chatBox_TextChanged);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.checkVoice);
            this.Controls.Add(this.checkVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "chat";
            this.Text = "CoViVo chat";
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkVideo;
        private System.Windows.Forms.CheckBox checkVoice;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox chatBox;
    }
}