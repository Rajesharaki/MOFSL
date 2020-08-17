using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneToOneChatAPP
{
    public partial class ChatApp : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public ChatApp()
        {
            InitializeComponent();
        }
        private void ChatApp_Load(object sender, EventArgs e)
        {
            //set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress,true);
            mytextHost.Text=GetIPAddress();
            frdtextHost.Text = GetIPAddress();
        }
        private string GetIPAddress() 
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(mytextHost.Text), Convert.ToInt32(mytextPort.Text));
                socket.Bind(epLocal);

                //Connecting to remoteIp
                epRemote = new IPEndPoint(IPAddress.Parse(frdtextHost.Text), Convert.ToInt32(frdtextPort.Text));
                socket.Connect(epRemote);
                textStatus.Items.Add("Connected.........................");
                textStatus.Items.Add(Environment.NewLine);

                //Listening to Specific Port
                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void MessageCallBack(IAsyncResult result) 
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])result.AsyncState;

                //Converting Byte To string
                ASCIIEncoding encoding = new ASCIIEncoding();
                string receivedMsg = encoding.GetString(receivedData);

                //Adding this message to the ListBox
                textStatus.Items.Add(textFrdName.Text + " : " + receivedMsg );
                textStatus.Items.Add(Environment.NewLine);

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //Converting String To byte
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = encoding.GetBytes(textMsg.Text);

            //Sending Encoded Message
            socket.Send(sendingMessage);

            //Adding this message to the List box
            textStatus.Items.Add("Me : " + textMsg.Text);
            textStatus.Items.Add(Environment.NewLine);
            textMsg.Text = "";
        }
    }
}
