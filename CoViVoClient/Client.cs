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
        private const string server = "localhost";
        private TcpClient tcp_client;
        private TcpListener tcpListener;
        private IPAddress addr = IPAddress.Any;
        private NetworkStream tcp_stream;
        private String nick;
        private String[] currentChannelList;
        private CoViVo gui;


        public Client(String nick) {
            this.nick = nick;
            tcpListener = new TcpListener(addr, server_port+2);
        }

        public void setGui(CoViVo gui) {
            this.gui = gui;
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
            startChannel.channelName = name;
            sendMessage(startChannel);
        }

        public void sendChannelListRequest() {
            RequestChannelList request = new RequestChannelList();
            sendMessage(request);
        }

        public void handleMessage(Message msg) {
            if (msg is ChannelList) {
                ChannelList list = (ChannelList)msg;
                currentChannelList = list.channelList;
                Console.WriteLine(list);
            }
        }

        public void listen() {
            tcpListener.Start();
            while (true) {
                TcpClient tempTcpClient = tcpListener.AcceptTcpClient();
                NetworkStream tempTcpStream = tempTcpClient.GetStream();
                byte[] wrappedMessage = new byte[1024];
                tempTcpStream.Read(wrappedMessage, 0, wrappedMessage.Length);
                handleMessage(Util.Unwrap(wrappedMessage));
            }
        }

        public void getCurrentChannelList() {
            currentChannelList = new String[3];
            currentChannelList[0] = "abc";
            currentChannelList[1] = "def";
            currentChannelList[2] = "ghi";
        }
    }
}
