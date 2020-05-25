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
    public partial class Group4 : Form
    {
        public Group4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textsum.Text);
            int outcome1;
            {
                outcome1 = ((month * 10) / 100);
                textBox2.Text = outcome1.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int edu = int.Parse(textBox3.Text);
            int sport = int.Parse(textBox4.Text);
            int hos = int.Parse(textBox5.Text);
            int sata = int.Parse(textBox6.Text);
            int outcome2;
            {
                outcome2 = ((edu*2) + (sport*2) + (hos*2) + (sata*2));
                textBox7.Text = outcome2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tan = int.Parse(textBox8.Text);
            int outok = int.Parse(textBox9.Text);
            int pak = int.Parse(numericUpDown1.Text);
            int outcome3;
            {
                outcome3 = tan + outok + pak;
                textBox10.Text = outcome3.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tan1 = int.Parse(textBox7.Text);
            int tan2 = int.Parse(textBox10.Text);
            int moneyten = int.Parse(textBox2.Text);
            int sumall = int.Parse(textsum.Text);
            int outcome4;
            int outcomesum;
            int tan = 0;
            if ((tan1 + tan2) > moneyten)
            {
                tan = tan+moneyten;
            }
            else if ((tan1 + tan2) < moneyten)
            {
                tan = tan1 + tan2;
            }
            {
                outcome4 = tan;
                textBox11.Text = outcome4.ToString();
                outcomesum = sumall - tan;
                textBox13.Text = outcomesum.ToString();
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Group3 tree = new Group3();
            tree.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Group5 one = new Group5();
            one.textsum.Text = textBox13.Text;
            one.Show();
        }
    }
}
