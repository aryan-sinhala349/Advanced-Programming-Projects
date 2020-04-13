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
    public partial class Form60 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();

        public Form60()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK) File.Delete(ofd.FileName);
        }
    }
}
