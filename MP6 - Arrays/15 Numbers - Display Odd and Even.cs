using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_15numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[16];
            int[] arr2 = new int[16];
            int[] arr3 = new int[16];
            int i, j = 0, k = 0, n = 16;
            for (i = 1; i < n; i++)
            {
                Console.Write("Number {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (i = 1; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}

