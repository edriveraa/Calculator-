using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {
        Class1 calc = new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DisplayNumber("1");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            DisplayNumber("2");
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            DisplayNumber("3");
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            DisplayNumber("4");
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            DisplayNumber("5");
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            DisplayNumber("6");
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            DisplayNumber("7");
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            DisplayNumber("8");
        }
        private void Button9_Click(object sender, EventArgs e)
        {
           DisplayNumber("9");
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            DisplayNumber("0");
        }
        private void Buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Buttondot_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }
        private void Buttonplus_Click(object sender, EventArgs e)
        {
            calc.valueOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            calc.operation = "+";
        }
        private void Buttonsub_Click(object sender, EventArgs e)
        {
            calc.valueOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            calc.operation = "-";
        }
        private void Buttonmul_Click(object sender, EventArgs e)
        {
            calc.valueOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            calc.operation = "*";
        }
        private void Buttondiv_Click(object sender, EventArgs e)
        {
            calc.valueOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            calc.operation = "/";
        }
        private void Buttonequals_Click(object sender, EventArgs e)
        {

            calc.valueTwo = Convert.ToDouble(textBox1.Text);


            if (calc.operation.Equals("+"))
            {
                calc.Add();
            }
            if (calc.operation.Equals("-"))
            {
                calc.Sub();
            }
            if (calc.operation.Equals("*"))
            {
                calc.Mul();
            }
            if (calc.operation.Equals("/"))
            {
                calc.Div();
            }
            textBox1.Text = Convert.ToString(calc.total);
        }
        private void buttonerase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        public void DisplayNumber(String number)
        {
            textBox1.Text = textBox1.Text + "";
            textBox1.Text += number;
        }
    }
}