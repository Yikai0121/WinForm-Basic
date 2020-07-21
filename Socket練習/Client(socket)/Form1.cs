using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_socket_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Receive()
        {
           
                while (true)
                {
                    try
                {
                            byte[] buffer = new byte[1024 * 1024 * 3];
                            int r = socketSend.Receive(buffer);

                            if (r == 0)
                            {
                                break;
                            }

                    if (buffer[0] == 0)
                    {

                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint + ":" + s);
                    }
                    else if (buffer[0]==1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\k2lairrol\Desktop";
                        sfd.Title = "請選擇要保存的文件";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using(FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");

                    }

                }
                     catch 
                        {

                    
                        }


            }
           
        }


        Socket socketSend;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //創建負責通信的socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtserver.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //獲得要連接的遠程服務器應用程序的IP地址和PORT
                socketSend.Connect(point);
                ShowMsg("連接成功");

                //接收服務端消息
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start();
            }
            catch 
            {

                
            }
           
        }
        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //客戶端給服務器發送消息
                string str = txtMsg.Text.Trim();
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                socketSend.Send(buffer);
            }
            catch
            {

            }   
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
