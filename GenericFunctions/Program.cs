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
        static dynamic MathMin(dynamic x, dynamic y)
        {
            if (x.GetType() == typeof(double))
            {
                if (x < y)
                    return x;
                return y;
            }
            else
            {
                int XSum = 0, YSum = 0;

                for (int i = 0; i < x.Length; i++)
                {
                    XSum += (char)x[i];
                }
                for (int i = 0; i < y.Length; i++)
                {
                    YSum += (char)y[i];
                }
                if (XSum < YSum)
                    return x;
                return y;
            }
        }
        static void Main(string[] args)
        {
            dynamic x, y;
            x = InputLine();

            y = InputLine();

            Console.WriteLine($"{x} {x.GetType()} + {y} {y.GetType()} = {genericFunction(x, y)}");

            Console.WriteLine("The smoller varialbe is {0}", MathMin(x, y));
        }
    }
}
