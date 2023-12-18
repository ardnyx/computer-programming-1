using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending4
    {
        public static string helpLandlady()
        {
            say($"Mrs. Helen: Hello {Program.player}, could I use some help? Will you please get some vegetables from my garden? I need them for the thing that I'm cooking for you");
            return ChoiceSelector.choiceGrabVeggies();
        }
        public static string youShouldGet()
        {
            Map.fetchcorns = true;
            say($"Mrs. Helen: I want you to fetch me some corns from the garden. I remembered planting some a few weeks ago, check them out if they're already ripe.");
            say($"{Program.player}: Alright then.");
            Clear();
            Title = "You are Currently in the Garden";
            int x = 7, y = 10;
            string[,] map = {
           { "|", "-", "-", "-", "-", "-", "-",  "-",  "-", "-", "-", "-", "-", "-", "|" },
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "^", "^", "^", "^", "^", "^",  "^",  "^", "^", "^", "^", "^", "^", "|" },
       };
            while (true)
            {
                Clear();
                map[y, x] = "X";
                int Rows = map.GetLength(0);
                int Cols = map.GetLength(1);
                if (map[2, 13] == "X")
                {
                    say($"(While you were harvesting, something odd caught your eye which doesn't look like a... corn..?");
                    say($"{Program.player}: This.. is..");
                    return ChoiceSelector.choiceInvestigateSofa();

                }
                else
                {
                    for (int j = 0; j < Rows; j++)
                    {
                        for (int i = 0; i < Cols; i++)
                        {
                            string element = map[j, i];
                            SetCursorPosition(i, j);
                            Write(element + "\t");
                        }
                    }
                    WriteLine("\n\nWalk beside the Corn to Collect them");
                    WriteLine("Use the Arrow Keys to Move");
                    WriteLine("\nLegend:");
                    WriteLine("O = Corn to be Harvested");
                    WriteLine("* = Corn is Harvested");
                    WriteLine("X = Player Location");
                    WriteLine("| = Fence");
                    WriteLine("- = Fence");
                    WriteLine("^ = Fence");
                    WriteLine();
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    ConsoleKey key = keyInfo.Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            if (0 < y - 2 && y - 2 < Rows)
                            {
                                if (map[y - 2, x] == " ")
                                {
                                    map[y, x] = " ";
                                    y -= 2;
                                    if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";
                                    }
                                    else if (map[y - 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                    else if (map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (0 < y + 2 && y + 2 < Rows)
                            {
                                if (map[y + 2, x] == " ")
                                {
                                    map[y, x] = " ";
                                    y += 2;
                                    if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                    else if (map[y - 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }

                                    else if (map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                }
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (0 < x - 2 && x - 2 < Cols)
                            {
                                if (map[y, x - 2] == " ")
                                {
                                    map[y, x] = " ";
                                    x -= 2;
                                    if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                    else if (map[y - 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }

                                    else if (map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }

                                }
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (0 < x + 2 && x + 2 < Cols)
                            {
                                map[y, x] = " ";

                                x += 2;

                                if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                {
                                    map[y - 1, x] = "*";
                                    map[y + 1, x] = "*";

                                }
                                else if (map[y - 1, x] == "O")
                                {
                                    map[y - 1, x] = "*";
                                    map[y + 1, x] = "*";

                                }

                                else if (map[y + 1, x] == "O")
                                {
                                    map[y - 1, x] = "*";
                                    map[y + 1, x] = "*";

                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static string joneMap()
        {
            Game currentGame = new Game();
            currentGame.StartjoneRoom();
            return "";
        }
        public static string tenant2Room()
        {
            Clear();
            say($" (You went up the second floor)");
            say($" (You have reached the hallways)");
            for(int x = 0; x < 3; x++)
            {
                say($".");
            }
            say($"Finger...nails..?");
            return ChoiceSelector.choiceInvestigateSofa();
        }
        public static string littleRascal()
        {
            Clear();
            say($"Mrs. Helen: Oh you little rascal! You're already an adult but you're still scared of some dirt! " +
                $"Just sit in the living room and wait then, lunch will be ready in a while.");
            return normalEnding.sitLivingRoom();
        }
        public static string neighborhoodcats()
        {
            say($" (The sounds became more apparent and didn't stop.)");
            say($" You have to do something about the noise!");
            return ChoiceSelector.fine();
        }
        public static string doesntSuspect()
        {
            if (Map.fetchcorns)
            {
                say($" (Despite spotting a fingernail on the garden, you dismissed it even though you felt a bit stressed and uncomfortable)");
                say($"{Program.player}: A-ah.. Well I guess this is just some of the disgusting things the other tenant usually does. Anyway, I have to bring these corns back to Mrs. Helen.");
                say($" (You walk back to the house)");
                say($"{Program.player}: I'm back. here's your corns.");
            }
            else if (Map.joneroom)
            {
                say($"{Program.player}: I mean.. this is his room after all.. ah-haha.. shouldn't have went here.");
                say($" (You went back to the living room and had a quick chat with Mrs. Helen.)");
                say($"{Program.player}: Hello Mrs. Helen, I just had a quick tour of the house. It's pretty nice!");
            }
            else
            {
                say($"{Program.player}: ?");
                say($"Mrs. Helen: Hello {Program.player}, sorry for disturbing you, but do you prefer your food-");
                say($" (Surprised by Mrs. Helen's sudden prescence, you instinctively answered her question without thinking and immediately covered up what you found beneath the sofa)");
                say($"{Program.player}: Ah- yes?!");
                say($"Mrs. Helen: Hm? You seem flustered, are you okay?");
                say($"{Program.player}: Ah yeah I'm fine, I was just surprised haha.. what was that again?");
                say($"Mrs. Helen: Oh nevermind about that, anyway, how are you doing there?");
                say($"{Program.player}: Nothing much, just finished having a quick tour of the house. It's pretty nice!");
            }
            say($"Mrs. Helen: Oh great! Anyway, the dish will be almost done. Just stay in touch for now.");
            if (Map.fetchcorns)
            {
                say($"{Program.player}: Thanks! And oh, I saw a fingernail.. or was it a fingernail, anyway, I saw it on your garden when I was picking up corns. " +
                    $"I think it's from the other tenant, I heard he usually has this weird disgusting hobbies based on what I've heard from grandpa.. right?");
            }
            else if (Map.joneroom)
            {
                say($"{Program.player}: Alright! and oh, I saw a fingernail.. or was it a fingernail, anyway, I saw it when I was having a quick tour around the other tenant's room? " +
                    $"I've heard he usually has this weird hobbies based from grandpa, so I think it came from that.");
            }
            if (Map.joneroom || Map.fetchcorns)
            {
                say($"Mrs. Helen: O-oh! haha, I'm so sorry about that, I'll talk to him later on, my gosh he needs some scolding!");
                say($" (After helping her, nothing much happened aftwards.)");
            }
            else
            {
                say(" (After that, nothing much happened afterwards.");
                say(" (You also didn't speak of anything regarding the fingernail and bloodstains you saw at the sofa.");
                say(" (These discoveries made you tired, and so-)");
            }
            say($" (It's already night. You came back to your room and slept. The first day...)");
            ForegroundColor = ConsoleColor.Red;
            say($" isn't done.");
            ResetColor();
            return middleOfTheNight();
        }
        public static string middleOfTheNight()
        {
            say($" (In the middle of the night, you hear something strange in the garden shed.)");
            return ChoiceSelector.choiceMadalingAraw();
        }
        public static string peepGarden()
        {
            Map.buryingcorpse = true;
            say($" (Peeping in the garden shed door you saw the Mrs. Helen burying a human body, conforming your suspicions and due to the shock, you knocked down garden tools letting out a loud crash.)");
            return ChoiceSelector.choiceSusGarden();
        }
        public static string footprintEvidence()
        {
            say($" (Mrs. Helen sees footprints and suspects that you saw her. But then shouting “these damn cats! Always messing with my tools. " +
                $"You thought she is non the wiser and continues to sleep. Morning comes and Mrs. Helen knocks on your door.)");
            say($"Mrs. Helen: Time for breakfast. I’ve prepared a special meal for my ~ ~ neeeeeew tenant!");
            return ChoiceSelector.choiceEatBreakfast();
        }
        public static string lateforwork()
        {
            Map.escapethehouse = true;
            say($"{Program.player}: (Internal Monologue) ..no.. after what I've seen, I should leave here.");
            say($"{Program.player}: I'm sorry grandpa, I'll leave this investigation to the proper authorities.");
            say($" (Scared of what might happen next, you escaped the house through your room's windows.)");
            Clear();
            for (int i = 0; i < 3; i++)
            {
                say(".");
            }
            Clear();
            say($"Mrs. Helen: ...");
            say($"Mrs. Helen: I knew it.");
            say($" (The landlady reached out for her keys, opened the door, and found out that you escaped.)");
            say($"Mrs. Helen: ha..hahahahah");
            say($"Mrs. Helen: Good choice then.. now...");
            ForegroundColor = ConsoleColor.Red;
            say("Who's next?");
            ResetColor();
            Clear();
            say(@"
  _______ _            ______           _ 
 |__   __| |          |  ____|         | |
    | |  | |__   ___  | |__   _ __   __| |
    | |  | '_ \ / _ \ |  __| | '_ \ / _` |
    | |  | | | |  __/ | |____| | | | (_| |
    |_|  |_| |_|\___| |______|_| |_|\__,_|
Ending 4                                    
                                          
");
            Environment.Exit(0);
            return "Ending";
        }
        public static string susBreakfast()
        {
            say($"{Program.player}: Hah- I don't know now. Maybe this confirms the contents of the letter after all.");
            say($" (You open the door to the kitchen, and the sight before you are nothing short of a breakfast masterpiece. The table is adorned with an array of mouthwatering dishes.)");
            return ChoiceSelector.choiceDishes();
        }
        public static string poisonedFood()
        {
            say($"Halfway through the meal you feel something in your stomach, An aching pain.");
            ReadKey();
            Write($"MRS. HELEN POISONED THE FOOD!\n\n");
            return ChoiceSelector.choiceTrytoKill();
        }
        public static string Finale2()
        {
            Clear();
            say($" (You underestimated the mental fortitude of the psychotic landlady.)");
            say($" (She never cared about her own well-being and instead enjoys tormenting someone.)");
            say($" (Going for mutual destruction is the biggest mistake for you,)");
            say($" (but the ultimate happiness for her.)");
            say(@"
  _______ _            ______           _ 
 |__   __| |          |  ____|         | |
    | |  | |__   ___  | |__   _ __   __| |
    | |  | '_ \ / _ \ |  __| | '_ \ / _` |
    | |  | | | |  __/ | |____| | | | (_| |
    |_|  |_| |_|\___| |______|_| |_|\__,_|                                  
                                          
");
            Environment.Exit(0);
            return "Finale4";
        }
        public static string Finale()
        {
            say($" (With so little strength you were unable to overpower her. Laying on the ground the Mrs. Helen whispered)");
            say($"Mrs. Helen: You had the chance to escape, yet you opted to linger and tamper with my affairs. " +
                $"Now, look at yourself on the ground, gasping for your final breath.");
            say($" (The last thing you saw was the grim reflection of your own tormented face in the mirror. " +
                $"Your eyes, once filled with deceit and cunning, now held only a look of abject terror. " +
                $"You had become a victim of her, consumed by the darkness she had created.)");
            say($" (And as you took your final breath, the secrets of the building remained buried beneath the weight of the floor. " +
                $"The tenants, unaware of the sinister truth that lurked within their walls, continued their daily lives, oblivious to the darkness that is reigning among them.)");
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
            return "Ending 4 Finale";
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
