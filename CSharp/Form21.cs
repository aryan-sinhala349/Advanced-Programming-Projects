using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sinha.Tutorial21;

namespace AdvancedProgrammingCSharp
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial21Class t21c = new Tutorial21Class("Aryan");
            MessageBox.Show(t21c.name);
            Tutorial21Class.HowManyNames();
        }
    }
}
