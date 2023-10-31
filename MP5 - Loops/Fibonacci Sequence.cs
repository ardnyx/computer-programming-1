using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long fn1 = 0, fn2 = 1, nextNum;
            Console.Write("How many numbers do you want to generate? ");
            int input = Int32.Parse(Console.ReadLine());
            if (input == 1)
            {
                for (int i = 1; i <= input; i++)
                {
                    nextNum = fn1 + fn2;
                    Console.WriteLine(nextNum);
                    fn1 = fn2;
                    fn2 = nextNum;
                }
            }
            else
            {
                Console.WriteLine(1);
                for (int i = 2; i <= input; i++)
                {
                    nextNum = fn1 + fn2;
                    Console.WriteLine(nextNum);
                    fn1 = fn2;
                    fn2 = nextNum;
                }
            }
            Console.ReadKey();
        }
    }
}
