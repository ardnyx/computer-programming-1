using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
