using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg_gennumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            Console.Write("How many numbers do you want to generate? ");
            int input = int.Parse(Console.ReadLine());
            for (int x = 1; x <= input; x++)
            {
                numbers += x;
                Console.WriteLine(x);
                
            }
            float average = (float)numbers / input;
            Console.WriteLine($"The average of the numbers is {average}");
            Console.ReadKey();
        }
    }
}
