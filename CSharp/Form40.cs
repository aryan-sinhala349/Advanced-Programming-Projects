﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdvancedProgrammingCSharp
{
    public partial class Form40 : Form
    {
        string path;

        public Form40()
        {
            InitializeComponent();
        }

        private void Form40_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.BaseStream.Position = 0x2B;
            byte[] buffer = { 0x08, 0x09, 0x0A };
            sw.BaseStream.Write(buffer, 0, 3);
            sw.Dispose();
        }
    }
}
