using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab_2_1
{
    public class Calc
    {
        Random rand = new Random();
        public double val1;
        public double val2;
   
        public Calc()
        {
            val1 = rand.Next(0, 10);
            val2 = rand.Next(0, 10);
        }

        public string Add()
        {
            return "" + val1 + " + " + val2 + " = " + (val1 + val2);
        }

        public string Sub()
        {
            return "" + val1 + " - " + val2 + " = " + (val1 - val2);
        }

        public string Mult()
        {
            return "" + val1 + " * " + val2 + " = " + (val1 * val2);
        }

        public string Div()
        {
            if (val2 != 0)
                return "" + val1 + " / " + val2 + " = " + Math.Round(val1 / val2);
            else
                return "" + val1 + " / " + val2 + " = " + "Error: Division by zero";
        }
    }
}
