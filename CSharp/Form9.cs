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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "Aryan":
                    MessageBox.Show("My name is Aryan as well!", "There can only be one");
                    break;

                case "Logitech Bad":
                    MessageBox.Show("I disagree with you. I personally love Logitech, especially their Logtech GPro wired keyboard with Romer G Tactile switches, but they are also well known for their G502 Mouse.", "You are very very wrong.");
                    break;

                case "Logitech Good":
                    MessageBox.Show("Yes", "Yes");
                    break;

                default:
                    MessageBox.Show("You don't have anything interesting to say, do you?", "You said \"" + textBox1.Text + "\"");
                    break;
            }
        }
    }
}