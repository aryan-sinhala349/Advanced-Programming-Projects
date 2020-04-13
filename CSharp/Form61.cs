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
    public partial class Form61 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public Form61()
        {
            InitializeComponent();
        }

        private void Form61_Load(object sender, EventArgs e)
        {
            fbd.Description = "Select a directory to move the file to.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK && fbd.ShowDialog() == DialogResult.OK)
            {
                File.Move(ofd.FileName, fbd.SelectedPath + "\\" + ofd.SafeFileName); ;
                MessageBox.Show("Moved \'" + ofd.FileName + "\' to \'" + fbd.SelectedPath + "\\" + ofd.SafeFileName + "\'");
            }
        }
    }
}
