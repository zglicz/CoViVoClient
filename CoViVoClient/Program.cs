using CoViVoClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


    namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // uruchamia klienta udp. co 5 sekund wysyla Alive, rownolegle nasluchuje na wiadomosci
            // od serwera i wypisuje je na konsole

            Client client = new Client("deva");
            /*client.joinServer();
            

            
            client.sendChannelListRequest();
            while (true*/
            /*CovUdpClient client = new CovUdpClient("deva", 123);//Convert.ToInt32(args[0]));
            client.connect();
             */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CoViVo cov = new CoViVo();
            client.setGui(cov);
            cov.setClient(client);
            Application.Run(cov);
        }
    }
}