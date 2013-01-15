using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using WrapperLib;

namespace CoViVoClient
{
    class CovUdpClient
    {
        private const int udp_port = 9051;
        private const string host = "localhost";
        private UdpClient udp_client;
        private string nick;

        public CovUdpClient(String nick, int port) {
            this.udp_client = new UdpClient(port);
            this.nick = nick;
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
            udp_client.Send(wrappedMessage, wrappedMessage.Length);
        }

        public void proveAlive() {
            Alive alive = new Alive();
            alive.user = nick;
            byte[] wrappedMessage = Util.Wrap(alive);
            udp_client.Send(wrappedMessage, wrappedMessage.Length);
        }

        public void proover() {
            while (true) {
                proveAlive();
                System.Threading.Thread.Sleep(5000);
            }
        }

        public void listen() {
            while (true) {
                IPAddress addr = IPAddress.Any;
                IPEndPoint ipep = new IPEndPoint(addr, 0);
                byte[] messageWrapped = udp_client.Receive(ref ipep);
                Message messageUnwrapped = WrapperLib.Util.Unwrap(messageWrapped);
                Console.WriteLine("odebralem wiadomosc");
                Console.WriteLine(messageUnwrapped);
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
