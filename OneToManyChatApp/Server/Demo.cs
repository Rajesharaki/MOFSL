using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public class WebSockets
        {
            public Socket _socket { get; set; }
            public string _name { get; set; }
            public WebSockets(Socket socket)
            {
                _socket = socket;
            }
        }
        public byte[] buffer = new byte[1024];
        public Socket _serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public List<WebSockets> _clientsList { get; set; }
        public Server()
        {
            InitializeComponent();
            _clientsList = new List<WebSockets>();
        }
        private void Server_Load(object sender, EventArgs e)
        {
            //set up server
            setUpServer();
        }
        private void setUpServer()
        {
            serverMsg.Text = "setting up server..............";

            //Bind the server to the Specific IP and Port
            _serversocket.Bind(new IPEndPoint(IPAddress.Any, 9686));
            serverMsg.Text = "server running..............";

            //Listen to the Clients
            _serversocket.Listen(1);

            //Accept the clients connection
            _serversocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }
        private void AcceptCallBack(IAsyncResult aResult)
        {
            Socket socket = _serversocket.EndAccept(aResult);
            _clientsList.Add(new WebSockets(socket));
            Clients_List.Items.Add(socket.RemoteEndPoint.ToString());

            //Receive Data from clients
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
            //again accept the clients connection
            _serversocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }
        private void ReceiveCallBack(IAsyncResult aResult)
        {
            Socket socket = (Socket)aResult.AsyncState;
            if (socket.Connected)
            {
                //Received Data
                int Received = socket.EndReceive(aResult);
                if (Received != 0)
                {
                    byte[] dataBuffer = new byte[Received];
                    Array.Copy(buffer, dataBuffer, Received);

                    //Convert byte data to string
                    string Text = Encoding.ASCII.GetString(dataBuffer);

                    if (Text.Contains("@@"))
                    {
                        for (int i = 0; i < Clients_List.Items.Count; i++)
                        {
                            if (socket.RemoteEndPoint.ToString().Equals(_clientsList[i]._socket.RemoteEndPoint.ToString()))
                            {
                                Clients_List.Items.RemoveAt(i);
                                Clients_List.Items.Insert(i, Text.Substring(2, Text.Length));
                                _clientsList[i]._name = Text.Substring(2, Text.Length);

                                //Receive Data from clients
                                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
                                return;
                            }
                        }
                    }
                    //Appending Clients Message To the ListBox
                    for (int i = 0; i < _clientsList.Count; i++)
                    {
                        if (socket.RemoteEndPoint.ToString().Equals(_clientsList[i]._socket.RemoteEndPoint.ToString()))
                        {
                            textStatus.Items.Add(_clientsList[i]._name + " : " + Text);
                        }
                    }
                    //Receive Data from clients
                    socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
                }
            }
        }
    }
}
