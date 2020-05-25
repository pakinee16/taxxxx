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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int pasee = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            int sums = 0;
            if ((((month*12)+pasee+other)*50/100)>100000)
            {
                sums = (((month * 12) + pasee + other)-100000);
            }
            else if ((((month * 12) + pasee + other) *50 /100) <= 100000)
            {
                sums = ((month * 12) + pasee + other) * 50 / 100;
            }
            {
                outcome = sums;
                text1.Text = outcome.ToString();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group1 one = new Group1();
            one.textsum.Text = text1.Text;
            one.Show();

        }
    }
}
