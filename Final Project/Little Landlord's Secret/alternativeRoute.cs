using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    class alternativeRoute
    {
        public static bool declinedPhone { get; private set; } = false;
        public static bool wentHome { get; private set; } = false;
        public static string altRouteStart()
        {
            say($"The anonymous man screamed at you using his last remaining strength.");
            return GoHome();
            
        }
        public static string threwPhoneandWentHome()
        {
            declinedPhone = true;
            say($" (Out of fear and suspicion, you declined the phone call.)");
            say($".");
            ForegroundColor = ConsoleColor.Green;
            say($" ** 1 unread message **");
            ResetColor();
            return normalEnding.ReadEnvelope();
        }
        public static string GoHome()
        {
            wentHome = true;
            if (ChoiceSelector.destroyEnvelope)
            {
                ForegroundColor = ConsoleColor.Red;
                BackgroundColor = ConsoleColor.Black;
                say($"YOU DESTROYED THE ENVELOPE");
                ResetColor();
            }
            say($"(Anyway, you decided to go home and treat what you saw as a bad dream. Although, it's not something that is easily forgettable.)");
            say($"{Program.player}: That was.. weird. But I'm really tired.");
            say($" (You went straight to sleep afterwards.)");
            return slept();
        }
        public static string slept()
        {
            say($"You just woke up from a not so good sleep when you suddenly heard a subtle knock on your door.");
            return ChoiceSelector.subtleKnock();
        }
        public static string outsideDoor()
        {
            WriteLine($"You didn't see anyone outside your door, the only thing there is a small envelope at the edge of the door.\n");
            WriteLine($" -- Press Spacebar to read the letter --\n");
            ChoiceSelector.lettercount++;
            ConsoleKey keyPressed;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
            } while (keyPressed != ConsoleKey.Spacebar);
            return normalEnding.ReadEnvelope();
        }
        public static string crazyPrank()
        {
            say($"You received a call from an unknown number. Chills run down your spine as you suspect someone observing you.");
            return ChoiceSelector.phoneCall();
        }
        public static string phoneCall()
        {
            say($"[Filtered voice] You have to understand that this isn't some sick joke. We have already failed, you need to do your part as the grandchild, only you can do it.");
            return ChoiceSelector.choiceLetterContent();
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
