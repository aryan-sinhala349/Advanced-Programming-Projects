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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = checkBox1.Checked ? 9 : 3;
            int b = 6;

            if (i >= b)
                MessageBox.Show("I is greater than or equal to B.");
            else
                MessageBox.Show("I is less than B.");
        }
    }
}
