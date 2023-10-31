using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace names_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new String[11];
            int x = 0;
            for (x = 1; x < names.Length; x++)
            {
                Console.Write($"Input Name #{x}: ");
                names[x] = Console.ReadLine();
            }
            Console.Write("\n");
            for (x = 10; x >= 0; x--)
            {
                Console.WriteLine(names[x]);
            }
            Console.ReadLine();
        }
    }
}
