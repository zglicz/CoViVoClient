using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WrapperLib;

namespace CoViVoClient
{
    public partial class chat : Form
    {
        public String channelname;
        public chat()
        {
            InitializeComponent();

        }
        public chat(String channel)
        {
            InitializeComponent();
            this.channelname = channel;

        }

        private void chat_Load(object sender, EventArgs e)
        {

        }

        private void chatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            String s = messageBox.Text;
            Console.WriteLine(s);
            messageBox.Text = "";
        }

        public void handle_Message(Text text)
        {
            String user = text.user;
            String message_text = text.text;
            this.chatBox.AppendText(user + ": " + message_text + '\n');
        }

        private void checkVideo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkVoice_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
