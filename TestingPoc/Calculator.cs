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

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int value, int by)
        {
            return value / by;
        }
    }
}