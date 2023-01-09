using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunctions
{
    internal class Program
    {
        static dynamic InputLine()
        {
            dynamic x = null;

            Console.WriteLine("pls enter the variable value");

            try
            {
                x = Console.ReadLine();

                try
                {
                    x = Convert.ToDouble(x);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (FormatException e)
            {
            }
            catch (Exception)
            {
                throw;
            }
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
