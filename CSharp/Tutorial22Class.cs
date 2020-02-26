using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinha
{
    namespace Tutorial22
    {
        static class Tutorial22Class
        {
            public static void ShowMessage(string message)
            {
                MessageBox.Show(message, "This is a default title");
            }

            public static void ShowMessage(string message, string caption)
            {
                MessageBox.Show(message, caption);
            }
        }
    }
}
