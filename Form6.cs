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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter your name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Matthew"))
                MessageBox.Show("Hello Matthew!");
            else if (textBox1.Text.Contains("Aryan"))
                MessageBox.Show("Hello Aryan!");
            else
                MessageBox.Show("Sorry, I haven't heard that name before! Hello " + textBox1.Text + "!");
        }
    }
}
