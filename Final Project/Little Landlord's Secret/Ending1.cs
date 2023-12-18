using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    class Ending1
    {
        public static string removeEvidence()
        {
            say($"You were able to get rid of your own presence in the garden, and you were able to make a quick break to the police station.");
            return ChoiceSelector.choiceNextMove();
        }
        public static string reportPolice()
        {
            Clear();
            say($"You were able to inform the authorities on time, without arousing any suspicion from Mrs. Helen, you were able to get justice for your grandfather without being harmed, you were rewarded by your city for your bravery and were thanked by the families of the other victims");
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
            return "Ending 1 Finale";
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
