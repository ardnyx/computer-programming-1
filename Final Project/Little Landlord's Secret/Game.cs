using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Little_Landlord_s_Secret
{
    internal enum MapType
    {
        StartHouse,
        StartKateRoom,
        StartJoneRoom,
        StartKitchen
    }
    internal class Game
    {
        private MapType CurrentMapType;
        private World MyWorld;
        private Player CurrentPlayer;
        public string[,] grid;
        public void StartKitchen()
        {
            grid = RoomParser.ParseFileToArray("Kitchen.txt");
            MyWorld = new World(grid);
            CurrentPlayer = new Player(9,11);
            CurrentMapType = MapType.StartKitchen;
            RunGameLoop();
        }
        public void StartHouse(int x, int y)
        {
            grid = RoomParser.ParseFileToArray("House.txt");
            MyWorld = new World(grid);
            CurrentPlayer = new Player(x, y);
            CurrentMapType = MapType.StartHouse;
            RunGameLoop();
        }
        public void StartkateRoom()
        {
            grid = RoomParser.ParseFileToArray("KateRoom.txt");
            MyWorld = new World(grid);
            CurrentPlayer = new Player(5,3);
            CurrentMapType = MapType.StartKateRoom;
            RunGameLoop();
        }
        public void StartjoneRoom()
        {
            string[,] grid =
            {
                {"=", "=", "=", "=", " ", "=","=", "="},
                {"|", " ", " ", "|", "?", "|","?", "|"},
                {"|", " ", " ", "|", " ", " "," ", "|"},
                {"|", " ", " ", "=", "+", "0"," ", "|"},
                {"|", " ", " ", " ", " ", " "," ", "|"},
                {"=", "=", "X", "=", "=", "=","=", "="},
            };
            MyWorld = new World(grid);
            CurrentPlayer = new Player(2, 4);
            CurrentMapType = MapType.StartJoneRoom;
            RunGameLoop();
        }
        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }
        private void HandlePlayerInput()
        {
            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;

            } while (KeyAvailable);
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPosWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPosWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPosWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPosWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                default: 
                    break;
            }
        }
        private void RunGameLoop()
        {
            while (true)
            {
                DrawFrame();
                HandlePlayerInput();
                switch (CurrentMapType)
                {
                    case MapType.StartHouse:
                        if (CurrentPlayer.X == 31 && CurrentPlayer.Y == 21 || CurrentPlayer.X == 32 && CurrentPlayer.Y == 21 || CurrentPlayer.X == 33 && CurrentPlayer.Y == 21 || CurrentPlayer.X == 34 && CurrentPlayer.Y == 21 || CurrentPlayer.X == 35 && CurrentPlayer.Y == 21)
                        {
                            SetCursorPosition(0, 23);
                            ForegroundColor = ConsoleColor.Yellow;
                            say("> Do you want to sit down at the sofa?");
                            ResetColor();
                            WriteLine("A. Yes\n" +
                                "B. No.\n");
                            int choice = GetChoice(2);
                            if (choice == 1)
                            {
                                Clear();
                                normalEnding.sitLivingRoom();
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (CurrentPlayer.X == 50 && CurrentPlayer.Y == 18)
                        {
                            CurrentPlayer.X = 49;
                            SetCursorPosition(0, 23);
                            ForegroundColor = ConsoleColor.Yellow;
                            say($"You just got here and already want to leave?");
                            ResetColor();
                        }
                        if (CurrentPlayer.X == 12 && CurrentPlayer.Y == 10 && Map.enterKitchen && Map.rustyknife && !Map.lieknife)
                        {
                            Clear();
                            ForegroundColor = ConsoleColor.Red;
                            say($"???: Heyyyyyyyyyyyyy\n");
                            ResetColor();
                            say($"{Program.player}: O-oh Ms. Helen! What is it?\n");
                            say($"Ms. Helen: Oh it's no big deal, but have you seen a rusty knife somewhere? I swear it was just here in the kitchen..\n");
                            WriteLine("A. Give the rusty knife\n" +
                                "B. Lie.\n");
                            int choice = GetChoice(2);
                            if (choice == 2 && !Map.lieknife)
                            {
                                Map.lieknife = true;
                                CurrentPlayer.X = 13;
                                say($"{Program.player}: Oh no I didn't, I'm sorry.\n");
                                say($"Ms. Helen: Oh it's fine! Looks like I misplaced it again.\n");
                                Clear();
                                ReadKey();
                                ForegroundColor = ConsoleColor.Red;
                                say("Liar.");
                                ResetColor();
                            }
                            else
                            {
                                Map.rustyknife = false;
                                CurrentPlayer.X = 13;
                                say($"{Program.player}: Oh yeah! I thought it was pretty odd, but here it is.\n");
                                say($"Ms. Helen: Ahh, thank you so much!\n");
                                say($"{Program.player}: No problem.\n");
                                Clear();
                                ReadKey();
                                ForegroundColor = ConsoleColor.Red;
                                say("Close enough.");
                                ResetColor();
                            }
                        }
                        if (CurrentPlayer.X == 12 && CurrentPlayer.Y == 10)
                        {
                            if (!Map.lieknife && !Map.pickedupknife)
                            {
                                StartKitchen();
                            }
                            else if (Map.lieknife || Map.pickedupknife)
                            {
                                CurrentPlayer.X = 13;
                                SetCursorPosition(0, 23);
                                say($"{Program.player}: Huh? The kitchen's blocked?");
                                break;
                            }   
                        }
                        
                        if (CurrentPlayer.X == 23 && CurrentPlayer.Y == 6)
                        {
                            if (Map.room1key)
                            {
                                Ending2.kateMap();
                            }
                            else
                            {
                                CurrentPlayer.Y = 7;
                                SetCursorPosition(0, 23);
                                WriteLine($"> {Program.player}: The door's locked. Weird.");
                                while (ReadKey(true).Key != ConsoleKey.DownArrow)
                                {
                                }
                                Clear();
                            }
                            break;
                        }
                        if (CurrentPlayer.X == 41 && CurrentPlayer.Y == 6)
                        {
                            Ending4.joneMap();
                        }
                        break;
                    case MapType.StartKitchen:
                        if (CurrentPlayer.X == 9 && CurrentPlayer.Y == 11)
                        {
                            Map.enterKitchen = true;
                        }
                        if (CurrentPlayer.X == 10 && CurrentPlayer.Y == 11)
                        {
                            StartHouse(13,10);
                        }
                        if (CurrentPlayer.X == 7 && CurrentPlayer.Y == 3 && !Map.rustyknife)
                        {
                            Map.pickedupknife = true;
                            Map.rustyknife = true;
                            SetCursorPosition(0, 16);
                            ForegroundColor = ConsoleColor.Yellow;
                            say("> You picked up a Rusty Knife!\n");
                            ResetColor();
                            say($"{Program.player}: And what's a knife doing in here huh..");
                        }
                        if (CurrentPlayer.X == 2 && CurrentPlayer.Y == 1)
                        {
                            CurrentPlayer.X = 3;
                            SetCursorPosition(0, 16);
                            WriteLine("A. Help the Landlady\n" +
                                "B. Come back later.\n");
                            int choice = GetChoice(2);
                            if (choice == 1)
                            {
                                Clear();
                                Ending4.helpLandlady();
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case MapType.StartKateRoom:
                        if (CurrentPlayer.X == 5 && CurrentPlayer.Y == 4)
                        {
                            if (Map.discoveredBody)
                            {
                                Ending2.kateRoomCaught();
                            }
                            StartHouse(23,7);
                        }
                        if (CurrentPlayer.X == 5 && CurrentPlayer.Y == 2)
                        {
                            if (!Map.drawerkey)
                            {
                                CurrentPlayer.Y = 3;
                                SetCursorPosition(0, 6);
                                say($"> {Program.player}: Huh, a drawer. But it's locked again.");
                                while (ReadKey(true).Key != ConsoleKey.DownArrow)
                                {
                                }
                                Clear();
                            }
                        }
                        if (CurrentPlayer.X == 5 && CurrentPlayer.Y == 1)
                        {
                            if (!Map.discoveredBody)
                            {
                                Map.discoveredBody = true;
                                SetCursorPosition(0, 6);
                                say($"> Piles of letters fell as you open the drawer.");
                                say("> And after a few seconds");
                                say("> A dead body appeared, inside the drawer, hidden behind the pile of letters.");
                                Clear();
                                ForegroundColor = ConsoleColor.Red;
                                for (int i = 1; i < 50; i++)
                                {
                                    for (int j = 1; j < 50; j++)
                                    {
                                        Console.Write("FOOTSTEPS" + "\t");
                                    }
                                    Console.WriteLine();
                                }
                                ResetColor();
                                Clear();
                                say($"{Program.player}: ??!?!?! ..w..\n");
                                say($"{Program.player}: SHIIIIIT\n");
                                say($"{Program.player}: Calm down, no.. I should've expected it.\n");
                                say($"{Program.player}: (agitated) I mean.. aha.. I've read the letter! I should've expected it.\n");
                                Clear();
                            }
                        }
                        if (CurrentPlayer.X == 5 && CurrentPlayer.Y == 3 && Map.discoveredBody)
                        {
                            if (!Map.someonedoor)
                            {
                                Map.someonedoor = true;
                                SetCursorPosition(0, 6);
                                say($"{Program.player}: (whispers) Looks like I've been..");
                            }
                        }
                            break;
                    case MapType.StartJoneRoom:
                        if (CurrentPlayer.X == 2 && CurrentPlayer.Y == 5)
                        {
                            StartHouse(41,7);
                        }
                        else if (CurrentPlayer.X == 6 && CurrentPlayer.Y == 1)
                        {
                            if (!Map.room1key)
                            {
                                Map.room1key = true;
                                SetCursorPosition(0, 6);
                                ForegroundColor = ConsoleColor.Yellow;
                                say("> You found a key!\n");
                                ResetColor();
                                say("> Where do you think this leads to?");
                                Clear();
                            }
                        }
                        else if (CurrentPlayer.X == 4 && CurrentPlayer.Y == 1)
                        {
                            if (!Map.drawerkey)
                            {
                                Map.drawerkey = true;
                                SetCursorPosition(0, 6);
                                ForegroundColor = ConsoleColor.Yellow;
                                say("> You found a small key!\n");
                                ResetColor();
                                say("> Now what's this for?");
                                while (ReadKey(true).Key != ConsoleKey.DownArrow)
                                {
                                }
                                Clear();
                            }
                        }
                        else if (CurrentPlayer.X == 4 && CurrentPlayer.Y == 0)
                        {
                            SetCursorPosition(0, 6);
                            say("> Do you want to go to the second floor?\n");
                            WriteLine("A. Yes\n" +
                                "B. No\n");
                            int choice = GetChoice(2);
                            if (choice == 1)
                            {
                                Map.joneroom = true;
                                Ending4.tenant2Room();
                            }
                            Clear();
                        }
                        break;
                }
                System.Threading.Thread.Sleep(20);
            }
        }
        static void say(string message)
        {
            WriteLine($"{message}");
            while (ReadKey(true).Key != ConsoleKey.DownArrow)
            {
                // Continue consuming keys until Enter is pressed
            }
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
    }
}
