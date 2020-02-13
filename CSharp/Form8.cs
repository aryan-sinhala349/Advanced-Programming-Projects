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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Comforter Clash" || textBox1.Text == "Futon Fight" || textBox1.Text == "Mattress Melee") && checkBox1.Checked)
                MessageBox.Show("It's not a Bedwars clone", textBox1.Text);
            else
                MessageBox.Show("Sounds like a Bedwars clone", textBox1.Text);
        }
    }
}
