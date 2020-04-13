﻿using System;
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
    public partial class Form55 : Form
    {
        Random r = new Random();
        readonly char[] letters = "1234567980qwertyuiopasdfghjklzxcvbnm".ToCharArray();

        public Form55()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string randomString = "";
            for (int i = 0; i < 10; i++) randomString += letters[r.Next(0, letters.Length - 1)].ToString();
            MessageBox.Show(randomString);
        }
    }
}
