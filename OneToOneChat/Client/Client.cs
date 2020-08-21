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

namespace Client
{
    public partial class Client : Form
    {
        Socket _clientSocket;
        byte[] recivebuffer = new byte[1024];
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            clientMsg.Text = "connecting.................";
            IPEndPoint serverep = new IPEndPoint(IPAddress.Parse(textHost.Text), Convert.ToInt32(textPort.Text));
            _clientSocket.Connect(serverep);
            if (_clientSocket.Connected)
            {
                clientMsg.Text = "Connected...";
                _clientSocket.BeginReceive(recivebuffer, 0, recivebuffer.Length - 1, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _clientSocket);
                byte[] sendbuffer = Encoding.ASCII.GetBytes("@@" + textUserName.Text);
                _clientSocket.Send(sendbuffer);
            }
            else
            {
                clientMsg.Text = "connection failed....";
            }

        }
        private void ReceiveCallBack(IAsyncResult aResult)
        {
            Socket socket = (Socket)aResult.AsyncState;
            if (socket.Connected)
            {
                int recevied = socket.EndReceive(aResult);
                if (recevied != 0)
                {
                    byte[] databuff = new byte[recevied];
                    Array.Copy(recivebuffer, databuff, recevied);

                    string data = Encoding.ASCII.GetString(databuff);
                    textStatus.Items.Add("Server : " + data);
                    textStatus.Items.Add(Environment.NewLine);
                    _clientSocket.BeginReceive(recivebuffer, 0, recivebuffer.Length - 1, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _clientSocket);
                }
                else
                {
                    textStatus.Items.Add("Server : " + " ");
                    textStatus.Items.Add(Environment.NewLine);
                    _clientSocket.BeginReceive(recivebuffer, 0, recivebuffer.Length - 1, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _clientSocket);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] sendbuffer = Encoding.ASCII.GetBytes(textMsg.Text);
            _clientSocket.Send(sendbuffer);
            textStatus.Items.Add("Me : " + textMsg.Text);
            textMsg.Text = " ";
            textStatus.Items.Add(Environment.NewLine);
        }
        private void textStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
