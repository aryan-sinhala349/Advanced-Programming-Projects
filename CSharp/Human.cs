using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    partial class Human
    {
        public string Name = "Mr. Smith";
        public int Age = 38;

        partial void Message(string message);
    }

    partial class Human
    {
        public string HairColor = "Brown";
        public bool Glasses = false;

        partial void Message(string message)
        {
            MessageBox.Show(message, Name);
        }

        public void ShowMessage(string message)
        {
            Message(message);
        }
    }
}
