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
    public partial class Form10 : Form
    {
        int count = 0;

        public Form10()
        {
            InitializeComponent();
            button1.Text = "Count: " + (count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Count: " + (++count);
        }
    }
}
