using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_
{
    public class Class1
    {
        private string operation = "";
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        private double valueOne;
        public double ValueOne
        {
            get { return valueOne; }
            set { valueOne = value; }
        }
        private double valueTwo;
        public double ValueTwo
        {
            get { return valueTwo; }
            set { valueTwo = value; }
        }
        private double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public void Add()
        {
            Total = (valueOne + valueTwo);
            ValueTwo = Convert.ToDouble(total);
            ValueOne = total;
        }
        public void Sub()
        {
            Total = (valueOne - valueTwo);
            ValueTwo = Convert.ToDouble(total);
            ValueOne = total;
        }
        public void Multi()
        {
            Total = (valueOne * valueTwo);
            ValueTwo = Convert.ToDouble(total);
            ValueOne = total;
        }
        public void Div()
        {
            if (valueTwo == 0)
            {
                valueTwo = Convert.ToDouble("Cannot divide by zero");

            }
            else
            {
                total = (valueOne / valueTwo);
                valueTwo = Convert.ToDouble(total);
                valueOne = total;
            }
        }
    }
}
