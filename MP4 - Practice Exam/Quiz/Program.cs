using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUIZ TEST");
            Console.WriteLine("Click any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@"This test is about various questions about tech which will consist of 5 questions.
Each question will consist of 4 choices. Input the number of the correct choice to answer. Goodluck!

Press any key to continue");

            Console.ReadKey();
            Console.Clear();

            int score = 0;

            Console.WriteLine(@"Question 1: Who is the founder of C#?
");
            Console.WriteLine("[1] Anders Hyejslberg");
            Console.WriteLine("[2] Anders Heljbserg");
            Console.WriteLine("[3] Anders Heljsberg");
            Console.WriteLine("[4] Anders Helsjberg");
            int answer1 = int.Parse(Console.ReadLine());

            if (answer1 == 3)
            {
                score += 1;
            }
            else
            {

            }
            Console.Clear();

            Console.WriteLine(@"Question 2: Which of the following OS is not a UNIX-type operating system?
");
            Console.WriteLine("[1] Ubuntu");
            Console.WriteLine("[2] Mac OS");
            Console.WriteLine("[3] Fedora");
            Console.WriteLine("[4] Windows");

            int answer2 = int.Parse(Console.ReadLine());

            if (answer2 == 4)
            {
                score += 1;
            }
            else
            {

            }
            Console.Clear();

            Console.WriteLine(@"Question 3: Which of the following programs natively supports the use of C#
");
            Console.WriteLine("[1] Visual Studio");
            Console.WriteLine("[2] Visual Studio Code");
            Console.WriteLine("[3] Notepad++");
            Console.WriteLine("[4] Eclipse");
            int answer3 = int.Parse(Console.ReadLine());

            if (answer3 == 1)
            {
                score += 1;
            }
            else
            {

            }
            Console.Clear();

            Console.WriteLine(@"Question 4: What is the latest version of Windows?
");
            Console.WriteLine("[1] Windows 10 LTSC");
            Console.WriteLine("[2] Windows 11 LTS");
            Console.WriteLine("[3] Windows 11");
            Console.WriteLine("[4] Windows");
            int answer4 = int.Parse(Console.ReadLine());

            if (answer4 == 3)
            {
                score += 1;
            }
            else
            {

            }
            Console.Clear();

            Console.WriteLine(@"Question 5: Is HTML a programming language?
");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.WriteLine("[3] Yes. HTML is a markup, and markup is a programming language.");
            Console.WriteLine("[4] Yes because it is a declarative language ");
            int answer5 = int.Parse(Console.ReadLine());

            if (answer5 == 2)
            {
                score += 1;
            }
            else
            {

            }
            Console.Clear();

            Console.WriteLine("Congratulations on finishing the quiz!");
            Console.WriteLine("Do you want to see your score?");

            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                Console.WriteLine($"{name}'s score: {score}/5");
            }

            else if (choice == 2)
            {
                Console.WriteLine("Understood, thank you and have a great day!");
            }

            else
            {

            }
            Console.ReadKey();
        }
    }
}
