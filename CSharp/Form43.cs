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

namespace AdvancedProgrammingCSharp
{
    public partial class Form43 : Form
    {
        string path;

        public Form43()
        {
            InitializeComponent();
        }

        private void Form43_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
            int myShort = 0x2345;
            byte[] buffer = BitConverter.GetBytes(myShort);
            Array.Reverse(buffer);
            bw.Write(buffer);
            bw.Dispose();
        }
    }
}
