using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Calculator : ICalculator
    {
        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Mul(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
