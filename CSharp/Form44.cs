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
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }
        private void Form44_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "My Text File";
            sfd.Title = "Save Text File";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write("Example text file.");
                bw.Dispose();
            }
        }

    }
}
