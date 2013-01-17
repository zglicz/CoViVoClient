using CoViVoClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WrapperLib;
namespace WindowsFormsApplication1
{
    public partial class CoViVo : Form
    {
        Client client;
        List<chat> channels = new List<chat>();
        public CoViVo()
        {
            InitializeComponent();
        }
       public void setClient(Client client) {
           this.client = client;
       
       }

       private void join_Click(object sender, EventArgs e)
       {
           try
           {
               string item = channelList.SelectedItem.ToString();
               Console.WriteLine(item);
               
               chat s = new chat(item);
               channels.Add(s);
               s.Show();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Musisz wybrać kanał");
           }

           //tutaj do czatu

       }

       private void handle_Message(Text text)
       {
           String channel = text.channelName;
           Console.WriteLine("to jes ttoo co odbieramy od kuby: " + channel);
           String user = text.user;
           String message_text = text.text;
           chat temp_chat = null;
           foreach (chat c in channels)
           {
               if (c.channelname == channel)
               {
                   Console.WriteLine("to jest nasz wybrany czat: " + c.channelname);
                   temp_chat = c;
               }

           } 
           if (temp_chat != null)
               temp_chat.handle_Message(text);
       }
       private void refresh_Click(object sender, EventArgs e)
       {

           List<string> items = new List<string>();

           items = client.getCurrentChannelList();
           channelList.DataSource = items;

       }
        private void form_load(object sender, EventArgs e)
        {
            // załadowanie całej formy
        }

        private void button_send(object sender, EventArgs e)
        {
            // obsługa przycisku "Wyślij" potwierdzającego wysłanie wiadomości do użytkownika
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Options_Click(object sender, EventArgs e)
        {
            // wybranie pola opcji (connect, disconnect)
        }

        private void disconnectTool_Click(object sender, EventArgs e)
        {
            // opcja disconnect, przerwanie połączenia z serwerem
        }

        private void connectTool_Click(object sender, EventArgs e)
        {
            //opcja connect, otwiera sie okienko do zalogowania
            log s = new log();
            s.Show();
            
        }


        private void Status_Click(object sender, EventArgs e)
        {
            //wybranie pola "Status", zmiana statusu (available, unavailable...)
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            // wybranie pola ustawień "Settings"
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //wylogowanie uzytkownika
        }

        private void Conv_box(object sender, EventArgs e)
        {
            //okno rozmowy
        }

        private void Your_box(object sender, EventArgs e)
        {
            //pole tekstowe do wprowadzania wiadomosci
        }

        private void BeBack_Click(object sender, EventArgs e)
        {
            //status zaraz wracam
        }

        private void Disturb_Click(object sender, EventArgs e)
        {
            // status nie przeszkadzac
        }

        private void Unavailable_Click(object sender, EventArgs e)
        {
            // status niedostępny
        }

        private void Available_Click(object sender, EventArgs e)
        {
            // status dostępny
        }

        private void Voice_CheckedChanged(object sender, EventArgs e)
        {
            // zaznaczenie 'ptaszka' przy Voice, włączenia opcji transmisji głosowej
        }

        private void Video_CheckedChanged(object sender, EventArgs e)
        {
            // zaznaczenie 'ptaszka' przy Video, włączenie opcji transmisji video
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // aktualny status użytkownika
        }

        private void menu_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //całe menu dolne
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void createChannel_Click(object sender, EventArgs e)
        {
            String s = channelNameBox.Text;
            Console.WriteLine(s);
            client.createChannel(s);
            channelNameBox.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void channelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void channelNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text text = new Text();
            text.user = "asdaa";
            text.channelName = "edf";
            text.text = "siema";
            handle_Message(text);
        }










    }
}
