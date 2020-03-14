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
    public partial class Form52 : Form
    {
        public Form52()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] letters = alphabet.ToCharArray();
            foreach (char c in letters)
                MessageBox.Show(c.ToString());
        }
    }
}
