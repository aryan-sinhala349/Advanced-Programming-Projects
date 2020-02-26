using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sinha.Tutorial20;

namespace AdvancedProgrammingCSharp
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial20Class t2c = new Tutorial20Class("Aryan");

            MessageBox.Show(t2c.name, "What is my name?");
        }
    }
}
