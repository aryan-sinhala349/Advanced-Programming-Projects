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
    public partial class Form42 : Form
    {
        string path;

        public Form42()
        {
            InitializeComponent();
        }

        private void Form42_Load(object sender, EventArgs e)
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
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            br.BaseStream.Position = 0x11;
            byte[] buffer = br.ReadBytes(4);
            Array.Reverse(buffer);
            buffer = BitConverter.GetBytes(4312);
            br.Dispose();
        }
    }
}
