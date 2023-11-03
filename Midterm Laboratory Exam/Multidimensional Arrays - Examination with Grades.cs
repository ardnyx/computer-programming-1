using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMPLEEXAM_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            int examinees, x, y, z, xx, yy, zz;
            string[] name = new string[5];
            double[,] scores = new double[5, 4];
            double average;
            char answer;


            for (examinees = 0; examinees < 5; examinees++)
            {
                x = 0;
                y = 0;
                z = 0;
                Console.Write("Input Name: ");
                name[examinees] = Console.ReadLine();

                Console.WriteLine("Test 1 - MATH");
                Console.WriteLine("\n" + "1. WHAT IS 1 + 1:" + "\n" + "a) 3  b) 2  c) 4  d) 1");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'b' || answer == 'B')
                {
                    x++;
                }
                Console.WriteLine("\n" + "2. WHAT IS 35 x 7:" + "\n" + "a) 252  b) 238  c) 245  d) 240");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'c' || answer == 'C')
                {
                    x++;
                }
                Console.WriteLine("\n" + "3. WHAT IS 27 + 135:" + "\n" + "a) 162  b) 172  c) 152  d) 153");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'a' || answer == 'A')
                {
                    x++;
                }
                Console.WriteLine("\n" + "4. WHAT IS 989 + 1:" + "\n" + "a) 1000  b) 990  c) 991  d) 1001");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'b' || answer == 'B')
                {
                    x++;
                }
                Console.WriteLine("\n" + "5. WHAT IS 144 / 12:" + "\n" + "a) 12  b) 13  c) 11  d) 132");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'a' || answer == 'A')
                {
                    x++;
                }
                xx = x;
                scores[examinees, 0] = Convert.ToDouble(xx);

                Console.WriteLine("\nTest 2 - READING");
                Console.WriteLine("\n" + "1. Vince ___ to the grocery" + "\n" + "a) go  b) went  c) is  d) in");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'b' || answer == 'B')
                {
                    y++;
                }
                Console.WriteLine("\n" + "2. Vince ___ basketball" + "\n" + "a) is  b) play  c) played  d) are");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'c' || answer == 'C')
                {
                    y++;
                }
                Console.WriteLine("\n" + "3. Vince ___ inside the grocery" + "\n" + "a) is  b) are  c) were  d) go");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'a' || answer == 'A')
                {
                    y++;
                }
                Console.WriteLine("\n" + "4. Vince ___ a cellphone" + "\n" + "a) buy  b) bought  c) see  d) is");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'b' || answer == 'B')
                {
                    y++;
                }
                Console.WriteLine("\n" + "5. Vince ___ at a restaurant" + "\n" + "a) ate  b) eat  c) are  d) were");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'a' || answer == 'A')
                {
                    y++;
                }
                yy = y;
                scores[examinees, 1] = Convert.ToDouble(yy);

                Console.WriteLine("\nTest 3 - HISTORY");
                Console.WriteLine("\n" + "1. When did Spain colonize the Philippines?" + "\n" + "a) 1561  b) 1565  c) 1563  d) 1567");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'b' || answer == 'B')
                {
                    z++;
                }
                Console.WriteLine("\n" + "2. What year did 9/11 happen?" + "\n" + "a) 2011  b) 2002  c) 2001  d) 2000");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'c' || answer == 'C')
                {
                    z++;
                }
                Console.WriteLine("\n" + "3. What year did the holocause happen?" + "\n" + "a) 1933  b) 1932  c) 1934  d) 1935");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'a' || answer == 'A')
                {
                    z++;
                }
                Console.WriteLine("\n" + "4. What year did world war 2 start?:" + "\n" + "a) 1945  b) 1939  c) 1938  d) 1944");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'b' || answer == 'B')
                {
                    z++;
                }
                Console.WriteLine("\n" + "5. What year did world war 1 start?" + "\n" + "a) 1914  b) 1913  c) 1911  d) 1912");
                Console.Write("Answer: ");
                answer = char.Parse(Console.ReadLine());
                if (answer == 'a' || answer == 'A')
                {
                    z++;
                }
                zz = z;
                scores[examinees, 2] = Convert.ToDouble(zz);
                average = (x + y + z) / 3.0;
                scores[examinees, 3] = Convert.ToDouble(average);
                Console.Clear();
            }
            Console.Clear();

            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{name[j]} \t");

                for (int k = 0; k < 4; k++)
                {
                    Console.Write(scores[j, k] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}