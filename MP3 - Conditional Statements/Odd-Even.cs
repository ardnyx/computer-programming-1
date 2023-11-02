using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input a number
            Console.Write("Input a Number: ");

            // Read the user's input and convert it to an integer
            int num = int.Parse(Console.ReadLine());

            /* Check if the number is odd by dividing it by 2 by using modulo "%" and checking the remainder. The difference of using modulo % and divide
             is that modulo also considers if the number has a remainder. Both operations divide naman. */
            if (num % 2 >= 1) // If the remainder is greater than or equal to 1, the number is odd
            {
                Console.WriteLine($"{num} is an odd number"); // Display a message indicating that the number is odd
            }
            else
            {
                // otherwise, if the remainder is 0, the number is even
                Console.WriteLine($"{num} is an even number"); // Display a message indicating that the number is even
            }

            // Wait for a key press before ending the program
            Console.ReadKey();
        }
    }
}
