using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbomon.Items.Add("一");
            cbomon.Items.Add("二");
            cbomon.Items.Add("三");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbomon.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //獲得當前年分
            int years = DateTime.Now.Year;
            for (int i = years - 1; i >= 1911; i--)
            {
                cboyear.Items.Add(i+"年");
            }
        }

        //當年份發生改變加載月份
        private void cbomon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbodays.Items.Clear();
            int days = 0;


            string  strmonth = cbomon.SelectedItem.ToString().Split(new char[] {'月'},StringSplitOptions.RemoveEmptyEntries)[0];

            string stryear = cboyear.SelectedItem.ToString().Split(new[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];

            int year = Convert.ToInt32(stryear);
            int month = Convert.ToInt32(strmonth);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 2:
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                default:
                    days = 30;
                    break;
            }
            for (int i = 0; i <= days; i++)
            {
                cbodays.Items.Add(i);
            }



        }

        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomon.Items.Clear();

            for (int i = 1; i < 12; i++)
            {
                cbomon.Items.Add(i + "月");
            }
        }
    }
}
