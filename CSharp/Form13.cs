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
    public partial class Form13 : Form
    {
        List<int> nums = new List<int>();
        Random r = new Random();

        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nums.Add(r.Next(1, 11));

            foreach (int i in nums)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
