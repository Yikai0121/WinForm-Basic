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

namespace 記事本練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打開紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //取消自動換行
            textBox1.WordWrap = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 顯示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隱藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 打開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "請選擇要打開的文件";
            ofd.InitialDirectory = @"C:\Users\k2lairrol\Desktop\";
            ofd.Filter = "文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();


            //獲得文件路徑
            string path =ofd.FileName;
            string filename = Path.GetFileName(path);
            listBox1.Items.Add(filename);
            if (path == "")
            {
                return;
            }
            using (FileStream fopen = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fopen.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);

            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "請選擇要保存的文件";
            sfd.Filter = "所有文件|*.*";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }

            using(FileStream fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fswrite.Write(buffer, 0, buffer.Length);


            }
            MessageBox.Show("保存成功");
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自動換行ToolStripMenuItem.Text == "自動換行")
            {
                textBox1.WordWrap = true;
                自動換行ToolStripMenuItem.Text = "取消自動換行";
            }
            else if(自動換行ToolStripMenuItem.Text == "取消自動換行")
            {
                textBox1.WordWrap = false;
                自動換行ToolStripMenuItem.Text = "自動換行";
            }
        }

        private void 字體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            textBox1.Font = font.Font;
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox1.ForeColor = color.Color;
        }
    }
}
