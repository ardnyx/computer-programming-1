using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Twenty Odd Natural Numbers");
            for (int x = 1; x < 40; x += 2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
