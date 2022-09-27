using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Calc
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }


        public static double Addition(List<double> numbers)
        {
            double sum = 0;
            foreach(double number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }


        public static double Subtraction(List<double> numbers)
        {
            double difference = 0;
            foreach (double number in numbers)
            {
                difference -= number;
            }
            return difference;
        }


        public static double Multiplication(double a, double b)
        {
            return a * b;
        }


        public static double Division(double a, double b)
        {   
            if (b == 0)
            {
                throw new DivideByZeroException("Can't divide by zero!");
            }

            return (a / b);
        }
    }
}
