﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerInfo.WMI;
using ComputerInfo.Set;
using ComputerInfo.Define;
using System.IO;

namespace ComIn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Upload.UploadSetting();

            Console.WriteLine(Untill.CPU_Current_Clock);
        }
    }
}
