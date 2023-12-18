using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class normalEnding
    {
        public static bool haveReadLetter = false;
        public static string StoryIntroduction()
        {
            Clear();
            say(" (In an abandoned alleyway late at night, You encounter a disheveled man clutching a sealed envelope)");
            return ChoiceSelector.choice_abandonedAlleyway();
        }

        public static string HelpAnonymousMan()
        {
            say($"{Program.player}: Hey, are you okay? You look troubled.");
            say($"Anonymous Man:[Breathing Heavily] Please, take this. It's for you.");
            say(" (The anonymous man tries to hand over the sealed envelope to you.)");
            return ChoiceSelector.choice_holdingSomething();
        }

        public static string AskAnonymousMan()
        {
            say($"{Program.player}: What's this about? Who are you?");
            say($"Anonymous Man: No time... [coughs] ...just read it.");
            say($" (While gasping for air, The Anonymous Man staggered, collapsing to the ground.)");
            say($"{Program.player}: [Startled] Hey! Are you alright? Someone please help!");
            say($"Anonymous Man: [Weakly] No use... [struggles to speak] ...it's... too late for me. Find... truth.");
            say($"{Program.player}: [Urgently] Hold on! I'll call for an ambulance!");
            say($"Anonymous Man: [Whispers] No...");
            say($" (As the man closes his eyes, he takes his last breath before dying...)");
            say($"{Program.player}: [Panicked, checking pulse] No, no, please...");
            say($" (Realizing the Anonymous Man has passed away, {Program.player} notices the sealed envelope clutched tightly in his hand.)");
            return ChoiceSelector.choiceEnvelope();
        }
        public static string ReadEnvelope()
        {
            Clear();
            haveReadLetter = true;
            say($"Dear {Program.player},\n\n" +
                $"Your grandfather's absence isn't a mere vanishing act. It's a thread in the tangled web that lurks within those walls. His story is just one piece of a larger puzzle, lost amid the murkiness of this place.\n\n" +
                $"Every corner within that house holds echoes of something concealed, waiting for a curious eye to uncover. Your journey will depend on the choices you make, the threads you choose to follow.\n\n" +
                $"Beware, for not everything will be as it appears. Trust will be a luxury you cannot afford, and truth will wear many masks.\n\n" +
                $"The Landlord’s Little Secret isn't a place of comfort; it's a labyrinth of uncertainties. Tread carefully, for the answers you seek are entwined within its mysteries.\n");
            return ChoiceSelector.choiceLetterContent();
        }

        public static string GoToHouse()
        {
            say($" (You have decided to proceed towards the boarding house. After a few hours of packing and traveling, you have arrived at the Tranquil Oaks Boarding House.)");
            return ChoiceSelector.choiceHouseArrived();
        }

        public static string pushDoorbell()
        {
            say(" (Door Unlocks, revealing an amicable old lady holding a vacuum cleaner while wearing an apron.)");
            say($"Mrs. Helen: Oh! It’s you {Program.player}, how may I help you? Are you here to get your grandfather's things?");
            return ChoiceSelector.choiceMeetLandlady();
        }
        public static string checkInOnHer()
        {
            say($"{Program.player}: I'm doing pretty well. Although I'm still not used to it, I have to get through and live on for him as well, right?");
            say($"Mrs. Helen: Haha, yeah. Well, what brought you here today? Are you here to pick up his things?");
            return confirmGuess();
        }
        public static string confirmGuess()
        {
            say($"{Program.player}: You’re right, my grandfather’s things are our last memory of him after all as the authorities still don't have any clues regarding his disappearance. They told us that the chances are very slim considering my grandfather’s condition");
            say($"Mrs. Helen: I just wanna say, I’m very sorry for what happened. I will take responsibility and provide as much compensation that I can handle.");
            say($"{Program.player}: We know that you’re not at fault, we already talked about it when the police were first involved. We are also at fault, we prioritized our careers more instead of taking care of the person who helped all of us establish ourselves.");
            say($"Mrs. Helen: Alright. Come in, come in! I’ll prepare some food for you. You can feel at home, {Program.player}.");
            ChoiceSelector.choiceInsideHouse();
            return "";
        }

        public static string sitLivingRoom()
        {
            say($"You decided to sit in the living room and look around, but when you sat down on the wooden sofa, you felt something hollow.");
            return ChoiceSelector.choiceSomethingHollow();
        }

        public static string investigateSofa()
        {
            say($" (You decided to find something suspicious in those hollow spots.)");
            say($" (There you found something that looks like scratches from a person getting dragged.)");
            say($" (There were also bloodstains and even a whole fingernail under the sofa.)");
            return ChoiceSelector.choiceInvestigateSofa();
        }

        public static string confrontOldLady()
        {
            Clear();
            if (Map.buryingcorpse)
            {
                say($" (After all of your unusual encounters and experiences within the house, you now decided to confront Mrs. Helen.)");
            }
            else if (Map.rustyknife)
            { 
                say($" (You decided to confront Mrs. Helen in the kitchen. Your rusty knife could help you defend yourself, but at what cost?)");
            }
            else
            {
                say($" (You decided to confront Mrs. Helen in the kitchen but you don't have anything on hand that can help you defend yourself)");
            }
            return ChoiceSelector.choiceConfrontLady();
        }
        public static string moretime()
        {
            say(" (You have to decide how to confront her. Going in for the kill immediately will incur some risks, but it'll give you the choice on whether or not she'll survive)");
            return ChoiceSelector.moretime();
        }
        public static string pullKnife()
        {
            if (Map.fetchcorns)
            {
                say($"{Program.player}: Mrs. Helen, I need to talk to you about something. I saw something in your garden when I was fetching up some corns for you.");
                say($"Mrs. Helen: ...");
                say($"{Program.player}: Hm? Then I'll continue.");
            }
            else if (Map.joneroom)
            {
                say($"{Program.player}: Mrs. Helen, I need to talk to you about something. I saw someting around Mr. Jone's room when I was having a quick tour around the house.");
                say($"Mrs. Helen: Hm? What is it?");
            }
            else
            {
                say($"{Program.player}: Mrs. Helen, I need to talk to you about something.");
                say($"Mrs. Helen: Hm? What is it?");
            }
            say($"{Program.player}: Actually, someone gave me a letter yesterday. The letter said that you have some involvement in my grandfather’s disappearance.");
            say($"Mrs. Helen: Do you believe him?");
            return ChoiceSelector.choiceHearOtherSide();
        }

        public static string listenToLady()
        {
            say($"{Program.player}: Maybe I do, maybe I don’t. I definitely need to hear your side of the story.");
            say($"Mrs. Helen: I don't look like you want to hear anything from me, {Program.player}, you look very angry right now.");
            say($"{Program.player}: What are you trying to say?");
            say($"Mrs. Helen: I guess you’ll be angrier when you figure out everything.");
            say($"{Program.player}: Are you just admitting to it like that?");
            say($"Mrs. Helen: Oh, no one’s admitting anything. I just wanna say that, what you’re trying to figure out is something that you can ask directly to your grandfather.");
            say($"{Program.player}: What? You know where he is?!");
            say($"Mrs. Helen: Well of course I do, he’s around many places. I put him there myself!");
            return ChoiceSelector.choiceContinueTalking();
        }

        public static string investigateLadyFurther()
        {
            say($"{Program.player}: What do you mean?");
            say($"Mrs. Helen: You know what that means, I divided him. He and his stupid student wanted to act like police officers when I’m trying to do my business here! " +
                $"I guess that crazy bloke died too, he even made the letter he gave you very cryptic. " +
                $"He’s a stupid guy until his last breath!");
            say($"{Program.player}: You…");
            return ChoiceSelector.choiceInvestigateFurther();
        }

        public static string attackAttempt()
        {
            say($" (You decided to lunge towards her, but you didn’t expect the strength from a woman in their sixties. She’s insanely strong!)");
            say($"Mrs. Helen: (heavy breathing) Did you think I’m weak? How do you think they died then?");
            say($"{Program.player}: You! Just! Won’t! Shut! Up!");
            say($"Mrs. Helen: (laughs crazily) It’s because of this you moron!");
            say($" (She smashed her own head on you, disregarding her own safety!)");
            say($" (This is your last choice, your fate will be determined by this choice!)");
            return ChoiceSelector.choiceAttackAttempt();
        }

        public static string grabKnifeToAttack()
        {
            say($" (You got stood up but not without stomping on her foreleg.)");
            say($" (Mrs. Helen bit on your calf without hesitation. You instantly fainted.");
            if (Map.rustyknife)
            {
                say($" (Filled with rage, you instantly went back up and reached for the rusty knife that you've kept at your pocket.)");
            }
            else
            {
                say($" (Filled with rage, you instantly went back up and headlocked her.");
                Map.headlock = true;
            }
            return ChoiceSelector.choiceNormalEnding();
        }
        public static string perfectrunEnding()
        {
            say($"{Program.player}: Just so you know, I’m now the one to decide. Before I kill you, I need to know, where are my grandfather’s remains?");
            say($"Mrs. Helen: (whispers) You’re very arrogant for someone with a wasted leg (laughs weakly). Well, all I can say is only his limbs are with me, they’re in my garden along with the other bodies. " +
                $"All the others? You have to figure it out yourself (laughs with all her might)");
            say($" (As you were about to punch her, you saw the landlady play with her dentures, " +
                $"revealing a small capsule that she immediately swallowed. In just a little over ten seconds, the heartbeat of the landlady stopped.");
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
            return "Normal Ending - Finale -";
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            while (ReadKey(true).Key != ConsoleKey.DownArrow)
            {
            }
        }
    }
}
