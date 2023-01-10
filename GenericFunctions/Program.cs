using System;

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
            catch (FormatException e) { };

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
                if (x.Length < y.Length)
                    return x;

                else if (x.Length == y.Length)
                {
                    bool[] AllLetters = new bool[2];

                    int Length;

                    string TemporaryString;

                    for (int h = 0; h < 2; h++)
                    {
                        if (h == 0)
                        {
                            Length = x.Length;
                            TemporaryString = x;
                        }
                        else
                        {
                            Length = y.Length;
                            TemporaryString = y;
                        }

                        for (int k = 0; k < Length; k++)
                        {
                            if (TemporaryString[k] >= 'A' && TemporaryString[k] <= 'Z' || TemporaryString[k] >= 'a' && TemporaryString[k] <= 'z')
                                AllLetters[h] = true;
                            else
                                AllLetters[h] = false;
                        }
                    }
                    if (AllLetters[0] && AllLetters[1])
                    {
                        int[] Sum = new int[2];

                        for (int j = 0; j < 2; j++)
                        {
                            if (j == 0)
                            {
                                Length = x.Length;
                                TemporaryString = x;
                            }
                            else
                            {
                                Length = y.Length;
                                TemporaryString = y;
                            }

                            for (int i = 0; i < Length; i++)
                            {
                                Sum[j] += (char)TemporaryString[i];
                            }
                        }
                        if (Sum[0] < Sum[1])
                            return x;

                        return y;
                    }
                }
                return y;
            }
        }
        static void Main(string[] args)
        {
            dynamic x, y;
            x = InputLine();

            y = InputLine();

            Console.WriteLine($"{x} {x.GetType()} + {y} {y.GetType()} = {genericFunction(x, y)}");

            Console.WriteLine("The smaller varialbe is {0}\n", MathMin(x, y));
        }
    }
}
