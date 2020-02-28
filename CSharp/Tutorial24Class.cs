using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgrammingCSharp
{
    class Tutorial24Class
    {
        private static Exception emptyString = new Exception("That is an empty string!");

        public static void CheckString(string value)
        {
            if (value == "") throw emptyString;
        }
    }
}
