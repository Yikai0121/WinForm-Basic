using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多線程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //前台線程:只有所有的前台線程都關閉才能完成程序關閉
            //後台線程:只有所有前台線程結束，後台線程自動結束
            //創建一個線程去執行這個方法
            //前台線程
             th = new Thread(Test);
            //由標記這個線程，可以隨時被執行，具體甚麼時候質性看Cpu
            //設置為後台線程
            th.IsBackground = true;
            th.Start();
        }
        private void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);
                textBox1.Text = i.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //.net 不支援跨線程
            //取消跨線程訪問
            //control 為winform的基類
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th == null)
            {
                th.Abort();
            }
        }
    }

}
