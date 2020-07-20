using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 愛不愛小練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("愛你");
            this.Close();
        }

        private void btnunlove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("厲害了!");
            this.Close();
        }

        private void btnunlove_MouseEnter(object sender, EventArgs e)
        {
            //給按鈕新座標
            //這個按鈕活動的最大寬度就是 窗體的寬度減去按鈕的寬度
            int x = this.ClientSize.Width - btnlove.Width;
            int y = this.ClientSize.Height - btnlove.Height;
            Random r = new Random();
            //給按鈕一個隨機座標
            btnunlove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
           
        }
    }
}
