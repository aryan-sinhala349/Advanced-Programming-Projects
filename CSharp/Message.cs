using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    class Message
    {
        delegate void MyDelegate(string myString);

        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage);
            md += ShowAnotherMessage;
            md("Adam");
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowAnotherMessage(string message)
        {
            MessageBox.Show(message, "Test");
        }
    }
}
