using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox3.Text = textBox1.Text;
            textBox4.Text = textBox1.Text;
            textBox5.Text = textBox1.Text;
            textBox6.Text = textBox1.Text;
            textBox7.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(textBox2.Text);
            x += 2;
            textBox2.Text = x.ToString();

            x = int.Parse(textBox3.Text);
            x += 2;
            textBox3.Text = x.ToString();

            x = int.Parse(textBox4.Text);
            x += 2;
            textBox4.Text = x.ToString();

            x = int.Parse(textBox5.Text);
            x += 2;
            textBox5.Text = x.ToString();

            x = int.Parse(textBox6.Text);
            x += 2;
            textBox6.Text = x.ToString();

            x = int.Parse(textBox7.Text);
            x += 2;
            textBox7.Text = x.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            textBox3.ForeColor = Color.Green;
            textBox4.ForeColor = Color.Orange;
            textBox5.ForeColor = Color.Black;
            textBox6.ForeColor = Color.Blue;
            textBox7.ForeColor = Color.Pink;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s;
            s = int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text);
            label2.Text = s.ToString();
        }
    }
}
