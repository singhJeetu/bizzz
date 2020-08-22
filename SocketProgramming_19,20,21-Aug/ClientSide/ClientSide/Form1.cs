using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace ClientSide
{
    public partial class Form1 : Form
    {
        TcpClient client = null;
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 8888);
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);

            txtServerMessage.Text = "Server >> " + sr.ReadLine();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                NetworkStream ns = client.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine(txtMessage.Text);

                sw.Flush();
                sw.Close();
                ns.Close();
            }
        }

    }
}