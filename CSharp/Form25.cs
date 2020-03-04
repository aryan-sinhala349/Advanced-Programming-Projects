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
    public partial class Form25 : Form
    {
        Person person = new Person("Bob", 30);
        Worker worker = new Worker("Bob", 30, 20000);

        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person.ShowInfo();
            worker.ShowInfo();
        }
    }
}
