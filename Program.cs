using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double num = Convert.ToDouble("45");
            //Console.WriteLine(num+6);
            Console.WriteLine("Welcome to the basic Addition operation (+) calculator");
            Console.Write("Enter a number (\".\" is a delimiter): ");
            double num1 = Convert.ToDouble(Console.ReadLine(), new NumberFormatInfo { NumberDecimalSeparator = "." });
            Console.Write("Enter a second number (\".\" is a delimiter): ");
            double num2 = Convert.ToDouble(Console.ReadLine(), new NumberFormatInfo { NumberDecimalSeparator = "." }); // CONVERTING input to Double

            Console.WriteLine(num1 + num2);

            //Console.ReadLine();

        }
    }
}
