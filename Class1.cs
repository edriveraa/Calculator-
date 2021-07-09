using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public class Class1
    {
        private String Operation;
        public String operation
        {
            get { return Operation; }
            set { Operation = value; }
        }
        private double ValueOne;
        public double valueOne
        {
            get { return ValueOne; }
            set { ValueOne = value; }
        }
        private double ValueTwo;
        public double valueTwo
        {
            get { return ValueTwo; }
            set { ValueTwo = value; }
        }
        private double Total;
        public double total
        {
            get { return Total; }
            set { Total = value; }
        }
        public string textbox;
        public void Add()
        {
            Total = (ValueOne + ValueTwo);
            textbox = Convert.ToString(Total);
            ValueOne = Total;
        }
        public void Sub()
        {
            Total = (ValueOne - ValueTwo);
            textbox = Convert.ToString(Total);
            ValueOne = Total;
        }
        public void Mul()
        {
            Total = (ValueOne * ValueTwo);
            textbox = Convert.ToString(Total);
            ValueOne = Total;
        }
        public void Div()
        {
            if (ValueTwo == 0)
            {
                textbox = "Cannot divide by zero.";
            }
            else
            {
                Total = (ValueOne / ValueTwo);
                textbox = Convert.ToString(Total);
                ValueOne = Total;
            }
        }
    }
}
