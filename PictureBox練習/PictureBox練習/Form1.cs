using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureBox練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)

        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Saved Pictures\1.jpg");
            //獲得指定文件夾全部路徑
            
        }
        int i = 0;
        string[] path = Directory.GetFiles(@"C:\Users\k2lairrol\Pictures\Pictures");
        private void Nextbtn_Click(object sender, EventArgs e)
        {
           
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);

        }

        private void Topbtn_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);

        }
    }
}
