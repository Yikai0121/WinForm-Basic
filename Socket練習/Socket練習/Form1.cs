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

namespace Socket練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)


        {
            try
            {
                //創建一個負責監聽的socket
                Socket socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //創建IP地址和端口號對象
                IPAddress ip = IPAddress.Any;
                //讓負責監聽的socket綁定IP地址和Port
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //監聽
                socketwatch.Bind(point);

                ShowMsg("監聽成功");
                //限制數量
                socketwatch.Listen(10);
                //等待客戶端連結


                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketwatch);
            }
            catch 
            {

                
            }
           

        }
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            try
            {
                while (true)
                {

                    //客戶端連接成功後，服務氣應該接受客戶端發的消息
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
            }
            catch 
            {

                
            }
           
        }
        Socket socketSend;
        //將遠端連結客戶的IP、socket存入集合中
        Dictionary<string, Socket> disSocket = new Dictionary<string, Socket>();
        //等待客戶端連結並創建與之通信用socket
        void Listen(object o)
        {
            Socket socketwatch = o as Socket;
            //等待客戶端連接，並創建一個負責通信socket
            
                while (true)
                {
                    try
                    {
                        //負責跟客戶端通信的Socket
                        socketSend = socketwatch.Accept();
                        disSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                        cbousers.Items.Add(socketSend.RemoteEndPoint.ToString());

                        ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "連接成功");

                        Thread th = new Thread(Recive)
                        {
                            IsBackground = true
                        };
                        th.Start(socketSend);
                    }
                    catch
                    {

                   
                    }
                
                }
            
          
            
        }
           

        void ShowMsg(string str)
        {
            try
            {
                txtLog.AppendText(str + "\r\n");
            }
            catch (Exception)
            {

               
            }
            
        }

        private void txtServer_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();
            //獲得用戶在下拉框選的地址
            string ip = cbousers.SelectedItem.ToString();
            disSocket[ip].Send(newBuffer);
            
           // socketSend.Send(buffer);
        }

        //選擇發送問件
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\k2lairrol\Desktop";
            ofd.Title = "請選擇要發送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            txtpath.Text =  ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            //獲得要發送文件
            string path = txtpath.Text;
            using(FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                //傳送首個字節為1當作傳送文件判斷
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                disSocket[cbousers.SelectedItem.ToString()].Send(newbuffer, 0,r,SocketFlags.None);
                
            }
        }
    }
}
