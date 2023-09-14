using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1_Leyesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("SUBPROGRAM TRYOUTS");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("[1] Leap Year Calculator");
            Console.WriteLine("[2] PHP to USD Converter");
            Console.WriteLine("[3] Calculator");
            Console.WriteLine("");
            Console.Write("Pick the number of the subprogram you want to try: ");
            int subprogram = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (subprogram)
            {
                case 1:
                    Console.Write("Input a Year: ");
                    int year = int.Parse(Console.ReadLine());

                    if ((year % 400) == 0)
                    {
                        Console.WriteLine($"{year} is a leap year");
                    }
                    else if ((year % 100) == 0)
                    {
                        Console.WriteLine($"{year} is not a leap year");
                    }
                    else if ((year % 4) == 0)
                    {
                        Console.WriteLine($"{year} is a leap year");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is not a leap year");
                    }
                    break;

                case 2:
                    Console.WriteLine("********************");
                    Console.WriteLine("PHP TO USD CONVERTER");
                    Console.WriteLine("********************");
                    Console.WriteLine("");
                    Console.Write("Input Cash in Php: ");
                    float php = float.Parse(Console.ReadLine());
                    double usd = 0.018;
                    double conversion = php * usd;

                    Console.WriteLine($"{conversion:N2} USD");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("**********");
                    Console.WriteLine("CALCULATOR");
                    Console.WriteLine("**********");
                    Console.WriteLine("");
                    Console.Write("Input Number 1: ");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.Write("Input Number 2: ");
                    float num2 = float.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("***************");
                    Console.WriteLine("CHOOSE OPERATOR");
                    Console.WriteLine("***************");
                    Console.WriteLine("");
                    Console.WriteLine("(1) Add");
                    Console.WriteLine("(2) Subtract");
                    Console.WriteLine("(3) Multiply");
                    Console.WriteLine("(4) Divide");
                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine($"The answer for {num1} + {num2} is {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine($"The answer for {num1} - {num2} is {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine($"The answer for {num1} x {num2} is {num1 * num2}");
                            break;
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine($"The answer for {num1} / {num2} is {num1 / num2}");
                            break;
                    }
                    break;

            }

            Console.ReadKey();
        }
    }
}
