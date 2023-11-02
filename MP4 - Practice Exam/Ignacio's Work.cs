using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_3_Ignacio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome! Choose which program you want to run:\n" +
                "[1] Zodiac Sign\n" +
                "[2] Simple Quiz Game\n" +
                "PROGRAM: ");
            int chosenProg = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (chosenProg == 1)
            {
                int zodiac;

                Console.WriteLine("Enter your zodiac sign accordingly:");
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
                Console.Write("Enter number that corresponds to your zodiac sign: ");

                zodiac = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                if (zodiac == 1)
                {
                    Console.WriteLine("ARIES (March 21 - April 19)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Ram\n" +
                        "  - Element: Fire\n" +
                        "  - Ruling Planet: Mars\n" +
                        "  - Cardinal Sign: Aries is a cardinal sign, which means they are natural initiators and leaders. They have a strong desire to start new projects and take the lead in various aspects of life.\n" +
                        "  - Impatience and Restlessness: Aries individuals can be quite impatient and easily bored. They prefer a fast-paced, dynamic environment and may become restless when faced with routine or stagnation.\n");
                    Console.WriteLine("HOROSCOPE FOR THE DAY:\n" +
                        "  - This is another day of surprises, Aries, and of things needing to be worked out over and over again, which takes patience. This day tests not only your patience, but the prospect of seeing, and weighing, other perspectives than the ones you are used to.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Red");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 9");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Leo, Sagittarius, Gemini, Aquarius\n" +
                        "  Neutral: Capricorn, Cancer, Virgo, Scorpio\n" +
                        "  Bad: Libra");
                }
                else if (zodiac == 2)
                {
                    Console.WriteLine("TAURUS (April 20 - May 20)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Bull\n" +
                        "  - Element: Earth\n" +
                        "  - Ruling Planet: Venus\n" +
                        "  - Determination and Stubbornness: Taurus individuals are known for their strong determination and stubbornness. Once they set their sights on a goal, they are unlikely to give up easily, no matter the obstacles.\n" +
                        "  - Materialistic Tendencies: Taureans have a tendency to value material possessions and financial security. They often work hard to achieve comfort and stability in their lives.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY\n" +
                        "  - There will likely be missed communications, and incorrect assumptions that turn on you, and yet these days of inner planet retrograde do have a silver lining in terms of internal reflection and sincere meditation on where life is taking you. ");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Green");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 6 and 5");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Virgo, Capricorn, Cancer, Pisces\n" +
                        "  Neutral: Aquarius, Leo, Libra, Sagittarius\n" +
                        "  Bad: Scorpio");
                }
                else if (zodiac == 3)
                {
                    Console.WriteLine("GEMINI (May 21 - June 20)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Twins\n" +
                        "  - Element: Air\n" +
                        "  - Ruling Planet: Mercury" +
                        "  - Dual Nature: Geminis are often associated with a dual personality or the twins symbol. They can display two distinct sides to their personality, sometimes appearing outgoing and social, and at other times introspective and reserved.\n" +
                        "  - Social and Charming: Gemini individuals are generally social butterflies and are known for their charming and witty personalities. They can easily strike up conversations with strangers and enjoy networking.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - our sense of intuition is very strong in this day, so that one relief from the potential confusion or mixed purpose comes from your deep inner knowing of what is right and what is not, and of what you need. Your dreams might be especially active now, and can tell you true about your situation, provided you can stay open to the information.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Yellow");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 3, 7, and 9");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Libra, Aquarius, Aries, Leo\n" +
                        "  Neutral: Pisces, Virgo, Capricorn, Scorpio\n" +
                        "  Bad: Sagittarius");
                }
                else if (zodiac == 4)
                {
                    Console.WriteLine("CANCER (June 21 - July 22)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Crab\n" +
                        "  - Element: Water\n" +
                        "  - Ruling Planet: Moon\n" +
                        "  - Nurturers and Caregivers: Cancers are natural nurturers and caregivers. They have a strong desire to take care of and protect their loved ones and often create a warm and comforting home environment.\n" +
                        "  - Strong Family Bonds: Family is of utmost importance to Cancer individuals. They tend to have strong bonds with their relatives and often prioritize family gatherings and traditions.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - You find yourself in an extremely thoughtful and introspective time, when nothing is quite as it seems, and when you must utilize discernment to find your way forward in the midst of a plethora of possibilities and choices.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - White ");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 2");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Scorpio, Pisces, Taurus, Virgo\n" +
                        "  Neutral: Aries, Libra, Aquarius, Sagittarius\n" +
                        "  Bad: Capricorn");
                }
                else if (zodiac == 5)
                {
                    Console.WriteLine("LEO (Juley 23 - August 22)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Lion\n" +
                        "  - Element: Fire\n" +
                        "  - Ruling Planet: Sun\n" +
                        "  - Natural Leaders: Leos are often seen as natural leaders. They have a regal and authoritative presence that draws others to them, and they are not afraid to take charge in various situations.\n" +
                        "  - Generosity and Warmth: Leos are known for their generosity and warm-heartedness. They are willing to go to great lengths to help and support their friends and loved ones.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - This is another powerful day of internal contemplation and course correction, Leo. The recent New Moon in your sign, accompanied by retrograde Venus there as well, has given you some conundrums to fathom and yet also an opportunity to try for a better balance between inner and outer concerns.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Burnt Orange");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 22");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Aries, Sagittarius, Gemini, Libra\n" +
                        "  Neutral: Aries, Sagittarius, Gemini, Libra\n" +
                        "  Bad: Aquarius");
                }
                else if (zodiac == 6)
                {
                    Console.WriteLine("VIRGO (August 23- September 22)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Maiden\n" +
                        "  - Element: Earth\n" +
                        "  - Ruling Planet: Mercury\n" +
                        "  - Meticulous and Organized: Virgo individuals are often meticulous and highly organized. They pay close attention to details and have a natural talent for planning and organizing tasks efficiently.\n" +
                        "  - Service-Oriented: Virgos have a strong desire to be of service to others. They often excel in roles that involve helping or caring for people, making them great caregivers, healthcare professionals, or educators.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - You are becoming more familiar with your internal domain and its influence. Dreams are important now, as well as journaling; be sure to record your night-time dreams and, as well, the subjects of your day-time meditations.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Green");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 6");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Taurus, Capricorn, Cancer, Scorpio\n" +
                        "  Neutral: Gemini, Sagittarius, Aquarius, Aries\n" +
                        "  Bad: Pisces");
                }
                else if (zodiac == 7)
                {
                    Console.WriteLine("LIBRA (September 23 - Oct 22)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Scales\n" +
                        "  - Element: Air\n" +
                        "  - Ruling Planet: Venus\n" +
                        "  - Natural Diplomats: Libras are often seen as natural diplomats. They have a strong desire for peace and harmony and excel in resolving conflicts and finding middle ground in challenging situations.\n" +
                        "  - Charming and Sociable: Libras are known for their charm and sociability. They often have a wide circle of friends and enjoy socializing, as they thrive on the company of others.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - The recent Leo New Moon from mid-August highlighted changing perspectives on future plans, existing friendships, and group commitments, while equally emphasizing new ways for you to re-imagine intimacy with others and your own personal transformation.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Pink");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 5, 6, and 9");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Gemini, Aquarius, Leo, Sagittarius\n" +
                        "  Neutral: Capricorn, Cancer, Pisces, Taurus\n" +
                        "  Bad: Aries");
                }
                else if (zodiac == 8)
                {
                    Console.WriteLine("SCORPIO (October 23 - November 21)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Scorpion\n" +
                        "  - Element: Water\n" +
                        "  - Ruling Planet: Pluto and Mars\n" +
                        "  - Intense and Determined: Scorpios are known for their intense determination and unwavering focus. When they set their sights on a goal, they are willing to go to great lengths to achieve it.\n" +
                        "  - Magnetic and Mysterious: Scorpios often have a magnetic and mysterious aura that draws others to them. They may keep their true thoughts and feelings hidden beneath the surface, adding to their enigmatic appeal.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - This is a day of thorough-going reassessment of your friendships, group connections, and societal impact, plus your goals and plans moving forward. you will think of who you are and where you are heading.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Green");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 8 and 9");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Cancer, Pisces, Virgo, Capricorn\n" +
                        "  Neutral: Aquarius, Leo, Aries, Gemini\n" +
                        "  Bad: Taurus");
                }
                else if (zodiac == 9)
                {
                    Console.WriteLine("SAGITTARIUS (November 22 - December 21)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Centaur\n" +
                        "  - Element: Fire\n" +
                        "  - Ruling Planet: Jupiter\n" +
                        "  - Adventurous and Travel-Loving: Sagittarius individuals have a strong desire for adventure and travel. They are often drawn to exploring new places, cultures, and ideas and are natural wanderers.\n" +
                        "  - Straightforward and Honest: Sagittarians are known for their straightforward and honest communication style. They value honesty and may be blunt at times, but they speak their minds openly.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - This day will tackle your career. It nudges you to question what you do vocationally and how well that matches with your deepest principles and values.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Blue");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 3, 5, 6, 7, and 8");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Leo, Aries, Libra, Aquarius\n" +
                        "  Neutral: Pisces, Virgo, Taurus, Cancer\n" +
                        "  Bad: Gemini");
                }
                else if (zodiac == 10)
                {
                    Console.WriteLine("CAPRICORN (December 22- January 19)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Sea Goat\n" +
                        "  - Element: Earth\n" +
                        "  - Ruling Planet: Saturn\n" +
                        "  - Hardworking and Ambitious: Capricorns are known for their strong work ethic and ambition. They are often willing to put in the time and effort required to achieve their goals and climb the proverbial ladder of success.\n" +
                        "  - Reserved and Cautious: Capricorns tend to be reserved and cautious in their approach to life. They value stability and often take calculated risks rather than impulsive ones.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - Due to the elevated presence of Trickster Uranus located in the sector of your creative self-expression, there are a great many choices that you will likely encounter in exploring your creativity, with opportunities that must nevertheless be tested before going at them full speed ahead.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Blue");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 3, 7, 8, and 21");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Virgo, Taurus, Scorpio, Pisces\n" +
                        "  Neutral: Aries, Libra, Gemini, Leo\n" +
                        "  Bad: Cancer");
                }
                else if (zodiac == 11)
                {
                    Console.WriteLine("AQUARIUS (January 20 - February 18)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Water Bearer\n" +
                        "  - Element: Air\n" +
                        "  - Ruling Planet: Uranus & Saturn\n" +
                        "  - Humanitarian and Progressive: Aquarians are known for their strong humanitarian values. They often have a deep concern for social justice and are inclined towards making the world a better place. They are progressive thinkers who are open to new ideas and innovative solutions.\n" +
                        "  - Independent and Unique: Aquarians tend to be highly independent and value their individuality. They don't like to conform to societal norms and often embrace their unique qualities. This independence can sometimes make them appear unconventional.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - Renewed factors could come to light regarding current or future partnerships amidst also a certain degree of questioning and internal speculation about this important area. You are in the process of looking more deeply into what makes your relationship dynamic tick, and this engenders further changes in the way you see yourself and your belief systems.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Blue");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 4");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Libra, Gemini, Sagittarius, Aries\n" +
                        "  Neutral: Taurus, Scorpio, Cancer, Virgo\n" +
                        "  Bad: Leo");
                }
                else if (zodiac == 12)
                {
                    Console.WriteLine("PISCES (February 19 - March 20)\n");
                    Console.WriteLine("SIGN FACTS:\n" +
                        "  - Symbol: Two Fish\n" +
                        "  - Element: Water\n" +
                        "  - Ruling Planet: Neptune\n" +
                        "  - Empathetic and Compassionate: Pisces individuals are highly empathetic and compassionate. They often feel deeply for others and are willing to help those in need, making them natural caregivers and friends.\n" +
                        "  - Artistic and Creative: Many Pisceans have a strong artistic and creative streak. They often excel in artistic pursuits such as music, visual arts, writing, and dance.");
                    Console.WriteLine("\nHOROSCOPE FOR THE DAY:\n" +
                        "  - Your thoughts could be somewhat scattered now, and yet also brilliant in their conceptualizations.");
                    Console.WriteLine("\nLUCKY COLOR:\n" +
                        "  - Yellow");
                    Console.WriteLine("\nLUCKY NUMBER:\n" +
                        "  - 3 and 7");
                    Console.WriteLine("\nSIGN COMPATIBILITY:\n" +
                        "  Good: Scorpio, Cancer, Capricorn, Taurus\n" +
                        "  Neutral: Sagittarius, Gemini, Libra, Leo\n" +
                        "  Bad: Virgo");
                }
                else Console.WriteLine("Invalid number!");
            }
            else if (chosenProg == 2)
            {
                String name;
                int score = 0;
                char a1, a2, a3, a4, a5, seeScore;

                Console.WriteLine("-- SIMPLE QUIZ--");

                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.WriteLine("Type the letter with your corresponding answer.");
                Console.WriteLine("QUESTION #1: What is 5+10?: ");
                Console.WriteLine("a) 15\n" +
                    "b) 50\n" +
                    "c) 5\n" +
                    "d) 20");
                Console.Write("ANSWER: ");
                a1 = Char.Parse(Console.ReadLine());
                if (a1 == 'a')
                {
                    score++;
                }


                Console.WriteLine("\nQUESTION #2: What is the square root of 49?: ");
                Console.WriteLine("a) 4\n" +
                   "b) 7\n" +
                   "c) 5\n" +
                   "d) 6");
                Console.Write("ANSWER: ");
                a2 = Char.Parse(Console.ReadLine());
                if (a2 == 'b')
                {
                    score++;
                }

                Console.WriteLine("\nQUESTION #3: What is 5x2-1?");
                Console.WriteLine("a) 5\n" +
                   "b) 8\n" +
                   "c) 9\n" +
                   "d) 3");
                Console.Write("ANSWER: ");
                a3 = Char.Parse(Console.ReadLine());
                if (a3 == 'c')
                {
                    score++;
                }

                Console.WriteLine("\nQUESTION #4: If x = 3, evaluate 5x: ");
                Console.WriteLine("a) 15\n" +
                   "b) 150\n" +
                   "c) 8\n" +
                   "d) 50");
                Console.Write("\nANSWER: ");
                a4 = Char.Parse(Console.ReadLine());
                if (a4 == 'a')
                {
                    score++;
                }

                Console.WriteLine("\nQUESTION #5: What is the proper order of operation?: ");
                Console.WriteLine("a) MDAS\n" +
                   "b) EMDAS\n" +
                   "c) SADMEP\n" +
                   "d) PEMDAS");
                Console.Write("ANSWER: ");
                a5 = Char.Parse(Console.ReadLine());
                if (a5 == 'd')
                {
                    score++;
                }

                Console.WriteLine();

                Console.Write("You finished the quiz! Would you like to see your scores? [Y/N]: ");
                seeScore = Char.Parse(Console.ReadLine());

                if (seeScore == 'Y' || seeScore == 'y')
                {
                    Console.WriteLine("NAME: " + name);
                    Console.WriteLine("SCORE: " + score);
                    if (score == 5)
                    {
                        Console.WriteLine("Congrats, you got a perfect score, " + name + "!");
                    }
                    else Console.WriteLine("Thanks for playing.");
                }
                else if (seeScore == 'N' || seeScore == 'n')
                {
                    Console.WriteLine("Thank you for playing the game!");
                }
            }
            else Console.WriteLine("Invalid answer.");

            Console.ReadKey();
        }
    }
}
