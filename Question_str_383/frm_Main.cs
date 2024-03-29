﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_str_383
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();

            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            if (a.Contains("three"))
                a.Add("four");

            a.RemoveAt(2);

            if (a.IndexOf("four") != 4) a.Add(fourth);

            printL(a);
                        
        }

        public void printL (List<string> a)
        {
            string result = "";                        

            foreach (string element in a)
            {
                result += "\n" + element;
            }

            MessageBox.Show(result);
        }
    }
}
