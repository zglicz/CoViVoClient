using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using WrapperLib;
using System.Threading;

namespace CoViVoClient
{
    class CovUdpClient
    {
        private const int udp_port = 9051;
        private const string host = "localhost";
        private UdpClient udp_client;
        private UdpClient udp_listener;
        private Client client;
        private string nick;

        public CovUdpClient(Client client, String nick, int port) {
            Console.WriteLine("tworze klienta na porcie " + port);
            this.udp_client = new UdpClient(new IPEndPoint(IPAddress.Any, port));
            this.udp_listener = new UdpClient(new IPEndPoint(IPAddress.Any, port+1));
            this.nick = nick;
            this.client = client;
            connect();

            Thread thread1 = new Thread(new ThreadStart(this.proover));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(this.listen));
            thread2.Start();

            Console.WriteLine("utworzono udp clienta");
        }

        public bool connect() {
            try {
                udp_client.Connect(host, udp_port);
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        public void sendMessage(String msg, String channel) {
            Text to_send = new Text();
            to_send.user = nick;
            to_send.text = msg;
            to_send.channelName = channel;
            byte[] wrappedMessage = Util.Wrap(to_send);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Console.WriteLine(encoding.GetString(wrappedMessage));
            //connect();
            udp_client.Send(wrappedMessage, wrappedMessage.Length);
        }

        public void proveAlive() {
            Alive alive = new Alive();
            alive.user = nick;
            byte[] wrappedMessage = Util.Wrap(alive);
            udp_client.Send(wrappedMessage, wrappedMessage.Length);
        }

        public void proover() {
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                proveAlive();
                System.Threading.Thread.Sleep(28000);
            }
        }

        public void listen() {
            while (true) {
                Console.WriteLine("start listener'a");
                IPAddress addr = IPAddress.Any;
                IPEndPoint ipep = new IPEndPoint(addr, 0);
                byte[] messageWrapped = udp_listener.Receive(ref ipep);
                Message messageUnwrapped = WrapperLib.Util.Unwrap(messageWrapped);
                client.handleMessage(messageUnwrapped);
                Console.WriteLine("odebralem wiadomosc od " + ipep);
                Console.WriteLine(((Text)messageUnwrapped).text);
            }
        }

        public void keybordRead() {
            while (true) {
                String message = Console.ReadLine();
                if (message != null) {
                    sendMessage(message, "sampleChannel");
                }
            }
        }
    }
}
