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
    public partial class Group1 : Form
    {
        public Group1()
        {
            InitializeComponent();
        }


        private void textsum_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = int.Parse(numericUpDown1.Text);
            int g = int.Parse(numericUpDown2.Text);
            int h = int.Parse(numericUpDown3.Text);
            int i = int.Parse(numericUpDown4.Text);
            int sumall = int.Parse(textsum.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int ex = 0;
            int outcome1;
            int outcome2;
            if (radioButton5.Checked == true)
            {
                a = a + 60000;
            }
            if (checkBox1.Checked == true)
            {
                b = b + 30000;
            }
            if (checkBox2.Checked == true)
            {
                c = c + 30000;
            }
            if (checkBox3.Checked == true)
            {
                d = d + 30000;
            }
            if (checkBox4.Checked == true)
            {
                ex = ex + 30000;
            }

            f = f * 30000;
            g = g * 60000;
            i = i * 60000;
            {
                outcome1 = a + b + c + ex + f + g + i + h + d;
                textBox5.Text = outcome1.ToString();
                outcome2= sumall- (a + b + c + ex + f + g + i + h + d);
                textBox6.Text = outcome2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Group1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            home cen = new home();
            cen.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Group2 two = new Group2();
            two.textsum.Text = textBox6.Text;
            two.Show();
        }
    }
}
