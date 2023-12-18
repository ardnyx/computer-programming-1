using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Little_Landlord_s_Secret;
using System.Runtime.InteropServices;
using System.Threading;

public class Ending2
{
    public static string kateMap()
    {
        Game currentGame = new Game();
        currentGame.StartkateRoom();
        return "";
    }
    public static string kateRoomCaught()
    {
        SetCursorPosition(0, 0);
        Clear();
        say($"(You hear the Mrs. Helen’s footsteps coming towards you, as if she was trying to catch a thief.)");
        say($"Mrs. Helen: {Program.player}, what are you up to?");
        say($"{Program.player}: Nothing, I just saw Kate’s room filled with letters. Does she ever open them? It’s gonna take her a while to finish them all!");
        say($"Mrs. Helen: And why? That’s none of your business! Don’t mess with stuff you don’t own. Clean this place up!");
        say($"(Mrs. Helen gets angry. Being nervous, you leave some letters at the door. She tells you to go back to the sofa and wait.)");
        say($"{Program.player}: That.. was close.");
        say($"{Program.player}: I'm panicking.. no.. I have to investigate this further.. Grandpa..");
        say(" (As you sat down at the sofa, you felt something hollow.");
        return ChoiceSelector.choiceSomethingHollow();
    }
    public static string investigateSofa()
    {
        say($"You did actually manage to find something suspicious in those hollow spots. There, you found something that looks like scratches from a person getting dragged! \n" +
            $"There were also bloodstains and even a whole fingernail under the sofa! You get shocked, traumatized even! While looking into the sofa, you hear Mrs. Helen sprinting towards you.");
        say($"Mrs. Helen: What the hell are you doing now {Program.player}?!");
        say($"{Program.player}: Is this from a body?! What the hell happens in this place??!! What did you do to my grandfather?");
        say($"Mrs. Helen: Oh that old hag? I don’t know. Did you check who was in the sofa?");
        say($"{Program.player}: Oh my god! What did you do to him? You’re so sick! So sick!");
        say($"Mrs. Helen: Don’t cry {Program.player}, he’s in a better place now.");
        say($"{Program.player}: Better place? Are you out of your goddamn mind?! You killed him! My poor grandfather. You’re gonna pay for this.");
        say($"Mrs. Helen: Pay for what? You’re both-");
        return ChoiceSelector.choiceRagedUser();
    }
    public static string continueListening()
    {
        say($" (Mrs. Helen gets irritated with you poking your nose into her stuff, forcing her to grab and get in a fight with you.)");
        say($" (You and Mrs. Helen get into a fight. While in the middle of fighting, You got surprised with the strength of the Mrs. Helen despite her old age.");
        say($"{Program.player}: (Grunting) You're pretty strong for a woman of your age.");
        say($"Mrs. Helen: (Laughs) How did you think I killed your grandfather then?");
        say($"{Program.player}: You should go to hell!");
        return keepWrestling();
    }
    public static string tackleLandlady()
    {
        say($"(As you tackled Mrs. Helen, You didn’t expect the strength from a woman in their sixties. She’s insanely strong!)");
        say($"Mrs. Helen: (heavy breathing) Did you think I’m weak? How do you think they died then?");
        say($"{Program.player}: You! Just! Won’t! Shut! Up!");
        say($"Mrs. Helen: You’re gonna end up like the rest of them. Better get ready for this!");
        return ChoiceSelector.choiceEscape();
    }
    public static string keepWrestling()
    {
        say($" (You kept on wrestling against Mrs. Helen.)");
        say($" (You can't keep going on with this!)");
        Clear();
        for (int i = 0; i < 3; i++)
        {
            say(".");
        }
        Clear();
        return escapelandlady();
    }
    public static string escapelandlady()
    {
        say($" (You managed to get out from the grips of Mrs. Helen. Thinking that you are safe from her, she lunges at you once again!)");
        say($"Mrs. Helen: (smiling menacingly) I’m gonna dice you up and cut you up like the rest of them!");
        say($"{Program.player}: Psychopath! You’re gonna pay for this you old hag!");
        say($"(Mrs. Helen manages to cut you once. You scream in pain but you still manage to get away from her for the meantime.)");
        return ChoiceSelector.choiceRunOrMock();
    }
    public static string Finale()
    {
        say($"(You managed to escape. Mrs. Helen might have been surprisingly strong but she still has her old woman speed. She screams your name in pain, " +
            $"revealing that she also got cut with the knife.)");
        say($"Mrs. Helen: {Program.player}! You’re gonna pay for this!");
        say($"{Program.player}: To hell with you! I’m gonna call the authorities you old hag.");
        say($"You get a phone and start calling the authorities. As you call on the phone, you rest near the front of the boarding house still hurt from the injuries. " +
            $"Both the you and Mrs. Helen slowly lose consciousness until sirens and flashing lights arrive at the scene.)");
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
        return "Ending 2";
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
