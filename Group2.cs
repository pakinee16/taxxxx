using System;
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
    public partial class Group2 : Form
    {
        public Group2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDown7.Enabled = true;
            }
            else
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                numericUpDown7.Enabled = false;
            }
            else
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDown1.Text);
            int b = int.Parse(numericUpDown2.Text);
            int c = int.Parse(numericUpDown3.Text);
            int d = int.Parse(numericUpDown4.Text);
            int ea = int.Parse(numericUpDown5.Text);
            int f = int.Parse(numericUpDown6.Text);
            int n = int.Parse(numericUpDown7.Text);
            int sumall = int.Parse(textsum.Text);
            int k = 0;
            int outcome;
            int outcome2;
            if ((b + c) > 100000)
            {
                k = 100000;
            }
            else if ((b + c) < 100000)
            {
                k = b + c;
            }

            {
                outcome = (a + k + d + ea + n + f);
                textBox5.Text = outcome.ToString();
                outcome2 = sumall - (a + k + d + ea + n + f);
                textBox1.Text = outcome2.ToString();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Group1 one = new Group1();
            one.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Group3 two = new Group3();
            two.textsum.Text = textBox1.Text;
            two.Show();
        }
    }
}
