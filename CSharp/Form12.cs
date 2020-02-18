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
    public partial class Form12 : Form
    {
        List<int> nums = new List<int>();
        Random r = new Random();

        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nums.Add(r.Next(1, 11));
            MessageBox.Show("Here: " + string.Join(", ", nums), "Nums as a string!");
        }
    }
}
