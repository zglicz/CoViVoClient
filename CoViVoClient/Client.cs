using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;
using WrapperLib;

namespace CoViVoClient
{
    public class Client {
        private const int server_port = 9050;
        private int udp_port = 0;
        private const string server = "localhost";
        private TcpClient tcp_client;
        private IPAddress addr = IPAddress.Any;
        private NetworkStream tcp_stream;
        private String nick;
        private String[] currentChannelList;
        private CoViVo gui;
        private CovUdpClient udpClient;


        public Client(String nick) {
            this.nick = nick; 
            //udpClient = new CovUdpClient(this, nick, udp_port);
        }

        public void setGui(CoViVo gui) {
            this.gui = gui;
        }

        public void setNick(String nick) {
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

        public bool sendMessage(Message message, bool response=false) {
            try {
                connect();
                message.user = nick;
                byte[] wrappedMessage = Util.Wrap(message);
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                Console.WriteLine(encoding.GetString(wrappedMessage));
                tcp_stream.Write(wrappedMessage, 0, wrappedMessage.Length);
                if (response) {
                    byte[] wrappedResponse = new byte[1024];
                    tcp_stream.Read(wrappedResponse, 0, wrappedResponse.Length);
                    handleMessage(Util.Unwrap(wrappedResponse));
                }
                tcp_client.Close();
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        public void joinServer(String nick, int port)
        {
            this.nick = nick;
            this.udp_port = port;
            JoinServer joinServ = new JoinServer();
            sendMessage(joinServ);
            udpClient = new CovUdpClient(this, nick, port);
            udpClient.connect();
            Console.WriteLine("udp Client: " + udpClient);
        }
        public void leaveServer() {
            LeaveServer leaveServ = new LeaveServer();
            sendMessage(leaveServ);
        }

        public void sendWrappedMessage(String msg, String channel) {
            Console.WriteLine("udp client is null " + (udpClient == null));
            //udpClient = new CovUdpClient(this, nick, udp_port);
            udpClient.sendMessage(msg, channel);
        }

        public void createChannel(String name) {
            StartChannel startChannel = new StartChannel();
            startChannel.channelName = name;
            sendMessage(startChannel, false);
        }

        public void joinChannel(String name) {
            JoinChannel joinChannel = new JoinChannel();
            joinChannel.channelName = name;
            sendMessage(joinChannel, false);
        }

        public void sendChannelListRequest() {
            RequestChannelList request = new RequestChannelList();
            sendMessage(request, true);
        }

        public void handleMessage(Message msg) {
            if (msg is ChannelList) {
                ChannelList list = (ChannelList)msg;
                currentChannelList = list.channelList;
                Console.WriteLine(list);
            }
            if (msg is Text) {
                Text text = (Text)msg;
                Console.WriteLine(text.text);
                gui.handle_Message(text);
            }
        }

        public List<String> getCurrentChannelList() {
            sendChannelListRequest();
            List<String> list = new List<String>(currentChannelList);
            return list;
        }


    }
}
