using System;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using myProxy.Util;
using System.Text;

namespace myProxy
{
    public partial class MyProxy : Form
    {
        private Socket socket;
        private Thread thread;
        public MyProxy()
        {
            InitializeComponent();
        }

        private void myProxy_Load(object sender, EventArgs e)
        {
            //默认指定ip
            var ipStringArr = IpUtil.GetIpList();
            if (ipStringArr.Length > 0)
            {
                int index = 0;
                for (int i = 0; i < ipStringArr.Length; i++)
                {
                    string t = ipStringArr[i];
                    comboBoxIp.Items.Add(t);
                    if (IpUtil.isIPV4(t))
                    {
                        index = i;
                    }
                }
                comboBoxIp.SelectedIndex = index;
            }
            //默认指定port
            textPort.Text = ConfigurationManager.AppSettings["defaultPort"];
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string ipStr = comboBoxIp.Text;
            IPAddress ipAddress = IPAddress.Parse(ipStr);
            int port = int.Parse(textPort.Text);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipEndPoint);
            socket.Listen(10);


            ThreadStart ts = new ThreadStart(Target);
            //开始用一个新的线程，接收信息
            thread = new Thread(ts);
            thread.Start();

            BtnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        public void Target()
        {

            while (true)
            {
                var accept = socket.Accept();

                var receiveBuffer = new byte[1024];
                accept.Receive(receiveBuffer);
                var strReceiveData = Encoding.ASCII.GetString(receiveBuffer);

                richTextBox1.Text = DateTime.Now.ToString() + @"\r" + strReceiveData;
                Thread.Sleep(1000);

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Abort();
            socket.Close();

            BtnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
