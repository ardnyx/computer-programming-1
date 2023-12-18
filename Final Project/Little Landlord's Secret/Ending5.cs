using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending5
    {
        public static string Ending5s()
        {
            say($"While running without looking properly, you were successfully trapped by Mrs. Helen. She laughs.");
            say("Mrs. Helen: You must be some kind of stupid to not figure out why I can kill all those people way younger than me, I know every nook and cranny of this house. No one can just run around aimlessly");
            say(" (She was able to catch up to you in no time, the sprain in your foot is not something that you experienced before, the pain as well as the fear of for her made you defecate on your own clothes, that was the last moment you remember in this life.");
            ForegroundColor = ConsoleColor.Red;
            say(" (You died full of regrets.)");
            ResetColor();
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
            return "Ending 5 Finale";
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