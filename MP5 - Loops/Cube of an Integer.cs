using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Up to what number? ");
            int integer = int.Parse(Console.ReadLine());
            
            for (int x = 1; x <= integer; x++)
            {
                Console.WriteLine(x*x*x);
            }
            Console.ReadKey();
        }
    }
}
