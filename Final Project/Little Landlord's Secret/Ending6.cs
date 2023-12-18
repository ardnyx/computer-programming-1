using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending6
    {
        public static string Ending6Part1()
        {
            say($"{Program.player}: Can you hear her? She's absurd! Why are you still not arresting her? I'm going to sue you incompetent police as well!");
            say($"(Your threat did not make the officers happy, they started seeing you in the same light as Mrs. Helen as your agitated look made it seem like you're guilty)");
            say($"Police Officer: Don't worry, sir, we'll serve justice to those who deserve it..");
            return ChoiceSelector.choiceAngrytoPolice();
        }
        public static string Greed()
        {
            say($" (You became greedy and arrogant that you forgot about the noises and didn't notice that the police were called.");
            if (Map.rustyknife || Map.headlock)
            {
                say($" (They saw you as soon as you just finished killing the landlady, leaving you shocked, getting you arrested, and charged for murder.)");
            }
            else
            {
                say($" (They saw you as you were torturing the already dead landlord, getting you arrested and charged for murder.)");
            }
            Environment.Exit(0);
            return "Ending 6 Finale";
        }
        public static string angryToOfficer()
        {
            say($"Police Officer: I think you've had enough time to sort yourself out. You're just disrespecting us at this point. " +
                $"Now, regardless if you're the suspect or not, you need to go to the police station first!");
            say($" (When you were taken into custody  by the police, Mrs. Helen made sure to plant evidences including your fingerprints in the corpses in the garden, because of this, every single person doubted you. " +
                $"Because of the accusations, you experienced a severe mental breakdown and even believed the accusations that were put to you yourself. " +
                $"Mrs. Helen is still free, and your incarceration buried the the doubts that are lingering around that boarding house.)");
            Clear();
            say(@"
  _______ _            ______           _ 
 |__   __| |          |  ____|         | |
    | |  | |__   ___  | |__   _ __   __| |
    | |  | '_ \ / _ \ |  __| | '_ \ / _` |
    | |  | | | |  __/ | |____| | | | (_| |
    |_|  |_| |_|\___| |______|_| |_|\__,_|             
");
            Environment.Exit(0);
            return "Ending 6 Finale";
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            while (ReadKey(true).Key != ConsoleKey.DownArrow)
            {
                // Continue consuming keys until Enter is pressed
            }
        }
    }
}
