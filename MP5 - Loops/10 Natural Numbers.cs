using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10naturalnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Ten Natural Numbers");
            for (int x = 1; x < 11; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
