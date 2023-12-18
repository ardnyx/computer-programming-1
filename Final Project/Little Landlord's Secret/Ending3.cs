using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Little_Landlord_s_Secret;

public static class Ending3
{
    public static string Ending3P2()
    {
        say($"{Program.player}: What the heck happened here? This doesn’t look like my father’s fingernail. Or is it?");
        say($"{Program.player}: Wait, could it be?");
        say($" (You suddenly recognize the distinct gold signet ring your grandfather always wore. " +
            $"He’s superstitious after all, and he always believed that wearing the ring would bring good luck. You suddenly freaked out and froze in the moment.");
        say($"{Program.player}: How could this be? She couldn’t possibly be this sick and twisted to do stuff like this.");
        return ChoiceSelector.choiceExitAttempt();
    }
    public static string Ending3P3()
    {
        say($"{Program.player}: This place is so sick! So sick! Whoever did this should go to hell!");
        say($" (As you approach the exit, you are stopped by Mrs. Helen who seemingly knew that she will go outside despite cooking in the kitchen.)");
        say($"Landlady: Hello {Program.player}, where do you think you’re going?");
        say($"{Program.player}: (internal dialogue) Oh no, how can she notice me? She was just cooking in the kitchen, it can’t be!");
        say($"Mrs. Helen: I just finished preparing the meal. I was supposed to cook but I just microwaved some pizza to not keep you waiting.");
        say($"{Program.player}: (internal dialogue) Phew! I thought she was onto me.");
        say($"{Program.player}: Oh I was just going outside to catch some fresh air.");
        say($"Mrs. Helen: Alright then, food’s ready!");
        say($"As both of you approach the kitchen, Mrs. Helen noticed her sofa is out of place and open.");
        say($"Mrs. Helen:(surprised) D-did you do something to the sofa?");
        say($"{Program.player}: No I didn’t, but it did move when I sat on it a while ago. Mind if I ask, (speaks nervously) what the heck is that under the sofa?");
        say($"Mrs. Helen: You know you shouldn’t mess with stuff that’s none of your business, right?");
        say($"{Program.player}: What? I’m just asking what is under the sofa.");
        say($"Mrs. Helen: (laughs menacingly) Do you really want to know?");
        say($"{Program.player}: Actually, I don’t like where this is going right now.");
        say($"Mrs. Helen: No, no. Actually, just sit here. You want to know what happened to your grandfather, right?");
        if (!Map.rustyknife && Map.pickedupknife)
        {
            say($"In a surprise move, Mrs. Helen pulled out a RUSTY KNIFE from her back pocket! She has caught you off guard and unarmed.");
            ForegroundColor = ConsoleColor.Red;
            say($"I shouldn't have given that kni-!");
            ResetColor();
        }
        else
        {
            say($" (Mrs. Helen slowly clings toward you, whispering-)");
            say($"Mrs. Helen: That rusty knife, it's on you, right?");
            say($" (As she speaks, she slowly reaches her hand towards your pocket, and brings back her rusty knife.)");
            Map.rustyknife = false;
            say($"Mrs. Helen: I know you lied to me awhile ago when I asked you about this.");
            say($"{Program.player}: !");
            say($"{Program.player}: (agitated) s-so what?!");
            say($"Mrs. Helen: Heh-heheheh. Well-");
            say($"Mrs. Helen: It just so happened that I used it for your grandfather.");
            say($"{Program.player}: -!");
        }
        return ChoiceSelector.choiceFollowOrders();

    }
    public static string Ending3P4()
    {
        say($"Mrs. Helen: Now I’m gonna cut you up like what I did to your grandfather. Actually, no. I’m gonna do you worse.");
        say($"{Program.player}: P-Please don’t kill me.");
        say($"Mrs. Helen: Begging ain’t gonna do you no good young {Program.player}.");
        say($"As Mrs. Helen goes and ties {Program.player} up, three knocks from the door are heard.");
        say($"Officer: Police! Police! We are responding to a distress signal reported at this address.");
        say($"Mrs. Helen: What? How? ");
        say($"{Program.player}: Do you really think I did not know what you were up to all this time? (smirks)");
        say($" (Officer, {Program.player}, and Mrs. Helen are gathered for questioning.)");
        say($"Officer: (flipping through notes) Mrs. Puente, we received a missing person report about one of your tenants. Can you provide any information that might help us locate him?");
        say($"Mrs. Helen: (smiling nervously) Oh, Officer, I've been telling you, that {Program.player} is up to something. Always acting suspicious, you know? I bet they're trying to frame me.");
        say($"{Program.player}: (confused) What? No, Officer, I—");
        say($"Officer: (raising an eyebrow) Mrs. Puente, let's focus on Mr. Anderson's disappearance. Do you recall when you last saw him?");
        say($"Mrs. Helen: (acting innocent) Well, I can't be expected to remember every little detail, can I? {Program.player}, on the other hand, has been acting so strange lately. Coming and going at odd hours.");
        return ChoiceSelector.choicePanicked();

    }
    public static string Ending3P5()
    {
        say($"Officer: (leaning forward) Mrs. Puente, let's stick to the matter at hand. Can you provide an alibi for the time Mr. Anderson went missing?");
        say($"Mrs. Helen: (feigning surprise) Alibi? Why would I need one? You should be asking {Program.player}, Officer. They're the ones causing trouble here.");
        say($"{Program.player}: (exasperated) Officer, I swear, I have nothing to do with this. Mrs. Puente is trying to distract you.");
        say($"Officer: (rubbing his temples) Mrs. Puente, I need your cooperation. We're trying to find Mr. Anderson. If you have any relevant information, please share it.");
        say($"Mrs. Helen: (acting offended) Relevant information? Oh, Officer, I'm just a simple Mrs. Helen trying to run a respectable establishment. {Program.player}, on the other hand, is trying to ruin my reputation.");
        return ChoiceSelector.choiceAskforInvestigation();

    }
    public static string Ending3Finale()
    {
        say($"As the conversation continues, Officer becomes increasingly skeptical of Mrs. Helen’s attempts to divert attention. He starts noticing inconsistencies in her story.");
        say($"Officer: (firmly) Mrs. Puente, I've heard enough. {Program.player} I believe you. Mrs. Puente, you're under arrest for obstructing justice and providing false information.");
        say($"Mrs. Helen: (shocked) What? This is absurd! You can't believe {Program.player} over me!");
        say($"Officer: (handcuffing Mrs. Puente) The evidence and your inconsistent statements speak for themselves. {Program.player}, thank you for your cooperation. We'll continue our investigation.");
        say($"Officer escorts Mrs. Helen out, leaving {Program.player} in the room, vindicated.");
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
        return "Ending 3 Finale";

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