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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LazyClassTwo lc2 = new LazyClassTwo();
            lc2.ShowMessage("Oingo Boingo Brothers");
        }
    }
}
