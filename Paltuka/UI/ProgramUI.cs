using Pheltuka.Animals_Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class ProgramUI
    {
        private readonly IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {

            _console.WriteLine("Welcome to");
            Music();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            string title =    "█▄─▄▄─█─█─█▄─▄▄─█▄─▄███─▄─▄─█▄─██─▄█▄─█─▄██▀▄─██\n" +
                              "██─▄▄▄█─▄─██─▄█▀██─██▀███─████─██─███─▄▀███─▀─██\n" +
                              "▀▄▄▄▀▀▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀\n";
            foreach (char letter in title)
            {
                if (letter is '█')
                {
                    Console.Beep(432, 100);
                }
                Thread.Sleep(30);
                Console.Write(letter);
            }
            _console.WriteLine("Press 'Enter' to begin.");
            _console.ReadLine();
            _console.Clear();
            Story();


            void Story()
            {
                _console.WriteLine($"You are a former archeologist. \n");
                _console.WriteLine("You were recently fired for your obsession with this lost civilization, Pheltuka. \n\n");
                _console.WriteLine("The only clues you have that Pheltuka civilization even existed are from some old broken pottery \n" + "and a busted writing slab that you have been trying to dechpiher for 5 years. \n\n");
                _console.WriteLine("You have only translated a small portion of the slab, but you found out that the text talks about two things: \n\n");
                _console.WriteLine("Trading with Pheltuka & the Uuprese river as the only way to get to Pheltuka. \n\n\n");
                _console.WriteLine("\nWill you set out on a journey to uncover this lost civilization? \n");
                _console.WriteLine("\n\nType START or YES to start game, then press the ENTER key.");
                string start = _console.ReadLine().ToLower();
                bool beginJourney = true;
                while (beginJourney)
                {
                    if (start.StartsWith("yes") || start.StartsWith("start"))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        _console.Clear();
                        First();
                    }
                    if (start.StartsWith("no") || start.StartsWith("end"))
                    {
                        beginJourney = false;
                    }
                }
            }

            void First()
            {
                _console.WriteLine("You set out on your adventure, the fastest way to the Uuprese river is through a small forest. \n" + "Thankfully, your good friend Konami has a map of the forest that he is willing to give you. \n\n\n" + "Do you enter into the forest? \n" + "YES or NO");

                string start2 = _console.ReadLine().ToLower();
                bool beginForest = true;
                while (beginForest)
                {
                    if (start2.StartsWith("yes") || start2.StartsWith("start"))
                    {
                        _console.Clear();
                        ForestOne();
                    }
                    if (start2.StartsWith("no") || start2.StartsWith("end"))
                    {
                        GameOver();
                    }
                }
            }

            void ForestOne()
            {
                string forest1;
                _console.WriteLine("Shortly into your journey you come across your first decision. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nUp: The incline is small but steep.");
                _console.WriteLine("Right: It's quiet....");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You can see the sun shining through the trees.");
                forest1 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest1)
                {
                    case "1":
                    case "up":
                        {
                            _console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            ToRiverOne();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.WriteLine("What? You scared? \n" + "Press 'Enter' to contniue.");
                            _console.ReadLine();
                            _console.Clear();
                            First();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ForestTwo();
                            break;
                        }
                }
            }

            void ForestTwo()
            {
                string forest2;

                _console.WriteLine("You made it to a small landing on the incline. \n" +
                    "You have another decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nUp: Continue up the incline.");
                _console.WriteLine("Right: You saw some brush moving up ahead...");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: It's quiet...");
                forest2 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest2)
                {
                    case "1":
                    case "up":
                        {
                            _console.Clear();
                            ForestThree();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestOne();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            _console.WriteLine("While walking down the path, you decide to look around and admire the nature./n" + "You are in such awe by the view, you don't realize that you are walking into a bear trap./n" + "Way to go, you bled to death by stepping in a bear trap..../n" + "...hope the view was worth it....");
                            _console.WriteLine("\n\n\nPress 'Enter'.");
                            _console.ReadLine();
                            GameOver();
                            break;
                        }
                }
            }

            void ForestThree()
            {
                string forest3;

                _console.WriteLine("You made it to the top of the incline. \n" +
                    "You can see your house from here! \n" +
                    "But enough sight seeing, you have another decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nDown: Start the trek down the incline.");
                _console.WriteLine("Right: The sun is shining brightly over there.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You saw some brush moving up ahead...");
                forest3 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest3)
                {
                    case "1":
                    case "down":
                        {
                            _console.Clear();
                            ForestFour();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("There's a gold coin on the ground...it seems ancient..");
                            _console.WriteLine("Do you want to pick it up?");
                            _console.ReadLine();
                            _console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ForestFour();
                            break;
                        }
                }
            }

            void ForestFour()
            {
                string forest4;

                _console.WriteLine("You made it to another clearing on the incline. \n" +
                    "You see that you have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nDown: Continue down the incline.");
                _console.WriteLine("Right: There's a strange fog down this path.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: It's quiet...");
                forest4 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest4)
                {
                    case "1":
                    case "down":
                        {
                            _console.Clear();
                            ForestFive();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ForestFive();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestThree();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestFour();
                            break;
                        }
                }
            }

            void ForestFive()
            {
                string forest5;

                _console.WriteLine("You made it down the incline! \n" +
                    "You see that you have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: The trees are so dense down this path that they block out the sun.");
                _console.WriteLine("Right: It's quiet...");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You saw some brush moving up ahead...");
                forest5 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest5)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestFive();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("As you are walking down the path, you accidentally run into a spiderweb\n" + "The spider of the now destroyed web fell onto you and bit you.\n" + "After being biten by the spider, you started to feel strange.\n" + "Next thing you know everything around you is gigantic! You have been turned into a spider!\n" + "The spider that turned you aproaches and then leads you to the spider king.");
                            _console.WriteLine("\n\n\nWay to go, you were turned into a spider...\n" + "Press 'Enter' to continue.");
                            _console.ReadLine();
                            _console.Clear();
                            GameOver();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestFour();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            _console.Clear();
                            ForestSix();
                            break;
                        }
                }
            }

            void ForestSix()
            {
                string forest6;

                _console.WriteLine("Congratulations! You didn't die going down that path! \n" + "Now pick another path!\n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: Left path is lying.");
                _console.WriteLine("Right: The left path is the correct path.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: Right path is lying.");
                forest6 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest6)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestSix();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestFive();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ForestSeven();
                            break;
                        }
                }
            }

            void ForestSeven()
            {
                string forest7;

                _console.WriteLine("You know the drill... \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: I can barely see down this path....");
                _console.WriteLine("Right: There's a strange fog down this path.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: The sun is shining brightly over there.");
                forest7 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest7)
                {
                    case "1":
                    case "striaght":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestSix();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            _console.Clear();
                            ForestEight();
                            break;
                        }
                }
            }

            void ForestEight()
            {
                string forest8;

                _console.WriteLine("You see something up ahead... \n" +
                    "You see that you have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: Continue down the incline.");
                _console.WriteLine("Right: The sun is shining brightly over there.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You saw some brush moving up ahead...");
                forest8 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest8)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestEight();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            ForestNine();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ForestNine();
                            break;
                        }
                }
            }

            void ForestNine()
            {
                string forest9;

                _console.WriteLine("You notice some signs up ahead. Each sign has a different letter. \n" + "You notice that the handwriing looks similar to Konami's...\n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nX: Continue down the incline.");
                _console.WriteLine("A: The sun is shining brightly over there.");
                _console.WriteLine("B: Do you want to go back?");
                _console.WriteLine("Y: You saw some brush moving up ahead...");
                _console.WriteLine("Back: Do you want to go back?");
                forest9 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest9)
                {
                    case "x":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ForestTen();
                            break;
                        }
                    case "a":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestNine();
                            break;
                        }
                    case "b":
                        {
                            _console.Clear();
                            ForestTen();
                            break;
                        }
                    case "y":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestNine();
                            break;
                        }
                    case "5":
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestEight();
                            break;
                        }
                }
            }

            void ForestTen()
            {
                string forest10;

                _console.WriteLine("You see more signs writen in what appears to be Konami's handwriting. \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nX: Continue down the incline.");
                _console.WriteLine("A: The sun is shining brightly over there.");
                _console.WriteLine("B: Do you want to go back?");
                _console.WriteLine("Y: You saw some brush moving up ahead...");
                _console.WriteLine("Back: Do you want to go back?");
                forest10 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (forest10)
                {
                    case "x":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverOne();
                            break;
                        }
                    case "a":
                        {
                            _console.WriteLine("There's a note on the ground...it says if you go back and go down the path with sign 'Y', there is a surprise.");
                            _console.WriteLine("\n\nPress 'Enter' to go back.");
                            _console.ReadLine();
                            _console.Clear();
                            ForestTen();
                            break;
                        }
                    case "b":
                        {
                            _console.WriteLine("There was a pitfall there....\n" + "You fell...\n" + "How am I not surprised...");
                            _console.WriteLine("\n\nPress 'Enter' to continue.");
                            _console.ReadLine();
                            _console.Clear();
                            GameOver();
                            break;
                        }
                    case "y":
                        {
                            _console.WriteLine("You run into a bunch of talking animals...\n" + "They call themselves the 'Woodland Critters'. \n" + "They seemed to have misplaced a gold coin. The critters need the coin for a.....party....\n" + "They are asking if you have the coin.\n\n" + "Type 'Use' or 'Give' to give the coin to the Woodland Critters.\n" + "If you don't have the coin or don't want to give them the coin, type 'NA'.");
                            string coin = _console.ReadLine().ToLower();
                            bool item = true;
                            while (item)
                            {
                                if (coin.StartsWith("use") || coin.StartsWith("give"))
                                {
                                    _console.Clear();
                                    _console.WriteLine("The Woodland Critters thank you for helping them find thier coin.\n" + "As payment for helping them, they show you a fast route to the Uuprese river.");
                                    _console.WriteLine("\n\n\nPress the 'Enter' key tocontinue.");
                                    _console.ReadLine();
                                    _console.Clear();
                                    River();
                                }
                                if (coin.StartsWith("no") || coin.StartsWith("na"))
                                {
                                    item = false;
                                    _console.Clear();
                                    _console.WriteLine("You either don't have the coin or chose not to give the coin to the Woodland Critters. They did not like this answer....");
                                    _console.WriteLine("Press 'Enter' to continue.");
                                    _console.ReadLine();
                                    _console.Clear();
                                    GameOver();

                                }
                            }
                            break;
                        }
                    case "5":
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestNine();
                            break;
                        }
                }
            }

            void ToRiverOne()
            {
                string toRiver1;

                _console.WriteLine("You decided that there was no way you were going up that incline.\n" + "You figure that there is a way around the incline to the Uuprese river.\n\n" +
                  "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: You saw some brush moving up ahead...");
                _console.WriteLine("Right: The trees are so dense down this path that they block out the sun.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You saw some brush moving up ahead...");
                toRiver1 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (toRiver1)
                {
                    case "1":
                    case "straight":
                        {
                            _console.Clear();
                            ToRiverTwo();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ToRiverOne();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ForestOne();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ToRiverTwo();
                            break;
                        }
                }
            }

            void ToRiverTwo()
            {
                string toRiver2;

                _console.WriteLine("You can hear the faintest sound of water.. \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: You can see the sun shining through the trees.");
                _console.WriteLine("Right: There's a strange fog down this path.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You saw some brush moving up ahead...");
                toRiver2 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (toRiver2)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ToRiverTwo();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            ToRiverThree();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ToRiverOne();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ToRiverTwo();
                            break;
                        }
                }
            }

            void ToRiverThree()
            {
                string toRiver3;

                _console.WriteLine("You know what to do...\n\n" +
                      "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: I am the correct path to take.");
                _console.WriteLine("Right: Straight path is lying..");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: Right path is lying..");
                toRiver3 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (toRiver3)
                {
                    case "1":
                    case "straight":
                        {
                            _console.Clear();
                            ToRiverFour();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ToRiverFour();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ToRiverTwo();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            ToRiverFour();
                            break;
                        }
                }
            }

            void ToRiverFour()
            {
                string toRiver4;

                _console.WriteLine("The water sounds so close! \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: Continue down the incline.");
                _console.WriteLine("Right: The sun is shining brightly over there.");
                _console.WriteLine("Back: Do you want to go back?");
                _console.WriteLine("Left: You saw some brush moving up ahead...");
                toRiver4 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (toRiver4)
                {
                    case "1":
                    case "straight":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            River();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            River();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            _console.Clear();
                            ToRiverThree();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            _console.WriteLine("Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            ToRiverFour();
                            break;
                        }
                }
            }

            void River()
            {
                _console.WriteLine("You made it to the Uuprese river!\n" + "While looking around, you notice a paddle boat near the water.");
                _console.WriteLine("\n\n\nDo you take the paddle boat down the river?\n" + "Type 'Start' or 'Yes' to continue down the river.");
                string riverStart = _console.ReadLine().ToLower();
                bool beginRiverJourney = true;
                while (beginRiverJourney)
                {
                    if (riverStart.StartsWith("yes") || riverStart.StartsWith("start"))
                    {
                        _console.Clear();
                        RiverOne();
                    }
                    if (riverStart.StartsWith("no") || riverStart.StartsWith("end"))
                    {
                        beginRiverJourney = false;
                        GameOver();
                    }
                }
            }

            void RiverOne()
            {
                string river1;

                _console.WriteLine("You finally start to make your way down the Uuprese river!\n" + "You are one step closer to discovering Pheltuka! ....hopefully..\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The mist from the river has created a haze over this path.");
                _console.WriteLine("Right: The water is calm..");
                _console.WriteLine("Left: You see alot of giant rocks sticking out of the water...");
                river1 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river1)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverOne();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverTwo();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            _console.Clear();
                            RiverTwo();
                            break;
                        }
                }
            }

            void RiverTwo()
            {
                string river2;

                _console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: Something just jumped out of the water!");
                _console.WriteLine("Right: The water seems to be moving faster down this path..");
                _console.WriteLine("Left: The water is so clear.");
                river2 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river2)
                {
                    case "1":
                    case "straight":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverThree();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverThree();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            _console.Clear();
                            RiverThree();
                            break;
                        }
                }
            }

            void RiverThree()
            {
                string river3;

                _console.WriteLine("You think about how long you have been on this advenutre......how far from home you are......with no cellphone service.....\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The water is calm..");
                _console.WriteLine("Right: The mist from the river has created a haze over this path.");
                _console.WriteLine("Left: You saw something splash into the water...");
                river3 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river3)
                {
                    case "1":
                    case "straight":
                        {
                            _console.Clear();
                            RiverFour();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverThree();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverFour();
                            break;
                        }
                }
            }

            void RiverFour()
            {
                string river4;

                _console.WriteLine("You feel as if you are being wathced.....\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The water seems to be moving faster down this path..");
                _console.WriteLine("Right: You see alot of giant rocks sticking out of the water...");
                _console.WriteLine("Left: You saw something splash into the water...");
                river4 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river4)
                {
                    case "1":
                    case "straight":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverFive();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverFour();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            _console.Clear();
                            RiverFive();
                            break;
                        }
                }
            }

            void RiverFive()
            {
                string river5;

                _console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The mist from the river has created a haze over this path.");
                _console.WriteLine("Right: The sun is gleaming off of the water. It is blinding.");
                _console.WriteLine("Left: Something just jumped out of the water!");
                river5 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river5)
                {
                    case "1":
                    case "straight":
                        {
                            _console.Clear();
                            RiverSix();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverFive();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverSix();
                            break;
                        }
                }
            }

            void RiverSix()
            {
                string river6;

                _console.WriteLine("You start to see things like directional signs and what appears to be a field for crops.\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The water seems to be moving faster down this path..");
                _console.WriteLine("Right: The water is so clear.");
                _console.WriteLine("Left: You see alot of giant rocks sticking out of the water...");
                river6 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river6)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("Your boat accidentally runs into some brush on top of the water, \n" + "you didn't realize that there was a bees that lived in the brush.\n" + "The bees start attacking you.\n\n" + "You're allergic to bees!\n\n" + "You forgot to pack an EpiPen...\n" + "I don't even feel sorry for you....");
                            _console.WriteLine("\n\nPress the 'Enter' key to continue.");
                            _console.ReadLine();
                            _console.Clear();
                            GameOver();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            RiverSeven();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverSeven();
                            break;
                        }
                }
            }

            void RiverSeven()
            {
                string river7;

                _console.WriteLine(" You know the drill.... \n\n" + "Which way do you want to go?");
                _console.WriteLine("\n\nStraight: Don't pick the left path.");
                _console.WriteLine("Right: Straight path is lying..");
                _console.WriteLine("Left: Don't pick the right path.");
                river7 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river7)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverSeven();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverEight();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            _console.Clear();
                            RiverEight();
                            break;
                        }
                }
            }

            void RiverEight()
            {
                string river8;

                _console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: Something just jumped out of the water!");
                _console.WriteLine("Right: The sun is gleamig off of the water. It is blinding.");
                _console.WriteLine("Left: The water looks so clear.");
                river8 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river8)
                {
                    case "1":
                    case "straight":
                        {
                            _console.Clear();
                            RiverNine();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverNine();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverEight();
                            break;
                        }
                }
            }

            void RiverNine()
            {
                string river9;

                _console.WriteLine("You see some large pillars in the water. They look like worn totem poles..\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The mist from the river has created a haze over this path.");
                _console.WriteLine("Right: The water seems to be moving faster down this path..");
                _console.WriteLine("Left: You see alot of giant rocks sticking out of the water...");
                river9 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river9)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverNine();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            RiverTen();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            _console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            _console.ReadLine();
                            _console.Clear();
                            RiverNine();
                            break;
                        }
                }
            }

            void RiverTen()
            {
                string river10;

                _console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: The water looks so clear.");
                _console.WriteLine("Right: The sun is gleamig off of the water. It is blinding.");
                _console.WriteLine("Left: Something just jumped out of the water!");
                river10 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river10)
                {
                    case "1":
                    case "straight":
                        {
                            _console.WriteLine("Something's not right......It's too quiet.....\n\n\n" + "SNAP!\n\n\n" + "A river monster just ate your boat.....and everything in it.....\n\n");
                            _console.WriteLine("Press the 'Enter' key to continue.");
                            _console.ReadLine();
                            _console.Clear();
                            GameOver();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            RiverEleven();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverEleven();
                            break;
                        }
                }
            }

            void RiverEleven()
            {
                string river11;

                _console.WriteLine("The forest surrounding the river gets denser...\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight: You see alot of giant rocks sticking out of the water...");
                _console.WriteLine("Right: You saw something splash into the water...");
                _console.WriteLine("Left: The water seems to be moving faster down this path..");
                river11 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river11)
                {
                    case "1":
                    case "straight":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverTwelve();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.Clear();
                            RiverTwelve();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            RiverTwelve();
                            break;
                        }
                }
            }

            void RiverTwelve()
            {
                string river12;

                _console.WriteLine("The tree line above you is so thick that you can't see any of the sky.\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                _console.WriteLine("\n\nStraight");
                _console.WriteLine("Right");
                _console.WriteLine("Left");
                river12 = _console.ReadLine().ToLower();
                _console.Clear();

                switch (river12)
                {
                    case "1":
                    case "straight":
                        {
                            _console.Clear();
                            YouWin();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            _console.WriteLine("As your floating down the river, you hear the sound of rushing water....\n\n\n\n" + "WATERFALLL!!!\n\n");
                            _console.WriteLine("Press the 'Enter' key to continue.");
                            _console.ReadLine();
                            _console.Clear();
                            GameOver();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Attack();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            YouWin();
                            break;
                        }
                }
            }

            void GameOver()
            {
                _console.Clear();
                _console.WriteLine("GAME OVER");
                _console.WriteLine("Creators: \n\n\n" +
                    " ░█▀▄▀█ █▀▀ █▀▀█ █▀▀▀ 　 █▀▀█ █▀▀▄ █▀▀▄ 　 ░█▀▀█ █▀▀ █▀▀\n" +
                    " ░█░█░█ █▀▀ █▄▄█ █─▀█ 　 █▄▄█ █──█ █──█ 　 ░█▀▀▄ █▀▀ █──\n" +
                    " ░█──░█ ▀▀▀ ▀──▀ ▀▀▀▀ 　 ▀──▀ ▀──▀ ▀▀▀─ 　 ░█▄▄█ ▀▀▀ ▀▀▀\n\n\n");
                Music();
                _console.WriteLine("\n\n\n\n\n Press 'Enter' to continue.");
                _console.ReadLine();
                _console.Clear();
                Run();
            }

            void YouWin()
            {
                Console.BackgroundColor = ConsoleColor.Green;
                _console.WriteLine("Congratulations!\n" + "You have found the lost civilization Pheltuka!\n" + "You Won!\n\n\n\n\n");
                _console.WriteLine("Creators: \n\n\n" +
                    " ░█▀▄▀█ █▀▀ █▀▀█ █▀▀▀ 　 █▀▀█ █▀▀▄ █▀▀▄ 　 ░█▀▀█ █▀▀ █▀▀\n" +
                    " ░█░█░█ █▀▀ █▄▄█ █─▀█ 　 █▄▄█ █──█ █──█ 　 ░█▀▀▄ █▀▀ █──\n" +
                    " ░█──░█ ▀▀▀ ▀──▀ ▀▀▀▀ 　 ▀──▀ ▀──▀ ▀▀▀─ 　 ░█▄▄█ ▀▀▀ ▀▀▀\n\n\n");
                Music();
                _console.WriteLine("\n\n\n\nPress 'Enter' to continue.");
                _console.ReadLine();
                _console.Clear();
                Run();
            }
        }

        public void Attack()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Beep(432, 200);
            Console.Beep(200, 200);
            Console.WriteLine($"You're being attacked!!! Your health is now {Character.Health - 5}");
            Continue();
            Console.Clear();
            Console.Beep(2000, 200);
            Console.Beep(1000, 200);
            Console.WriteLine("What will you do next???");
            Continue();
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("To flee, type 'FLEE'\n" +
                "To attack back, type 'ATTACK'");
            string input = Console.ReadLine().ToLower();
                switch (input) 
            {
                case "attack":
                    AttackBack();
                    break;
                case "FLEE":
                        Flee();
                    break;
            }
        }

        public static void AttackBack()
        {
            Console.Beep(2000, 100);
            Console.WriteLine("You attacked back!!");
            Console.BackgroundColor = ConsoleColor.Green;
            Continue();
            Console.Clear();
            Console.WriteLine("The thing that attacked you... Whatever it was.... is now destroyed...");
            Continue();
            Console.Clear();
        }

        public static void Flee()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Beep();
            Console.WriteLine("You evaded that thing that attacked you... ");
            Console.Clear();
            Console.WriteLine("Whatever it was...");
            Console.WriteLine("Go Back?");
            GoBack();
        }

        //Helper Methods
        public static void Music()
        {
            Console.Beep(261, 200);
            Console.Beep(329, 400);
            Console.Beep(392, 200);
            Console.Beep(440, 400);
            Console.Beep(261, 200);
            Console.Beep(392, 400);
            Console.Beep(440, 400);
            Console.Beep(329, 400);
        }

        public static void GoBack()
        {
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey();
        }
        public static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
