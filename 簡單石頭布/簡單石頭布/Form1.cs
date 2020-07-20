using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 簡單石頭布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstone_Click(object sender, EventArgs e)
        {
            string str = "石頭";
            PlayGame(str);
        }

        private void PlayGame(string str)
        {
            lblplayer.Text = str;
            Player player = new Player();
            int playnumber = player.ShowFist(str);

            Computer computer = new Computer();
            int computernum = computer.ShowFist();

            label4.Text = computer.Fist;

            Result res = Judge.Judgenum(playnumber, computernum);
            lblresault.Text = res.ToString();
        }

        private void btnsoccer_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
