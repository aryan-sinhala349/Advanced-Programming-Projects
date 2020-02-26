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
    public partial class Form17 : Form
    {
        Random r = new Random();

        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = r.Next(10);
            MessageBox.Show(Odd(i) ? "Yes." : "No.", "Is " + i + " odd?");
        }
        
        bool Odd(int value)
        {
            return value % 2 == 1;
        }
    }
}
