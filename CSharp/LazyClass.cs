using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    abstract class LazyClass
    {
        public static string Name = "Adam";
        public static int Age = 15;

        public static void Message(string message)
        {
            MessageBox.Show(message);
        }

        public abstract void ShowMessage(string message);
    }

    class LazyClassTwo : LazyClass
    {
        public override void ShowMessage(string message)
        {
            Message(message);
        }
    }
}
