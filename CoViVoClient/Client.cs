using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WrapperLib;

namespace CoViVoClient
{
    class Client {
        private const int server_port = 9050;
        private const string server = "localhost";
        private TcpClient tcp_client;
        private NetworkStream tcp_stream;
        private String nick;


        public Client(String nick) {
            this.nick = nick;
        }

        public bool connect() {
            try {
                this.tcp_client = new TcpClient(server, server_port);
                this.tcp_stream = this.tcp_client.GetStream();
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        public bool sendMessage(Message message) {
            try {
                connect();
                message.user = nick;
                byte[] wrappedMessage = Util.Wrap(message);
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                Console.WriteLine(encoding.GetString(wrappedMessage));
                tcp_stream.Write(wrappedMessage, 0, wrappedMessage.Length);
                tcp_client.Close();
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        public void joinServer() {
            JoinServer joinServ = new JoinServer();
            sendMessage(joinServ);
        }
        public void leaveServer() {
            LeaveServer leaveServ = new LeaveServer();
            sendMessage(leaveServ);
        }

        public void sendWrappedMessage(String msg) {
            Text message = new Text();
            message.text = msg;
            sendMessage(message);
        }

        public void createChannel(String name) {
            StartChannel startChannel = new StartChannel();
        }
    }
}
