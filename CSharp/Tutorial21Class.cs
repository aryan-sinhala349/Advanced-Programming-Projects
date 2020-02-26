using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinha
{
    namespace Tutorial21
    {
        class Tutorial21Class
        {
            public string name { get; set; }
            public static int numNames { get; private set; }

            public Tutorial21Class(string name = "")
            {
                this.name = name;
                ++numNames;
            }

            public static void HowManyNames()
            {
                MessageBox.Show(numNames.ToString(), "You have created this many names");
            }
        }
    }
}
