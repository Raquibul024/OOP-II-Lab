using Calculate_CGPA.GradePoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_CGPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //all reset

            markSP.Clear();
            markTOC.Clear();
            markDT.Clear();
            markOS.Clear();
            markOSL.Clear();
            markADBMS.Clear();
            markADBMSL.Clear();
            markOOPL.Clear();
            markNAL.Clear();

            pointSP.Clear();
            pointTOC.Clear();
            pointDT.Clear();
            pointOS.Clear();
            pointOSL.Clear();
            pointADBMS.Clear();
            pointADBMSL.Clear();
            pointOOPL.Clear();
            pointNAL.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, num5, num6, num7, num8, num9;

            num1 = Convert.ToInt32(markSP.Text);
            num2 = Convert.ToInt32(markTOC.Text);
            num3 = Convert.ToInt32(markDT.Text);
            num4 = Convert.ToInt32(markOS.Text);
            num5 = Convert.ToInt32(markOSL.Text);
            num6 = Convert.ToInt32(markADBMS.Text);
            num7 = Convert.ToInt32(markADBMSL.Text);
            num8 = Convert.ToInt32(markOOPL.Text);
            num9 = Convert.ToInt32(markNAL.Text);


            //Invidual Course grade point
            pointSP.Text = Grade.gradePoint(num1).ToString();
            pointTOC.Text = Grade.gradePoint(num2).ToString();
            pointDT.Text = Grade.gradePoint(num3).ToString();
            pointOS.Text = Grade.gradePoint(num4).ToString();
            pointOSL.Text = Grade.gradePoint(num5).ToString();
            pointADBMS.Text = Grade.gradePoint(num6).ToString();
            pointADBMSL.Text = Grade.gradePoint(num7).ToString();
            pointOOPL.Text = Grade.gradePoint(num8).ToString();
            pointNAL.Text = Grade.gradePoint(num9).ToString();

            //credit * grade point
            double sp=double.Parse(creditSP.Text) * Grade.gradePoint(num1);
            double toc = double.Parse(creditTOC.Text) * Grade.gradePoint(num1);
            double dt = double.Parse(creditDT.Text) * Grade.gradePoint(num1);
            double os = double.Parse(creditOS.Text) * Grade.gradePoint(num1);
            double osl = double.Parse(creditOSL.Text) * Grade.gradePoint(num1);
            double adbms = double.Parse(creditADBMS.Text) * Grade.gradePoint(num1);
            double adbmsl = double.Parse(creditADBMSL.Text) * Grade.gradePoint(num1);
            double oopl = double.Parse(creditOOPL.Text) * Grade.gradePoint(num1);
            double nal = double.Parse(creditNAL.Text) * Grade.gradePoint(num1);

            //GPA
            double total= (sp+toc+dt+os+osl+adbms+adbmsl+oopl+nal);
            gpa = 'total' / 20;

        }
    }
}
