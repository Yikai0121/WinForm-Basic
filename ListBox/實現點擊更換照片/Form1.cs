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


namespace 實現點擊更換照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < path.Length; i++)
            {
               string filename = Path.GetFileName(path[i]);
                listBox1.Items.Add(filename);
                   
            }
        }
        string[] path = Directory.GetFiles(@"C:\Users\k2lairrol\Pictures\Pictures");
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile(path[listBox1.SelectedIndex]);
        }
    }
}
