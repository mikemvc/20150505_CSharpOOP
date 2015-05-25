﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150519_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 變數宣告
            //int i;
            //i = 10;
            //int i = 10;

            // 陣列宣告
            //int[] score;
            //score = new int[3];

            int[] score = new int[3];  // 三個，編號分別是: 0, 1, 2

            // score[3] = 100;  // System.IndexOutOfRangeException: 索引在陣列的界限之外。

            button1.Text = score[0].ToString();  // 陣列的初值為「零值」
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] score = new int[] { 90, 91, 92, 93, 94, 95 };

            int iLastIndex = score.Length - 1;
            this.Text = iLastIndex.ToString();

            button2.Text = score[iLastIndex].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] score = new int[] { 90, 91, 92, 93, 94, 95 };

            //int iTotal = 0;
            //for (int i = 0; i < score.Length; i++)
            //{
            //    int x = score[i];
            //    listBox1.Items.Add(x);
            //    iTotal += x;
            //}
            //button3.Text = iTotal.ToString();
            
            // 使用foreach列出陣列的內容
            listBox1.Items.Clear();
            int i = 5;
            foreach (int x in score)
            {
                score[i] = 100;
                listBox1.Items.Add(x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // listBox1.Items.Clear();
            // listBox1.Items.RemoveAt(2);

            // ?!
            //for (int i = 0; i < listBox1.Items.Count; i++) {
            //    listBox1.Items.RemoveAt(i);
            //}

            // 刪除陣列元素，最好從後面開始移除
            int iCount = listBox1.Items.Count;
            for (int i = iCount - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(i);
            }
        }
    }
}
