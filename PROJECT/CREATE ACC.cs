﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            INTRO f4 = new INTRO();
            f4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f3 = new Form12();
            f3.Show();
            this.Hide();
        }
    }
}
