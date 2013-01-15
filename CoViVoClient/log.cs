using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViVoClient
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String user = usernameBox.Text;
            String port_string = portBox.Text;
            int port = Convert.ToInt32(port_string);
            Console.WriteLine("zalogowales sie jako: " + user + "na porcie:" + port);
        }
    }
}
