using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal class Calculator : IAdd, IDiff, IMultiply, IDivide
    {
        public decimal Add(decimal num1, decimal num2) 
            => num1 + num2;

        public decimal Difference(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
    }
}
