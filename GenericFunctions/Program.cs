using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace GenericFunctions
{
    internal class Program
    {
        static dynamic InputLine()
        {
            dynamic x = null;

            Console.WriteLine("pls enter the variable value");
            x = Console.ReadLine();

            try
            {
                x = Convert.ToDouble(x);
            }
            catch (FormatException e) {};

            return x;
        }
        static dynamic genericFunction(dynamic x, dynamic y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            dynamic x, y;
            x = InputLine();

            y = InputLine();

            Console.WriteLine($"{x} + {y} = {genericFunction(x, y)}");
        }
    }
}
