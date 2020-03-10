using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using People;

namespace AdvancedProgrammingCSharp
{
    public partial class Form32 : Form
    {
        NewPerson np = new NewPerson();
        Random r = new Random();

        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            np.OnPropertyChanged += new EventHandler(np_OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";

            name += (char)r.Next('A', ('Z' + 1));

            for (int i = 0; i < r.Next(9); ++i)
                name += (char)r.Next('a', ('z' + 1));

            np.Name = name;
        }

        private void np_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You changed the property of a new person to " + np.Name);
        }
    }
}
