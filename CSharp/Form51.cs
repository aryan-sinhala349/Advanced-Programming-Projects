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
    public partial class Form51 : Form
    {
        public Form51()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = "Hello, my name is Adam. Hello!";
            string after = sentence.Replace("Hello", "Hi");
            MessageBox.Show(after, sentence);
        }
    }
}
