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
    public partial class Form11 : Form
    {
        string[] outcomes =
        {
            "This is string one!",
            "This is string two!",
            "This is string three!",
            "This is string four!",
            "This is string five!",
            "This is string six!",
            "This is string seven!",
            "This is string eight!",
            "This is string nine!",
            "This is string ten!"
        };

        Random r = new Random();

        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = r.Next(10);

            MessageBox.Show(outcomes[index], "Random string!");
        }
    }
}
