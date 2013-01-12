using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CoViVoClient
{
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
                CovUdpClient client = new CovUdpClient("deva", Convert.ToInt32(args[0]));
                client.connect();
                Thread thread1 = new Thread(new ThreadStart(client.proover));
                thread1.Start();
                Thread thread2 = new Thread(new ThreadStart(client.listen));
                thread2.Start();
                
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new CoViVo());
            }
        }
    }
}