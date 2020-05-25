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
    public partial class sums : Form
    {
        public sums()
        {
            InitializeComponent();
        }

        private void sums_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            int pasee = int.Parse(textsum.Text);
            if (pasee > 5000000)
            {
                pasee = ((pasee * 35) / 100);
            }
            else if (pasee > 2000000)
            {
                pasee = ((pasee * 30) / 100);
            }
            else if (pasee > 1000000)
            {
                pasee = ((pasee * 25) / 100);
            }
            else if (pasee > 750000)
            {
                pasee = ((pasee * 20) / 100);
            }
            else if (pasee > 500000)
            {
                pasee = ((pasee * 15) / 100);
            }
            else if (pasee > 300000)
            {
                pasee = ((pasee * 10) / 100);
            }
            else if (pasee > 150000)
            {
                pasee = ((pasee * 5) / 100);
            }
            else
            {
                pasee = 0;
            }
            textBox1.Text = pasee.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Group5 five = new Group5();
            five.Show();
        }
    }
}
