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
    public partial class Form28 : Form
    {
        Client[] clients = { new Client("Adam", 15), new Client("Jotaro Kujo", 17), new Client("Giorno Giovanna", 15), new Client("Noriaki Kakyoin", 17) };

        public Form28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clients.Length; ++i)
                MessageBox.Show(clients[i].Name + ", " + clients[i].Age, "Client " + (i + 1));

            for (int i = 0; i < clients.Length; ++i)
                clients[i].ClearClientInfo();

            for (int i = 0; i < clients.Length; ++i)
                MessageBox.Show(clients[i].Name + ", " + clients[i].Age, "Client " + (i + 1));
        }
    }
}
