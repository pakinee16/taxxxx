﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Group3 : Form
    {
        public Group3()
        {
            InitializeComponent();
        }

        private void Group3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int property2558 = int.Parse(numericUpDown2.Text);
            int taxhouse = int.Parse(numericUpDown1.Text);
            int outcome2558;
            int outcome4;
            int outcomefinal2558;
            int outcomesum;
            int sumall = int.Parse(textsum.Text);
            {
                outcome2558 = (property2558 * 20) / 100;
                textBox1.Text = outcome2558.ToString();
                outcome4 = (outcome2558 * 4) / 20;
                textBox2.Text = outcome4.ToString();
                outcomefinal2558 = (taxhouse + outcome4);
                textBox5.Text = outcomefinal2558.ToString();
                outcomesum = sumall - (taxhouse + outcome4);
                textBox3.Text = outcomesum.ToString();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int property = int.Parse(numericUpDown3.Text);
            int taxhouse = int.Parse(numericUpDown1.Text);
            int outcome2562;
            int sumall = int.Parse(textsum.Text);
            int outcomefinal2562;
            int outcomesum;
            int a = 0;
            if (property <= 5000000)
            {
                a = 200000;
            }
            else if (property > 5000000)
            {
                a = 0;
            }
            else if (property < 200000)
            {
                a = 0;
            }
            outcome2562 = a;
            textBox4.Text = outcome2562.ToString();
            outcomefinal2562 = taxhouse + a;
            textBox5.Text = outcomefinal2562.ToString();
            outcomesum = sumall - (taxhouse + a);
            textBox3.Text = outcomesum.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           
            {

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Group2 two = new Group2();
            two.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Group4 two = new Group4();
            two.textsum.Text = textBox3.Text;
            two.Show();
        }
    }
}
