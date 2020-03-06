using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNamespace;

namespace AdvancedProgrammingCSharp
{
    public partial class Form27 : Form
    {
        MyClass mc = new MyClass();

        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
                MessageBox.Show(mc[i], "mc[" + i + "]");

            mc[0] = "Jonathan";
            mc[1] = "Joeseph";
            mc[2] = "Jotaro";

            for (int i = 0; i < 3; ++i)
                MessageBox.Show(mc[i], "mc[" + i + "]");
        }
    }
}
