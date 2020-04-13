using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdvancedProgrammingCSharp
{
    public partial class Form64 : Form
    {
        public Form64()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcessesByName("Chrome"))
                MessageBox.Show(p.ProcessName);
        }
    }
}
