using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calc : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
            if (b != 0) return a / b;
            else throw new DivideByZeroException();
           
        }

        public int Mod(int a, int b)
        {
            if (b != 0) return a % b;
            else throw new DivideByZeroException();
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
