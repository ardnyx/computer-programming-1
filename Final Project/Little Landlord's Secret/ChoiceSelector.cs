using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Landlords_Little_Secret;
using Little_Landlord_s_Secret;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;

public static class ChoiceSelector
{
    public static int lettercount = 0;
    public static bool answeredPhone = false;
    public static bool wentHome => alternativeRoute.wentHome;
    public static bool declinedPhone => alternativeRoute.declinedPhone;
    public static bool throwPhone { get; private set; } = false;
    public static bool destroyEnvelope { get; private set; } = false;
    public static bool wrestleLandlady { get; private set; } = false;
    public static bool map { get; private set; } = false;
    public static bool earlyStab { get; private set; } = false;

    /* ALTERNATIVE ENDING */
    public static string subtleKnock()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Answer the door",
            "B. Sleep Again\n"
        });
        if (choice == 1)
        {
            return alternativeRoute.outsideDoor();
        }
        else
        {
            WriteLine($"You wake up to three loud knocks coming from outside!");
            ReadKey();
            WriteLine("\nYou need to do something about the noise!\n");
            ReadKey();
            return alternativeRoute.outsideDoor();
        }
    }
    /* NORMAL ENDING (PERFECT RUN)
 _   _  ___  ____  __  __    _    _       _____ _   _ ____ ___ _   _  ____ 
| \ | |/ _ \|  _ \|  \/  |  / \  | |     | ____| \ | |  _ \_ _| \ | |/ ___|
|  \| | | | | |_) | |\/| | / _ \ | |     |  _| |  \| | | | | ||  \| | |  _ 
| |\  | |_| |  _ <| |  | |/ ___ \| |___  | |___| |\  | |_| | || |\  | |_| |
|_| \_|\___/|_| \_\_|  |_/_/   \_\_____| |_____|_| \_|____/___|_| \_|\____|*/
    public static string choice_abandonedAlleyway()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Try to help the anonymous man.",
            "B. Continue going home.\n" });
        switch (choice)
        {
            case 1:
                return normalEnding.HelpAnonymousMan();
            case 2:
                return alternativeRoute.altRouteStart();
            default:
                return "Invalid";
        }
    }
    public static string choice_holdingSomething()
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. Run away from the man, what he's holding might be dangerous!",
            "B. Ask him about the thing that he's trying to give you as well as his identity.\n" });
        if (choice == 2)
        {
            return normalEnding.AskAnonymousMan();
        }
        else
        {
            return alternativeRoute.altRouteStart();
        }
    }
    public static string choiceEnvelope()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Pick up the sealed envelope and read the content.",
            "B. Destroy the sealed envelope without reading its content.\n" });
        if (choice == 1)
        {
            return normalEnding.ReadEnvelope();
        }
        else
        {
            destroyEnvelope = true;
            return alternativeRoute.GoHome();
        }
    }
    public static string choiceLetterContent()
    {
        List<string> choices;

        if (answeredPhone)
        {
            choices = new List<string>
            {
                "A. ???!!\n"
            };
        }
        else if (declinedPhone && lettercount >= 2)
        {
            choices = new List<string>
            {
                "A. No.. way..\n"
            };
        }
        else if (lettercount >= 2)
        {
            choices = new List<string>
            {
                "A. What.. the fuck?! This letter-\n"
            };
        }
        else
        {
            choices = new List<string>
            {
                "A. I guess I’ll try to go, I need to get gramps’ belongings from there anyway. I doubt there will be anything to see.",
                "B. This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!\n"
            };
        }
        int choice = choiceTemplate(choices.Count, 2, choices);
        if (choice == 1)
        {
            if (answeredPhone)
            {
                say($"{Program.player}: Who.. was that?");
                say($"{Program.player}: But as stupid as it sounds, I really have to go.");
            }
            else if (declinedPhone && lettercount >= 2)
            {
                say($"{Program.player}: This.. I can't.. but I have to go.");
            }
            else if (lettercount >= 2)
            {
                say($"{Program.player}: Stay calm-- stay calm.");
                say($"{Program.player}: Let's go then.");
            }
            return normalEnding.GoToHouse();
        }
        else
        {
            lettercount++;
            return alternativeRoute.crazyPrank();
        }
    }
    public static string phoneCall()
    {
        List<string> choices = new List<string>
        {
            "A. Answer the phone call",
            "B. Throw your phone away and hide in your house.\n"
        };

        if (wentHome)
        {
            choices[1] = "B. Decline the phone call\n";
        }

        int choice = choiceTemplate(2, 1, choices);

        if (choice == 1)
        {
            answeredPhone = true;
            return alternativeRoute.phoneCall();
        }
        else if (wentHome)
        {
            return alternativeRoute.threwPhoneandWentHome();
        }
        else
        {
            throwPhone = true;
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Black;
            WriteLine("YOU THREW YOUR PHONE AWAY\n");
            ResetColor();
            ReadKey();
            return alternativeRoute.GoHome();
        }
    }

    public static string choiceHouseArrived()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Push the doorbell and try to look approachable towards the elderly landlady as much as possible.",
            "B. Knock on the door and wait with a straight face, trying to look as unaware as possible.\n" });
        if (choice == 1)
        {
            return normalEnding.pushDoorbell();
        }
        else
        {
            return normalEnding.pushDoorbell();
        }
    }

    public static string choiceMeetLandlady(bool clearConsole = true)
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. Check in on her instead, just in case she says something confirming the contents of the letter.",
            "B. Confirm her guess, lest she suspects something.\n" });
        if (choice == 2)
        {
            return normalEnding.confirmGuess();
        }
        else
        {
            return normalEnding.checkInOnHer();
        }
    }

    public static void choiceInsideHouse()
    {
        Clear();
        WriteLine($@"
  ______            _                 _   _               __  __           _      
 |  ____|          | |               | | (_)             |  \/  |         | |     
 | |__  __  ___ __ | | ___  _ __ __ _| |_ _  ___  _ __   | \  / | ___   __| | ___ 
 |  __| \ \/ / '_ \| |/ _ \| '__/ _` | __| |/ _ \| '_ \  | |\/| |/ _ \ / _` |/ _ \
 | |____ >  <| |_) | | (_) | | | (_| | |_| | (_) | | | | | |  | | (_) | (_| |  __/
 |______/_/\_\ .__/|_|\___/|_|  \__,_|\__|_|\___/|_| |_| |_|  |_|\___/ \__,_|\___|
             | |                                                                  
             |_|                                                                  
");
        WriteLine(@"> You are now inside the Tranquil Oaks Boarding House.");
        WriteLine("> You are free to explore the house as you wish.");
        WriteLine("> This mode will end if you trigger an event or interaction, \n" +
            "  and will bring you back to the linear progression of the story.");
        ReadKey();
        Write("\n> And gather some clues ");
        ForegroundColor = ConsoleColor.Red;
        Write("WHILE YOU'RE AT IT");
        ResetColor();
        Write(".");
        ReadKey();
        WriteLine("\n\n -- C O N T R O L S --");
        WriteLine(@"
> Your position is being represented by O
> Use the arrow keys (UP, DOWN, LEFT, RIGHT) to navigate");
        ReadKey();
        Game house = new Game();
        house.StartHouse(35,14);
    }
    public static string choiceSomethingHollow()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Huh? I need to look into this more.",
            "B. If there’s anything suspicious, it has to be in my grandfather’s room, not in some place like the living room sofa.\n" });
        if (choice == 1)
        {
            return normalEnding.investigateSofa();
        }
        else
        {
            return Ending2.investigateSofa();
        }
    }
    public static string choiceInvestigateSofa()
    {
        int choice = choiceTemplate(3, 2, new List<string> {
            "A. Act composed, this basically confirms that something dark is happening here.",
            "B. Something dark is happening here. I need to confront the landlady about this.",
            "C. Hm? Ah this fingernail might be from Jone, I've heard he does disgusting things all the time. I'll inform the landlady just in case.\n" });
        if (choice == 2)
        {
            return normalEnding.confrontOldLady();
        }
        else if (choice == 1)
        {
            return Ending3.Ending3P2();
        }
        else
        {
            return Ending4.doesntSuspect();
        }
    }
    public static string choiceConfrontLady()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. She’s senile, being a psychopath won’t help her.",
            "B. This… I need more time to prepare.\n" });
        if (choice == 1)
        {
            return normalEnding.pullKnife();
        }
        else
        {
            return normalEnding.moretime();
        }
    }
    public static string moretime()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Fine. Let's go.",
            "B. Confront Ms. Helen about what you saw.\n" });
        if (choice == 2)
        {
            return normalEnding.pullKnife();
        }
        else
        {
            return normalEnding.attackAttempt();
        }
    }
    public static string choiceHearOtherSide()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Answer ambiguously, suggest something that can make her show her true colors. I need to hear her side first.",
            "B. I don’t need to walk around the bush, she’s definitely some type of crazy.\n" });
        if (choice == 1)
        {
            return normalEnding.listenToLady();
        }
        else
        {
            return normalEnding.listenToLady(); //I don’t need to walk around the bush, she’s definitely some type of crazy.
        }
    }
    public static string choiceContinueTalking()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. I need to continue talking to her, I need more answers before I end her myself!",
            "B. One stab, and we’re done with this nightmare!\n" });
        if (choice == 1)
        {
            return normalEnding.investigateLadyFurther();
        }
        else
        {
            earlyStab = true;
            return normalEnding.attackAttempt();
        }
    }
    public static string choiceInvestigateFurther()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. I’ll just ask her when she’s half dead, I got to get rid of this woman!",
            "B. I need her to experience what she did to her victims.\n" });
        if (choice == 1)
        {
            return normalEnding.attackAttempt();
        }
        else
        {
            return Ending6.Greed();
        }
    }
    public static string choiceAttackAttempt()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Attack Mrs. Helen. You might be able to inflict a serious injury, but your back will be open.",
            "B. Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.\n" });
        if (choice == 1)
        {
            return normalEnding.grabKnifeToAttack();
        }
        else
        {
            return Ending4.Finale2();
        }
    }
    public static string choiceNormalEnding()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Tie the landlady up, and ask her where your grandfather’s remains are as well as your doubts.",
            "B. Just kill her! I want to end this nightmare!\n" });
        if (choice == 1)
        {
            return normalEnding.perfectrunEnding();
        }
        else
        {
            if (Map.headlock)
            {
                return Ending6.Greed();
            }
            else if (Map.rustyknife)
            {
                return Ending6.Greed();
            }
            else
            {
                return "normal ending";
            }
        }
    }

    /* ENDING 1 */
    public static string choiceNextMove()
    {
        say(" (You have to plan for your next move. What do you want to do next?");
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Confront the landlord about what you saw.",
            "B. Report to the Police, they have to be the ones to give justice.\n"
        });
        if (choice == 2)
        {
            return Ending1.reportPolice();
        }
        else
        {
            return normalEnding.confrontOldLady();
        }
    }

    /* ENDING 2
 _____ _   _ ____ ___ _   _  ____   ____  
| ____| \ | |  _ \_ _| \ | |/ ___| |___ \ 
|  _| |  \| | | | | ||  \| | |  _    __) |
| |___| |\  | |_| | || |\  | |_| |  / __/ 
|_____|_| \_|____/___|_| \_|\____| |_____|*/
    public static string choiceKateRoom()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Feeling like you did something wrong, you close the door and act like nothing happened.",
            "B. Enter the room carefully and inspect the letters.\n"
        });

        if (choice == 1)
        {
            return Ending2.kateRoomCaught();
        }
        else
        {
            return "WIP";
        }
    }
    public static string choiceRagedUser()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Continue listening to the landlady.",
            "B. Filled with rage, you lunge and tackle the landlady.\n"
        });

        if (choice == 2)
        {
            return Ending2.tackleLandlady();
        }
        else
        {
            wrestleLandlady = true;
            return Ending2.continueListening();
        }
    }
    public static string choiceEscape()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Wrestle with the landlady.",
            "B. Try to escape from the landlady.\n"
        });

        if (choice == 2)
        {
            return Ending2.escapelandlady();
        }
        else
        {
            wrestleLandlady = true;
            return Ending2.keepWrestling();
        }
    }
    public static string choiceRunOrMock()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Run towards the exit and escape the boarding house.",
            "B. Mock the landlady and piss her off, there's no way an old lady can catch up to you anyways.\n"
        });

        if (wrestleLandlady)
        {
            return Ending5.Ending5s();
        }
        else
        {
            if (choice == 1)
            {
                return Ending2.Finale();
            }
            else
            {
                return Ending2.Finale();
            }
        }
    }

    /* ENDING 3
 _____ _   _ ____ ___ _   _  ____   _____ 
| ____| \ | |  _ \_ _| \ | |/ ___| |___ / 
|  _| |  \| | | | | ||  \| | |  _    |_ \ 
| |___| |\  | |_| | || |\  | |_| |  ___) |
|_____|_| \_|____/___|_| \_|\____| |____/ */
    public static string choiceExitAttempt()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Exit the boarding house quietly and report to the authorities.",
            "B. Confront the landlady about your suspicion\n" });
        if (choice == 1)
        {
            return Ending3.Ending3P3();
        }
        else
        {
            return normalEnding.confrontOldLady();
        }
    }
    public static string choiceFollowOrders()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Run towards the exit",
            "B. Follow the landlady's orders\n"});
        if (choice == 2)
        {
            return Ending3.Ending3P4();
        }
        else
        {
            return Ending2.escapelandlady();
        }
    }
    public static string choicePanicked()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. I have nothing to do with my grandfather’s disappearance! In fact, I was even trying to find my grandfather in this establishment!",
            "B. Don’t listen to her! She is making stuff up!\n"});
        if (choice == 1)
        {
            return Ending3.Ending3P5();
        }
        else
        {
            return Ending6.Ending6Part1();
        }
    }
    public static string choiceAskforInvestigation()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Ask the officer to investigate what happened inside the boarding house and look at the sofa.",
            "B. Continue framing the landlady, distracting the officer from the investigation.\n" });
        if (choice == 2)
        {
            return Ending3.Ending3Finale();
        }
        else
        {
            return Ending6.Ending6Part1();
        }
    }


    /* ENDING 4
 _____ _   _ ____ ___ _   _  ____   _  _   
| ____| \ | |  _ \_ _| \ | |/ ___| | || |  
|  _| |  \| | | | | ||  \| | |  _  | || |_ 
| |___| |\  | |_| | || |\  | |_| | |__   _|
|_____|_| \_|____/___|_| \_|\____|    |_|  */

    public static string choiceGrabVeggies()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Sure, what should I get?",
            "B. I'm sorry, I am very scared of the insects from your garden. Can I help you with something else?\n"
        });

        if (choice == 1)
        {
            return Ending4.youShouldGet();
        }
        else
        {
            return Ending4.littleRascal();
        }
    }
    public static string choiceMadalingAraw()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Probably just neighborhood cats",
            "B. What was that? I should check it out.\n"
        });

        if (choice == 2)
        {
            return Ending4.peepGarden();
        }
        else
        {
            return Ending4.neighborhoodcats();
        }
    }
    public static string fine()
    {
        int choice = choiceTemplate(1, 1, new List<string>
        {
            "A. Fine.\n"
        });

        return Ending4.peepGarden();
    }
    public static string choiceSusGarden()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Hurry up and run back to room before landlord sees me here.",
            "B. I should leave no evidence that I was here and go to my room\n"
        });

        if (choice == 1)
        {
            return Ending4.footprintEvidence();
        }
        else
        {
            return Ending1.removeEvidence();
        }
    }
    public static string choiceEatBreakfast()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. I should leave this house.",
            "B. That's great! I'll be down in a bit\n"
        });

        if (choice == 2)
        {
            return Ending4.susBreakfast();
        }
        else
        {
            return Ending4.lateforwork();
        }
    }
    public static string choiceDishes()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. My intuition says not to eat it after what happened yesterday midnight, but a quick bite shouldn't hurt.",
            "B. Haah-- this breakfast really looks amazing, but I really can't get over what happened yesterday midnight.\n"
        });

        if (choice == 1)
        {  
            return Ending4.poisonedFood();
        }
        else
        {
            return choiceNextMove();
        }
    }
    public static string choiceTrytoKill()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. (While still having a little strength) I WILL KILL YOU! You deserve to die!!!",
            "B. Grab a knife and charge at the landlady.\n"
        });

        if (choice == 1 || choice == 2)
        {
            return Ending4.Finale();
        }
        else
        {
            return "Invalid Action: Only choose between 1 and 2";
        }
    }
    /* ENDING 6
 _____ _   _ ____ ___ _   _  ____    __   
| ____| \ | |  _ \_ _| \ | |/ ___|  / /_  
|  _| |  \| | | | | ||  \| | |  _  | '_ \ 
| |___| |\  | |_| | || |\  | |_| | | (_) |
|_____|_| \_|____/___|_| \_|\____|  \___/ */

    public static string choiceAngrytoPolice()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Thank you officer, I'll keep your promise to heart. You can call me if you need anything for the investigation",
            "B. You better! Do your job properly and don't listen to a senile old lady, this is why everyone sees your force as corrupt! Can't even do your jobs properly!\n"
        });
        if (choice == 2)
        {
            return Ending6.angryToOfficer();
        }
        else
        {
            return Ending3.Ending3Finale();
        }
    }
    private static int choiceTemplate(int maxChoice, int correctAnswer, List<string> choices)
    {
        for (int x = 0; x < maxChoice; x++)
        {
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{choices[x]}\n");
        }
        ResetColor();
        return GetChoice(maxChoice);
    }
    private static int GetChoice(int maxChoice)
    {
        int choice;
        while (true)
        {
            Write("Enter your choice: ");
            if (int.TryParse(ReadLine(), out choice) && choice > 0 && choice <= maxChoice)
            {
                Clear();
                break;
            }
            else
            {
                WriteLine($"Invalid choice. Please enter a number between 1 and {maxChoice}\n");
            }
        }
        return choice;
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
