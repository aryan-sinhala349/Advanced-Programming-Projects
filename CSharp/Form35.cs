using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProgrammingCSharp
{
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte myByte = 255;
            short myShort = 0;
            Int16 int16 = myShort;
            uint myInt = 0;
            UInt32 myInt32 = myInt;
            ulong myLong = 0;
            UInt64 myInt64 = myLong;

            float myFloat = 0.5f;
            double d = 3.14159265358979;

            char c = 'd';
        }
    }
}
