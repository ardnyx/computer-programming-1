using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradePointAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write will be used para sa pag-input ng user. "float" was used to declare the variable "prelim" para nakadecimal. */
            Console.Write("Prelim Grade: "); 

            /* This following statement is used to parse the following input into a float. We're telling the program na "this input is a float number" Repeat
            the process accordingly */
            float prelim = float.Parse(Console.ReadLine()); 

            Console.Write("Midterm Grade: ");
            float midterm = float.Parse(Console.ReadLine());
            Console.Write("Final Grade: ");
            float finals = float.Parse(Console.ReadLine());

            /* We declare another variable called prelimg, midtermg, finalsg, to represent the values after the grades have been multiplied to 0.3 (30%), and 0.4 (40%)
            for the prelims, midterms, and finals. Why did we use "double" instead of "float"? Even though yung variables "prelim, midterm, finals" are considered floats,
            yung 0.3 and 0.4 are considered are "double" data types. If we want to use float, kailangan natin iannounce na 0.3f and 0.4f. */
            double prelimg = prelim * 0.3;
            double midtermg = midterm * 0.3;
            double finalsg = finals * 0.4;

            /* I announced another variable called "finalsgrade" para sa final computation ng grade by adding the prelimg, midtermg, and finalsg, according sa instructions
            sa MP3 */
            double finalsgrade = prelimg + midtermg + finalsg;

            /* Then by following the given instruction sa grade point system, I just created an if-else if-else statements accordingly. */

            /* Bakit ako gumamit ng ">=" (greater than or equal to)? Let's use example 1 as an example. Para makakuha ka ng 1.00 GPA, you need grades that will fall under
            97-100. So the easiest way to tell the program this is by using >=. Bakit hindi <= (less than or equal to) ang ginamit ko? C# reads the program from top to bottom 
            right? So kung tatapusin natin lahat ng if-else statements, and let's say yung final grade na nakuha ko is 88 (which is 1.75), susundan niya yung if statement sa
            pinakataas which will show "The GPA is 1.00", kasi yun yung first statement na tumama "If finalsgrade is less than or equal to 97." Eh 88 is less than 97, and siya
            yung conditionial statement na nasa pinakataas, so siya yung uunahin. Mahirap siya i-explain which is why it is better to try it out for yourself.
            Always practice! */

            if (finalsgrade >= 97)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 1.00");
            }
            else if (finalsgrade >= 93)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 1.25");
            }
            else if (finalsgrade >= 89)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 1.50");
            }
            else if (finalsgrade >= 85)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 1.75");
            }
            else if (finalsgrade >= 82)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 2.00");
            }
            else if (finalsgrade >= 79)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 2.25");
            }
            else if (finalsgrade >= 76)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 2.50");
            }
            else if (finalsgrade >= 73)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 2.75");
            }
            else if (finalsgrade >= 70)
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 3.00");
            }

            /* Always remember that if you have multiple conditional statements, and order niyan is "if  -else if - else" You can only have ONE if, and ONE else. Use "else"
            if you want to say na if any of the previous statements are false, then do this. */
            else
            {
                Console.WriteLine($"The final grade is {finalsgrade:N0}");
                Console.WriteLine("The grade point equivalent is 5.00");
            }
            Console.ReadLine();
        }
    }
}
