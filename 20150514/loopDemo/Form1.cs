﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loopDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 將listBox1 新增一個Item
            string sUserKeyin = textBox1.Text;
            listBox1.Items.Add(sUserKeyin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items[0] = "AAA";
            listBox1.Items.Remove("C");

        }
    }
}
