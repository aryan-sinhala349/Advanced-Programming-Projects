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
    public partial class Form59 : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public Form59()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Directory.Delete(fbd.SelectedPath);
                MessageBox.Show("Deleted \'" + fbd.SelectedPath + "\'");
            }
        }
    }
}
