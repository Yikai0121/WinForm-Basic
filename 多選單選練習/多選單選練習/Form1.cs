using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多選單選練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdostudent.Checked || rdoteacher.Checked)
            {
                string name = textBox1.Text.Trim();
                string pwd = textBox2.Text;
                if (rdostudent.Checked)
                {
                    if (name == "student" && pwd == "student")
                    {
                        MessageBox.Show("學生登入成功");
                    }
                    else
                    {
                        MessageBox.Show("登入失敗");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                else
                {
                    if (name == "teacher" && pwd == "teacher")
                    {
                        MessageBox.Show("老師登入成功");
                    }
                    else
                    {
                        MessageBox.Show("登入失敗");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇身分");
            }
            
        }
    }
}
