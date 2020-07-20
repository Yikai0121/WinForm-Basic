using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鬧鐘小練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbltime.Text = DateTime.Now.ToString();

            //叫我起床
            if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 50 && DateTime.Now.Second == 20)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"";//放音樂位置
                sp.Play();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbltime.Text = DateTime.Now.ToString();
        }
    }
}
