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

namespace 音樂播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "請選擇音樂文件";
            openFileDialog.InitialDirectory = @"E:\Music";
            openFileDialog.Filter = "所有文件|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            string[] path = openFileDialog.FileNames;
            
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i]));
                list.Add(path[i]);
            }

        }
        List<string> list = new List<string>();

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           
            sp.SoundLocation = list[listBox1.SelectedIndex];
            sp.Play();
        }
         SoundPlayer sp = new SoundPlayer();
        private void button3_Click(object sender, EventArgs e)
        {
            //下一曲
            int index = listBox1.SelectedIndex;
            index++;
            if(index == listBox1.Items.Count)
            {
                index = 0;
            }
            //將改變後的索引給當前選到的索引
            listBox1.SelectedIndex = index;
            sp.SoundLocation = list[index];
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count-1;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = list[index];
            sp.Play();
        }
    }
}
