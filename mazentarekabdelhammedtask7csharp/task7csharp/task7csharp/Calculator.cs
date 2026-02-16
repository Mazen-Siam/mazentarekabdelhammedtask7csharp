using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7csharp
{
   

    public class Calculator
    {
        
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }

    class prog
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum of two integers: " + calc.Sum(5, 10));
            Console.WriteLine("Sum of three integers: " + calc.Sum(2, 4, 6));
            Console.WriteLine("Sum of two doubles: " + calc.Sum(3.5, 4.2));
        }
    }
}
