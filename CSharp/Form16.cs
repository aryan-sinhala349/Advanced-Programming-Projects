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
    public partial class Form16 : Form
    {
        Random r = new Random();

        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(generate(r.Next(104)).ToString() + " was your selected seed!", "Random Seed Generator");
        }

        private int generate(int tries)
        {
            MessageBox.Show("You have " + tries + " tries", "Random Seed Generator");

            int[] values = new int[tries];

            for (int i = 0; i < tries; i++)
            {
                int value = r.Next();
                values[i] = value;
            }

            MessageBox.Show(string.Join(", ", values), "Possible Seeds");

            int result = r.Next(tries);
            return values[result];
        }
    }
}
