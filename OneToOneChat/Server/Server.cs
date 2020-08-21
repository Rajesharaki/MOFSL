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
        byte[] buffer;

        Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string clientEndPoint;
        string clientName;
        Socket _clientSocket;
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Server_Load(object sender, EventArgs e)
        {
            buffer = new byte[1024];
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            serverMsg.Text = "setting up server......";
            IPEndPoint serverep = new IPEndPoint(IPAddress.Parse(textServerHost.Text), Convert.ToInt32(textServerPort.Text));
            _serverSocket.Bind(serverep);
            serverMsg.Text = "Server running..................";
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }
        private void AcceptCallBack(IAsyncResult aResult)
        {
            Socket socket = _serverSocket.EndAccept(aResult);
            _clientSocket = socket;
            clientEndPoint = socket.RemoteEndPoint.ToString();
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallBack), socket);
        }
        private void RecieveCallBack(IAsyncResult aResult)
        {
            Socket socket = (Socket)aResult.AsyncState;
            int Received = 0;
            if (socket.Connected)
            {
                try
                {
                    Received = socket.EndReceive(aResult);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                if (Received != 0)
                {
                    byte[] dataBuffer = new byte[Received];
                    Array.Copy(buffer, dataBuffer, Received);

                    //convert byte to string
                    string data = Encoding.ASCII.GetString(dataBuffer);

                    if (data.Contains("@@"))
                    {
                        if (clientEndPoint == socket.RemoteEndPoint.ToString())
                        {
                            clientName = data.Substring(1, data.Length-1);
                            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallBack), socket);
                            return;
                        }
                    }
                    textStatus.Items.Add(clientName + " : " + data);
                    textStatus.Items.Add(Environment.NewLine);
                    socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(RecieveCallBack), socket);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] sendbuffer = Encoding.ASCII.GetBytes(textMsg.Text);
            textStatus.Items.Add("Server : "+textMsg.Text);
            textStatus.Items.Add(Environment.NewLine);
            textMsg.Text = string.Empty;
            if (_clientSocket.Connected)
            {
                _clientSocket.BeginSend(sendbuffer, 0, sendbuffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), _clientSocket);
            }
        }
        private void SendCallBack(IAsyncResult aResult) 
        {
            Socket socket = (Socket)aResult.AsyncState;
            socket.EndSend(aResult);
        }
    }
}
