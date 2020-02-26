using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sinha.Tutorial22;

namespace AdvancedProgrammingCSharp
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial22Class.ShowMessage("This is without a title");
            Tutorial22Class.ShowMessage("This is with a title", "I've put a title here");
        }
    }
}
