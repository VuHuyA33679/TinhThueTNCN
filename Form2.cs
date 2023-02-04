using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhThue
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path = "output.txt";
            StreamReader file1 = new StreamReader(path);
            String str = file1.ReadToEnd();
            textBoxKetQuaQuyetToan.Text = str;
            file1.Close();

        }
    }
}
