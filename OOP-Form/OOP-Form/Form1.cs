using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);
            double div = text1 / text2;
            textBox3.Text = div.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);
            double sum = text1 + text2;
            textBox3.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);
            double sub = text1 - text2;
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);
            double mul = text1 * text2;
            textBox3.Text = mul.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(textBox1.Text);
            double text2 = Convert.ToDouble(textBox2.Text);
            double mod = text1 % text2;
            textBox3.Text = mod.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
