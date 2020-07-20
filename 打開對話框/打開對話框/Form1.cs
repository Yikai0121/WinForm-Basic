using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打開對話框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //點擊彈出對話框
            OpenFileDialog ofd = new OpenFileDialog();
            //標題
            ofd.Title = "請選擇要打開的文件";
            //多選
            ofd.Multiselect = true ;
            //初始位置
            ofd.InitialDirectory = @"C:\Users\k2lairrol\Desktop\";
            //設置對話框文件類型
            ofd.Filter = "文本文件|*.txt|圖片|*.jpg|所有文件|*.*";
            //展示對話框
            ofd.ShowDialog();


            //獲得打開對話框的文件路徑
            
            string path =ofd.FileName;
            if (path=="")
            {
                return;
            }
            using(FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];

                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text =  Encoding.Default.GetString(buffer, 0, r);
            }


        }
    }
}
