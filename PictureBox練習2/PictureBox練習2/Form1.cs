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
using System.Media;

namespace PictureBox練習2
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
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Pictures\1.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Pictures\1.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Pictures\1.jpg");
            pictureBox4.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Pictures\1.jpg");
            pictureBox5.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Pictures\1.jpg");
            pictureBox6.Image = Image.FromFile(@"C:\Users\k2lairrol\Pictures\Pictures\1.jpg");

            SoundPlayer sp = new SoundPlayer(); //播音樂
            sp.SoundLocation = @"";
            sp.Play();
            
            
        }
        string[] path = Directory.GetFiles(@"C:\Users\k2lairrol\Pictures\Pictures");
        int i = 0;
        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length)]);
            pictureBox2.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[r.Next(0, path.Length)]);
        }
    }
}
