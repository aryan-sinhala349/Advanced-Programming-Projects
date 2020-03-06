using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    struct Client : IClient
    {
        public string Name;
        public int Age;

        public Client(string name = "Adam", int age = 15)
        {
            Name = name;
            Age = age;
        }

        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;
        }
    }

    interface IClient
    {
        void ClearClientInfo();
    }
}
