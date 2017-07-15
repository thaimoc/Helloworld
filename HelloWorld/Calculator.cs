using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Calculator
    {
        public Calculator()
        {

        }

        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Substract(int left, int right)
        {
            return left - right;
        }

        public int Multiply(int left, int right)
        {
            return left * right;
        }

        public int Devision(int left, int right)
        {
            if (right == 0)
            {
                return 0;
            }
            return left / right;
        }
    }
}
