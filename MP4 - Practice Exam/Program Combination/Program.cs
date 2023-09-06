using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_Leyesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Good Day Fellow Klasmeyt! I have a program prepared for you
Would you like to see your horoscope or do a short quiz?

[1] Horoscope
[2] Do a Short Quiz");
            int horo_quiz = int.Parse(Console.ReadLine());
            Console.Clear();

            if (horo_quiz == 1)
            {
                Console.WriteLine("Input Your Zodiac Sign: ");
                Console.WriteLine("[1] Aries");
                Console.WriteLine("[2] Taurus");
                Console.WriteLine("[3] Gemini");
                Console.WriteLine("[4] Cancer");
                Console.WriteLine("[5] Leo");
                Console.WriteLine("[6] Virgo");
                Console.WriteLine("[7] Libra");
                Console.WriteLine("[8] Scorpio");
                Console.WriteLine("[9] Sagittarius");
                Console.WriteLine("[10] Capricorn");
                Console.WriteLine("[11] Aquarius");
                Console.WriteLine("[12] Pisces");
                int zodiac = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Clear();

                if (zodiac == 1 )
                {
                    Console.WriteLine(@"Sign Facts:

1. Aries, a Fire sign ruled by Mars, falls between March 21 and April 19.
2. Aries individuals are assertive and independent, often displaying courage in pursuing their goals.
3. They make natural leaders but can be impulsive at times.

Horoscope for the Day: 06/09/2023
You will lost a large amount of money today.

Lucky Color: Red
Lucky Numbers: 12, 2, 6

Sign Compatibility:
Good: Leo, Sagittarius, Gemini
Natural: Aries, Taurus, Cancer
Bad: Virgo, Scorpio, Capricorn");
                }

                if (zodiac == 2)
                {
                    Console.WriteLine(@"Sign Facts:

1. Taurus, an Earth sign ruled by Venus, falls between April 20 and May 20.
2. Taurus individuals are practical, stable, and persistent in pursuing their goals.
3. They value loyalty and can be nurturing, although they may resist change at times.

Horoscope for the Day: 06/09/2023
You will find a lost money of an Aries.

Lucky Color: Green
Lucky Number: 6, 3, 7

Sign Compatibility:
Good: Virgo, Capricorn, Cancer
Natural: Taurus, Pisces, Scorpio
Bad: Gemini, Sagittarius, Aquarius");
                }

                if (zodiac == 3)
                {
                    Console.WriteLine(@"Sign Facts:

1. Gemini, an Air sign ruled by Mercury, falls between May 21 and June 20.
2. Gemini individuals are curious, adaptable, and skilled in communication.
3. They thrive on variety and intellectual stimulation but can be indecisive at times.

Horoscope for the Day: 06/09/2023
2 days later, you will find someone special, pero hindi magiging kayo.

Lucky Color: Yellow
Lucky Number: 5, 25, 30

Sign Compatibility:
Good: Libra, Aquarius, Aries
Natural: Gemini, Leo, Sagittarius
Bad: Cancer, Virgo, Pisces");
                }

                if (zodiac == 4)
                {
                    Console.WriteLine(@"Sign Facts:

1. Cancer, a Water sign ruled by the Moon, falls between June 21 and July 22.
2. Cancer individuals are emotionally sensitive, nurturing, and deeply intuitive.
3. They value home and family and can be protective, although they may struggle with mood swings.

Horoscope for the Day: 06/09/2023
Your death will be due to cancer.

Lucky Color: Silver
Lucky Number: 2, 4, 57

Sign Compatibility:
Good: Scorpio, Pisces, Taurus
Natural: Cancer, Virgo, Capricorn
Bad: Aries, Libra, Aquarius");
                }

                if (zodiac == 5)
                {
                    Console.WriteLine(@"Sign Facts:

1. Leo, a Fire sign ruled by the Sun, falls between July 23 and August 22.
2. Leo individuals are confident, charismatic, and natural leaders.
3. They thrive in the spotlight, enjoy creative self-expression, but can be seen as self-centered at times.

Horoscope for the Day: 06/09/2023
Wag ka magsama ng kasama mamaya pag-uwi, baka maging kayo.

Lucky Color: Gold
Lucky Number: 1, 11, 22

Sign Compatibility:
Good: Aries, Sagittarius, Gemini
Natural: Leo, Libra, Aquarius
Bad: Taurus, Scorpio, Pisces");
                }

                if (zodiac == 6)
                {
                    Console.WriteLine(@"Sign Facts:

1. Virgo, an Earth sign ruled by Mercury, falls between August 23 and September 22.
2. Virgo individuals are known for their attention to detail, practicality, and strong analytical abilities.
3. They have a strong sense of duty and responsibility but may be critical and perfectionistic.

Horoscope for the Day: 06/09/2023
Wag kang titingin sa likod gamit lang ulo mo ngayon, mabubulag ka.

Lucky Color: Navy Blue
Lucky Number: 3

Sign Compatibility:
Good: Taurus, Capricorn, Cancer
Natural: Virgo, Scorpio, Pisces
Bad: Gemini, Sagittarius, Aquarius");
                }

                if (zodiac == 7)
                {
                    Console.WriteLine(@"Sign Facts:

1. Libra, an Air sign ruled by Venus, falls between September 23 and October 22.
2. Libra individuals are known for their love of balance, harmony, and social connections.
3. They possess natural charm and diplomacy but may struggle with indecision at times.

Horoscope for the Day: 06/09/2023
Makakakita ka ng pusa sa bahay nyo ngayon.

Lucky Color: Pastel Blue
Lucky Number: 7, 11, 15

Sign Compatibility:
Good: Gemini, Aquarius, Leo
Natural: Libra, Sagittarius, Aries
Bad: Cancer, Capricorn, Pisces");
                }

                if (zodiac == 8)
                {
                    Console.WriteLine(@"Sign Facts:

1. Scorpio, a Water sign ruled by Mars and Pluto, falls between October 23 and November 21.
2. Scorpio individuals are known for their intensity, passion, and deep emotional nature.
3. They have a strong desire for truth and transformation but may struggle with secrecy and jealousy.

Horoscope for the Day: 06/09/2023
Mag-aalaga ka ng aso someday. If meron ka nang aso, magkakaroon ka naman ng pusa. 
If meron na both, aalagaan ka niya. Yie.

Lucky Color: Deep Burgundy
Lucky Number: 8, 89, 34

Sign Compatibility:
Good: Cancer, Pisces, Virgo
Natural: Scorpio, Capricorn, Taurus
Bad: Gemini, Leo, Aquarius");
                }

                if (zodiac == 9)
                {
                    Console.WriteLine(@"Sign Facts:

1. Sagittarius, a Fire sign ruled by Jupiter, falls between November 22 and December 21.
2. Sagittarius individuals are known for their adventurous spirit, love of exploration, and philosophical outlook on life.
3. They value freedom and independence but can be seen as tactless or impatient at times.

Horoscope for the Day: 06/09/2023
You will have a great day. :) 

Lucky Color: Royal Blue
Lucky Number: 9, 54, 44

Sign Compatibility:
Good: Aries, Leo, Gemini
Natural: Sagittarius, Libra, Aquarius
Bad: Taurus, Scorpio, Pisces");
                }

                if (zodiac == 10)
                {
                    Console.WriteLine(@"Sign Facts:

1. Capricorn, an Earth sign ruled by Saturn, falls between December 22 and January 19.
2. Capricorn individuals are known for their strong work ethic, discipline, and determination to achieve their goals.
3. They value tradition and stability but can be seen as reserved or serious at times.

Horoscope for the Day: 06/09/2023
Makakalibre ka ng pamasahe ngayon.

Lucky Color: Charcoal Gray
Lucky Number: 4, 65, 34

Sign Compatibility:
Good: Taurus, Virgo, Pisces
Natural: Capricorn, Scorpio, Cancer
Bad: Gemini, Leo, Aquarius");
                }

                if (zodiac == 11)
                {
                    Console.WriteLine(@"Sign Facts:

1. Aquarius, an Air sign ruled by Uranus (traditional ruler Saturn), falls between January 20 and February 18.
2. Aquarius individuals are known for their originality, intellectual prowess, and humanitarian outlook on life.
3. They value innovation and can be seen as open-minded, friendly, and independent.

Horoscope for the Day: 06/09/2023
Wag ka magbubukas ng kahit anong mobile browser (Google, Firefox, Safari, etc.) pag may katabi ka mamaya.
Makikita nila history mo.

Lucky Color: Electric Blue
Lucky Number: 11, 31, 41

Sign Compatibility:
Good: Gemini, Libra, Aries
Natural: Aquarius, Sagittarius, Leo
Bad: Cancer, Virgo, Pisces");
                }

                if (zodiac == 12)
                {
                    Console.WriteLine(@"Sign Facts:

1. Pisces, a Water sign ruled by Neptune (traditional ruler Jupiter), falls between February 19 and March 20.
2. Pisces individuals are known for their compassionate, empathetic, and highly intuitive nature.
3. They value emotional depth and creativity but may struggle with boundaries and impressionability.

Horoscope for the Day: 06/09/2023
Uminom ka ng C2 mamaya pampagaan-loob lang.

Lucky Color: Seafoam Green
Lucky Number: 7, 76, 65

Sign Compatibility:
Good: Cancer, Scorpio, Taurus
Natural: Pisces, Capricorn, Virgo
Bad: Gemini, Sagittarius, Aquarius");
                }
            }

            else if (horo_quiz == 2)
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
                Console.WriteLine("[3] Anders Hejlsberg");
                Console.WriteLine("[4] Anders Helsjberg");
                Console.Write("Answer: ");
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
                Console.Write("Answer: ");
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
                Console.Write("Answer: ");
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
                Console.Write("Answer: ");
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
                Console.Write("Answer: ");
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
            }

            else
            {

            }
            Console.ReadKey();
            }
        }
    }

