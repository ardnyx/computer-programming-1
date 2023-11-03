using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] data = new string[6, 4];

            data[0, 0] = "NAME";
            data[0, 1] = "SCORE";
            data[0, 2] = "AVERAGE";
            data[0, 3] = "GRADE";

            for (int a = 1; a < data.GetLength(0); a++)
            {
                Console.Write("Name: ");
                data[a, 0] = Console.ReadLine();
                Console.Clear();
                int math = 0;
                double generalAverage;
                string passed = "Passed";
                string failed = "Failed";

                Console.WriteLine("What is 1+1? \n a. 1 \n b. 2");
                char answer1 = char.Parse(Console.ReadLine());
                if (answer1 == 'b')
                {
                    math++;
                }
                Console.Clear();
                Console.WriteLine("What do you call the operations that squares? \n a. Square Root \n b. Exponent");
                char answer2 = char.Parse(Console.ReadLine());
                if (answer2 == 'a')
                {
                    math++;
                }
                Console.Clear();
                Console.WriteLine("What do you call the operation that adds? \n a. Division \n b. Addition");
                char answer3 = char.Parse(Console.ReadLine());
                if (answer3 == 'b')
                {
                    math++;
                }
                Console.Clear();
                Console.WriteLine("Who is Fibonacci? \n a. The one who created Fibonacci Sequence \n b. Created Pythagorean Theorem");
                char answer4 = char.Parse(Console.ReadLine());
                if (answer4 == 'a')
                {
                    math++;
                }
                Console.Clear();
                Console.WriteLine("What is 1/0? \n a. Undefined \n b. Indeterminate");
                char answer5 = char.Parse(Console.ReadLine());
                if (answer5 == 'a')
                {
                    math++;
                }
                Console.Clear();

                generalAverage = (double)math / 5;
                data[a, 1] = Convert.ToString(math);
                data[a, 2] = Convert.ToString(generalAverage);
                if (generalAverage > 0.7)
                {
                    data[a, 3] = passed;
                }
                else data[a, 3] = failed;
            }

            for (int b = 0; b < data.GetLength(0); b++)
            {
                for (int c = 0; c < data.GetLength(1); c++)
                {
                    Console.Write(data[b,c] + "\t\t");
                }
                Console.WriteLine();
            }
        }
    }
}
