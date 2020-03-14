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
    public partial class Form47 : Form
    {
        public Form47()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control myControl = button1;
            object myObj = "Hello";
            if (myObj is string)
            {
                string myString = myObj as string;
                MessageBox.Show(myString);
            }
        }
    }
}
