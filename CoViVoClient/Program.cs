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
            /*client.connect();
            client.sendChannelListRequest();

            Thread thread1 = new Thread(new ThreadStart(client.listen));
            thread1.Start();
            while (true){} */

            /*CovUdpClient client = new CovUdpClient("deva", 123);//Convert.ToInt32(args[0]));
            client.connect();
            
            Thread thread1 = new Thread(new ThreadStart(client.proover));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(client.listen));
            thread2.Start(); */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CoViVo cov = new CoViVo();
            Application.Run(cov);
            client.setGui(cov);
            cov.setClient(client);
        }
    }
}