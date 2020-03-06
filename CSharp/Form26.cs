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
    public partial class Form26 : Form
    {
        Person person = new Person();
        Worker worker = new Worker();
        IPolitician politician = new Politician();

        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person.ShowInfo();
            worker.ShowInfo();
            politician.Advertise();
        }
    }
}
