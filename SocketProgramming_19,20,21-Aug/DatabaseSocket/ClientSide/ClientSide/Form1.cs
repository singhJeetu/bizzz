using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            TcpClient client = new TcpClient("127.0.0.1", 8000);
            NetworkStream ns = client.GetStream();

            StreamReader sr = new StreamReader(ns);
            DataTable dt = Deserialize(sr.ReadLine());

            dataGridView1.DataSource = dt;
        }
        private DataTable Deserialize(string json)
        {
            DataTable dt = new DataTable();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(dt.GetType());

            dt = ser.ReadObject(ms) as DataTable;
            return dt;
        }
    }
}