using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class NewPerson
    {
        public event EventHandler OnPropertyChanged;

        string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(this, new EventArgs());
            }
        }
    }
}
