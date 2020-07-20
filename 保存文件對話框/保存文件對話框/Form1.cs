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

namespace 保存文件對話框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "請選擇要保存的文件";
            sfd.InitialDirectory = @"C:\Users\k2lairrol\Desktop\";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using(FileStream fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");

        }
    }
}
