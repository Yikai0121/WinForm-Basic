using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字體和顏色對話框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            textBox1.Font =  font.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog co = new ColorDialog();
            co.ShowDialog();
            textBox1.ForeColor = co.Color;
        }
    }
}
