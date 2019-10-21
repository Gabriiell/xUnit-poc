using System;
using System.Collections.Generic;
using System.Text;

namespace TestingPoc
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int value, int by)
        {
            if (value > 200)
            {
                throw new ArgumentOutOfRangeException("value should be less than 200");
            }

            return value / by;
        }
    }
}