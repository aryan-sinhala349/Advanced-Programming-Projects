using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProgrammingCSharp
{
    public partial class Form56 : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public Form56()
        {
            InitializeComponent();
            fbd.Description = "Select a folder to see the path";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK) MessageBox.Show(fbd.SelectedPath);
        }
    }
}
