﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Label lab6;
        public Label lab7;
        public Label lab8;
        public Label lab9;
        public Label lab10;
        public Label lab12;

        public Form2()
        {
            InitializeComponent();
            Instance = this;
            lab6 = label6;
            lab7 = label7;
            lab8 = label8;
            lab9 = label9;
            lab10 = label10;
            lab12 = label12;

        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
        // label6.Text = Form1.cb1text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
