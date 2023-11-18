using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] data = new string[6, 6];

            data[0, 0] = "NAME";
            data[0, 1] = "MATH";
            data[0, 2] = "READING";
            data[0, 3] = "HISTORY";
            data[0, 4] = "AVERAGE";
            data[0, 5] = "GRADE";

            for (int a = 1; a < data.GetLength(0); a++)
            {
                Console.Write("Name: ");
                data[a, 0] = Console.ReadLine();
                Console.Clear();
                int math = 0;
                int reading = 0;
                int history = 0;
                double generalAverage;
                string passed = "Passed";
                string failed = "Failed";

                Console.WriteLine("MATH EXAMINATION");
                Console.Write("Exam Tests: \n 1. Multiple Choice \n 2. True or False \n 3. Fill in the Blanks \n");
                Console.Write("Choose your Exam Type: ");
                int mathExamType = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (mathExamType)
                {
                    case 1:
                        Console.WriteLine("What is 1+1? \n a. 1 \n b. 2");
                        char answer1 = char.Parse(Console.ReadLine());
                        if (answer1 == 'b')
                        {
                            math++;
                        }

                        Console.WriteLine("\n What do you call the operations that squares? \n a. Square Root \n b. Exponent \n");
                        char answer2 = char.Parse(Console.ReadLine());
                        if (answer2 == 'a')
                        {
                            math++;
                        }

                        Console.WriteLine("What do you call the operation that adds? \n a. Division \n b. Addition \n");
                        char answer3 = char.Parse(Console.ReadLine());
                        if (answer3 == 'b')
                        {
                            math++;
                        }

                        Console.WriteLine("Who is Fibonacci? \n a. The one who created Fibonacci Sequence \n b. Created Pythagorean Theorem \n");
                        char answer4 = char.Parse(Console.ReadLine());
                        if (answer4 == 'a')
                        {
                            math++;
                        }

                        Console.WriteLine("What is 1/0? \n a. Undefined \n b. Indeterminate \n");
                        char answer5 = char.Parse(Console.ReadLine());
                        if (answer5 == 'a')
                        {
                            math++;
                        }
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Every prime number greater than 2 is an odd number. \n a. True \n b. False \n");
                        char tfanswer1 = char.Parse(Console.ReadLine());
                        if (tfanswer1 == 'a')
                        {
                            math++;
                        }

                        Console.WriteLine("The square root of a negative number is always a complex number. \n a. True \n b. False \n");
                        char tfanswer2 = char.Parse(Console.ReadLine());
                        if (tfanswer2 == 'a')
                        {
                            math++;
                        }

                        Console.WriteLine("In a right-angled triangle, the square of the length of the hypotenuse is equal to the sum of the squares of the lengths of the other two sides. \n a. True \n b. False \n");
                        char tfanswer3 = char.Parse(Console.ReadLine());
                        if (tfanswer3 == 'b')
                        {
                            math++;
                        }

                        Console.WriteLine("Any number raised to the power of zero is always equal to one. \n a. True \n b. False \n");
                        char tfanswer4 = char.Parse(Console.ReadLine());
                        if (tfanswer4 == 'a')
                        {
                            math++;
                        }

                        Console.WriteLine("The sum of the interior angles of a triangle is always 180 degrees. \n a. True \n b. False \n");
                        char tfanswer5 = char.Parse(Console.ReadLine());
                        if (tfanswer5 == 'a')
                        {
                            math++;
                        }
                        Console.Clear();
                        break;


                    case 3:
                        Console.WriteLine("The area of a rectangle is length multiplied by __________. \n a. Width \n b. Perimeter \n");
                        char flanswer1 = char.Parse(Console.ReadLine());
                        if (flanswer1 == 'a')
                        {
                            math++;
                        }

                        // Question 2
                        Console.WriteLine("The formula for the volume of a cylinder is π * radius squared * __________. \n a. Height \n b. Diameter \n");
                        char flanswer2 = char.Parse(Console.ReadLine());
                        if (flanswer2 == 'a')
                        {
                            math++;
                        }

                        // Question 3
                        Console.WriteLine("The expression 2x + 5 = 15 can be solved for x as x = __________. \n a. 5 \n b. 10 \n");
                        char flanswer3 = char.Parse(Console.ReadLine());
                        if (flanswer3 == 'b')
                        {
                            math++;
                        }

                        // Question 4
                        Console.WriteLine("The sum of the angles in a hexagon is __________ degrees. \n a. 90 \n b. 120 \n");
                        char flanswer4 = char.Parse(Console.ReadLine());
                        if (flanswer4 == 'b')
                        {
                            math++;
                        }

                        // Question 5
                        Console.WriteLine("The square root of 49 is __________. \n a. 7 \n b. -7 \n");
                        char flanswer5 = char.Parse(Console.ReadLine());
                        if (flanswer5 == 'a')
                        {
                            math++;
                        }
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                Console.WriteLine("READING EXAMINATION");
                Console.Write("Exam Tests: \n 1. Multiple Choice \n 2. True or False \n 3. Fill in the Blanks \n");
                Console.Write("Choose your Exam Type: ");
                int readingExamType = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (readingExamType)
                {
                    case 1:
                        // Question 1
                        Console.WriteLine("In the passage, what is the main idea? \n a. The benefits of exercise \n b. The history of computers \n c. The impact of climate change \n");
                        char rcanswer1 = char.Parse(Console.ReadLine());
                        if (rcanswer1 == 'a')
                        {
                            reading++;
                        }

                        // Question 2
                        Console.WriteLine("According to the text, what is the author's opinion on technology? \n a. Positive \n b. Negative \n c. Neutral \n");
                        char rcanswer2 = char.Parse(Console.ReadLine());
                        if (rcanswer2 == 'a')
                        {
                            reading++;
                        }

                        // Question 3
                        Console.WriteLine("What is the meaning of the word 'resilient' as used in the passage? \n a. Fragile \n b. Flexible \n c. Determined \n");
                        char rcanswer3 = char.Parse(Console.ReadLine());
                        if (rcanswer3 == 'c')
                        {
                            reading++;
                        }

                        // Question 4
                        Console.WriteLine("According to the passage, what is the main challenge faced by the characters? \n a. Financial problems \n b. Environmental issues \n c. Social conflicts \n");
                        char rcanswer4 = char.Parse(Console.ReadLine());
                        if (rcanswer4 == 'b')
                        {
                            reading++;
                        }

                        // Question 5
                        Console.WriteLine("What can be inferred about the author's viewpoint on the topic? \n a. Optimistic \n b. Pessimistic \n c. Ambiguous \n");
                        char rcanswer5 = char.Parse(Console.ReadLine());
                        if (rcanswer5 == 'a')
                        {
                            reading++;
                        }
                        Console.Clear();
                        break;

                    case 2:
                        // Question 1
                        Console.WriteLine("The author of the passage suggests that climate change is a natural occurrence. \n a. True \n b. False \n");
                        char rtfanswer1 = char.Parse(Console.ReadLine());
                        if (rtfanswer1 == 'b')
                        {
                            reading++;
                        }

                        // Question 2
                        Console.WriteLine("In the text, the main character's decision was motivated by fear. \n a. True \n b. False \n");
                        char rtfanswer2 = char.Parse(Console.ReadLine());
                        if (rtfanswer2 == 'a')
                        {
                            reading++;
                        }

                        // Question 3
                        Console.WriteLine("The passage implies that the invention of the internet has had a negative impact on communication. \n a. True \n b. False \n");
                        char rtfanswer3 = char.Parse(Console.ReadLine());
                        if (rtfanswer3 == 'b')
                        {
                            reading++;
                        }

                        // Question 4
                        Console.WriteLine("According to the text, the events described took place in the 19th century. \n a. True \n b. False \n");
                        char rtfanswer4 = char.Parse(Console.ReadLine());
                        if (rtfanswer4 == 'b')
                        {
                            reading++;
                        }

                        // Question 5
                        Console.WriteLine("The author of the passage expresses doubt about the success of the proposed solution. \n a. True \n b. False \n");
                        char rtfanswer5 = char.Parse(Console.ReadLine());
                        if (rtfanswer5 == 'a')
                        {
                            reading++;
                        }
                        Console.Clear();
                        break;

                    case 3:
                        // Question 1
                        Console.WriteLine("The main theme of the passage is the exploration of the relationship between __________ and nature. \n a. Technology \n b. Science \n");
                        char rflanswer1 = char.Parse(Console.ReadLine());
                        if (rflanswer1 == 'a')
                        {
                            reading++;
                        }

                        // Question 2
                        Console.WriteLine("The author argues that the impact of social media on society is both __________ and negative. \n a. Positive \n b. Neutral \n");
                        char rflanswer2 = char.Parse(Console.ReadLine());
                        if (rflanswer2 == 'b')
                        {
                            reading++;
                        }

                        // Question 3
                        Console.WriteLine("The protagonist faces a moral dilemma when confronted with a choice between personal gain and __________. \n a. Loyalty \n b. Revenge \n");
                        char rflanswer3 = char.Parse(Console.ReadLine());
                        if (rflanswer3 == 'a')
                        {
                            reading++;
                        }

                        // Question 4
                        Console.WriteLine("The author emphasizes the importance of fostering __________ in the education system. \n a. Competition \n b. Creativity \n");
                        char rflanswer4 = char.Parse(Console.ReadLine());
                        if (rflanswer4 == 'b')
                        {
                            reading++;
                        }

                        // Question 5
                        Console.WriteLine("The central conflict in the story arises from the protagonist's struggle to reconcile __________ with societal expectations. \n a. Individuality \n b. Conformity \n");
                        char rflanswer5 = char.Parse(Console.ReadLine());
                        if (rflanswer5 == 'a')
                        {
                            reading++;
                        }

                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                Console.WriteLine("HISTORY EXAMINATION");
                Console.Write("Exam Tests: \n 1. Multiple Choice \n 2. True or False \n 3. Fill in the Blanks \n");
                Console.Write("Choose your Exam Type: ");
                int historyExamType = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (historyExamType)
                {
                    case 1:
                        // Question 1
                        Console.WriteLine("Who was the first President of the United States? \n a. John Adams \n b. George Washington \n c. Thomas Jefferson \n");
                        char hanswer1 = char.Parse(Console.ReadLine());
                        if (hanswer1 == 'b')
                        {
                            history++;
                        }

                        // Question 2
                        Console.WriteLine("The French Revolution began in what year? \n a. 1776 \n b. 1789 \n c. 1812 \n");
                        char hanswer2 = char.Parse(Console.ReadLine());
                        if (hanswer2 == 'b')
                        {
                            history++;
                        }

                        // Question 3
                        Console.WriteLine("The ancient city of Rome was founded on the banks of which river? \n a. Nile \n b. Tiber \n c. Danube \n");
                        char hanswer3 = char.Parse(Console.ReadLine());
                        if (hanswer3 == 'b')
                        {
                            history++;
                        }

                        // Question 4
                        Console.WriteLine("Who wrote 'The Communist Manifesto' alongside Karl Marx? \n a. Friedrich Engels \n b. Vladimir Lenin \n c. Leon Trotsky \n");
                        char hanswer4 = char.Parse(Console.ReadLine());
                        if (hanswer4 == 'a')
                        {
                            history++;
                        }

                        // Question 5
                        Console.WriteLine("The Battle of Gettysburg was a significant conflict during which war? \n a. American Civil War \n b. World War I \n c. Napoleonic Wars \n");
                        char hanswer5 = char.Parse(Console.ReadLine());
                        if (hanswer5 == 'a')
                        {
                            history++;
                        }
                        Console.Clear();
                        break;

                    case 2:
                        // Question 1
                        Console.WriteLine("The Battle of Waterloo, where Napoleon was defeated, took place in 1815. \n a. True \n b. False \n");
                        char htfanswer1 = char.Parse(Console.ReadLine());
                        if (htfanswer1 == 'a')
                        {
                            history++;
                        }

                        // Question 2
                        Console.WriteLine("The Great Wall of China was built during the Ming Dynasty. \n a. True \n b. False \n");
                        char htfanswer2 = char.Parse(Console.ReadLine());
                        if (htfanswer2 == 'b')
                        {
                            history++;
                        }

                        // Question 3
                        Console.WriteLine("The Renaissance was a period of intellectual and artistic growth that occurred in ancient Greece. \n a. True \n b. False \n");
                        char htfanswer3 = char.Parse(Console.ReadLine());
                        if (htfanswer3 == 'b')
                        {
                            history++;
                        }

                        // Question 4
                        Console.WriteLine("The Wright brothers were the first to successfully fly an airplane in 1903. \n a. True \n b. False \n");
                        char htfanswer4 = char.Parse(Console.ReadLine());
                        if (htfanswer4 == 'a')
                        {
                            history++;
                        }

                        // Question 5
                        Console.WriteLine("The Egyptian pharaoh Cleopatra was of Greek descent. \n a. True \n b. False \n");
                        char htfanswer5 = char.Parse(Console.ReadLine());
                        if (htfanswer5 == 'a')
                        {
                            history++;
                        }
                        Console.Clear();
                        break;

                    case 3:
                        // Question 1
                        Console.WriteLine("The Magna Carta, signed in ________, is considered a foundational document in the development of constitutional law. \n a. 1215 \n b. 1415 \n");
                        char hflanswer1 = char.Parse(Console.ReadLine());
                        if (hflanswer1 == 'a')
                        {
                            history++;
                        }

                        // Question 2
                        Console.WriteLine("The Renaissance, a period of cultural and artistic rebirth, originated in the city of ________. \n a. Athens \n b. Florence \n");
                        char hflanswer2 = char.Parse(Console.ReadLine());
                        if (hflanswer2 == 'b')
                        {
                            history++;
                        }

                        // Question 3
                        Console.WriteLine("The Industrial Revolution, characterized by the shift from agrarian and manual labor to machine-based manufacturing, began in the ________ century. \n a. 18th \n b. 19th \n");
                        char hflanswer3 = char.Parse(Console.ReadLine());
                        if (hflanswer3 == 'a')
                        {
                            history++;
                        }

                        // Question 4
                        Console.WriteLine("The Declaration of Independence, proclaiming the thirteen American colonies as independent states, was adopted on July 4, ________. \n a. 1774 \n b. 1776 \n");
                        char hflanswer4 = char.Parse(Console.ReadLine());
                        if (hflanswer4 == 'b')
                        {
                            history++;
                        }

                        // Question 5
                        Console.WriteLine("The Treaty of Versailles, which ended World War I, was signed in ________. \n a. 1917 \n b. 1919 \n");
                        char hflanswer5 = char.Parse(Console.ReadLine());
                        if (hflanswer5 == 'b')
                        {
                            history++;
                        }
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                int totalScore = math + reading + history;
                data[a, 1] = Convert.ToString(math);
                data[a, 2] = Convert.ToString(reading);
                data[a, 3] = Convert.ToString(history);
                generalAverage = (double)totalScore / 15;
                data[a, 4] = generalAverage.ToString("F1");
                if (generalAverage > 0.7)
                {
                    data[a, 5] = passed;
                }
                else data[a, 5] = failed;
            }

            for (int b = 0; b < data.GetLength(0); b++)
            {
                for (int c = 0; c < data.GetLength(1); c++)
                {
                    Console.Write(data[b, c] + "\t\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}