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
        Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] recivedBuffer = new byte[1024];
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Client_Load(object sender, EventArgs e)
        {
        }
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblClientmsg.Text = "Please wait Connectiong to the server................";
                _clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 9686);
                lblClientmsg.Text = ("Connected!");
                _clientSocket.BeginReceive(recivedBuffer, 0, recivedBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _clientSocket);
                byte[] buffer = Encoding.ASCII.GetBytes("@@" + textName.Text);
                _clientSocket.Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void ReceiveCallBack(IAsyncResult aResult)
        {
            try
            {
                Socket socket = (Socket)aResult.AsyncState;
                int received = socket.EndReceive(aResult);
                byte[] dataBuf = new byte[received];
                Array.Copy(recivedBuffer, dataBuf, received);
                string message = Encoding.ASCII.GetString(dataBuf);
                Textstatus.Items.Add("Server : " + message);
                Textstatus.Items.Add(Environment.NewLine);
                _clientSocket.BeginReceive(recivedBuffer, 0, recivedBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), _clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); ;
            }
        }
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] sendMsg = Encoding.ASCII.GetBytes(textMsg.Text);
                _clientSocket.Send(sendMsg);
                Textstatus.Items.Add("Client : " + textMsg.Text);
                Textstatus.Items.Add(Environment.NewLine);
                textMsg.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); ;
            }
        }
7--*    }
}
