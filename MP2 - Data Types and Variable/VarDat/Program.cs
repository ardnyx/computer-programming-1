using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to hold numeric values. We used "int" kasi integer lang naman yung gusto nating panghawakan na value, and isn't a decimal.
            int val1, val2, val3, val4, val5, val6, totVal, subVal, prodVal;
            float quotVal, avg; /* Declare a variable to hold the average value. We used float because usually, average values and quotients have a possibility of
                                 giving decimal results. */
            string sval1; // Declare a variable to hold a string input

            // Prompt the user to enter the first number
            Console.Write("Enter the 1st Number: ");
            sval1 = Console.ReadLine(); // Read the user's input as a string
            val1 = Int32.Parse(sval1); // Convert the string to an integer

            // Prompt the user to enter the second number
            Console.Write("Enter the 2nd Number: ");
            val2 = Int32.Parse(Console.ReadLine()); // Read and convert input in one step

            // Perform calculations using the entered values
            totVal = val1 + val2; // Calculate the sum of the two numbers
            subVal = val1 - val2; // Calculate the difference between the two numbers
            prodVal = val1 * val2; // Calculate the product of the two numbers
            quotVal = (float)val1 / val2; // Calculate the quotient of the two numbers (casting to float)

            // Display the results of the calculations
            Console.WriteLine($"The sum of the two numbers is {totVal:N2}");
            Console.WriteLine($"The difference of the two numbers is {subVal:N2}");
            Console.WriteLine($"The product of the two numbers is {prodVal:N2}");
            Console.WriteLine($"The quotient of the two numbers is {quotVal:N2}");

            // Display an empty line and prompt to continue
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear(); // Clear the console for a clean appearance

            // Prompt the user to enter six numbers for averaging
            Console.Write("Enter the 1st Number: ");
            sval1 = Console.ReadLine();
            val1 = Int32.Parse(sval1);
            Console.Write("Enter the 2nd Number: ");
            val2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the 3rd Number: ");
            val3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the 4th Number: ");
            val4 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the 5th Number: ");
            val5 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the 6th Number: ");
            val6 = Int32.Parse(Console.ReadLine());

            // Calculate the average of the entered numbers
            avg = (float)(val1 + val2 + val3 + val4 + val5 + val6) / 6;

            /* Display the calculated average. Also if mapapansin niyo, I used an additional attribute called "N2". This means I want to announce the numeric value
            as a string with fixed number (in this case, 2) of decimal places. I can achieve the same thing with F2. The difference is F# will only format the decimal
            places, while N# will also format the number in a human-reable way. For example, N3 will say 1,000.323. If naka F3, magiging 1000.323 siya. */
            Console.WriteLine($"The average of the 6 numbers is {avg:N2}");

            Console.ReadKey(); // Wait for a key press before ending the program
        }
    }
}
