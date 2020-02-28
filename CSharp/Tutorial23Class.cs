using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProgrammingCSharp
{
    class Tutorial23Class
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "") MessageBox.Show("You can't set the name to \"\"", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name = value;
            }
        }

        public Tutorial23Class(string name)
        {
            this.name = name;
        }
    }
}
