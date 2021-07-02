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
        Class1 edcalc = new Class1();


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
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
            edcalc.ValueOne = Convert.ToDouble(textBox1);
            textBox1.Text = "0";
            edcalc.Operation.Equals("+");
        }
        private void Buttonsub_Click(object sender, EventArgs e)
        {
            edcalc.ValueOne = Convert.ToDouble(textBox1);
            textBox1.Text = "0";
            edcalc.Operation.Equals("-"); 
        }
        private void Buttonmul_Click(object sender, EventArgs e)
        {
            edcalc.ValueOne = Convert.ToDouble(textBox1);
            textBox1.Text = "0";
            edcalc.Operation.Equals("*"); 
        }
        private void Buttondiv_Click(object sender, EventArgs e)
        {
            edcalc.ValueOne = Convert.ToDouble(textBox1);
            textBox1.Text = "0";
            edcalc.Operation.Equals("/"); 
        }
        private void Buttonequals_Click(object sender, EventArgs e)
        {

            if (edcalc.Operation == "+")
            {
                edcalc.Add();
            }
            if (edcalc.Operation == "-")
            {
                edcalc.Sub();
            }
            if (edcalc.Operation == "*")
            {
                edcalc.Multi();
            }
            if (edcalc.Operation == "/")
            {
                edcalc.Div();
            }
        }     
    }
}