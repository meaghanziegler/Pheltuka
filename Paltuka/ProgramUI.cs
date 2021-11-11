using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class ProgramUI
    {
        public void Run()
        {

            Console.WriteLine("Welcome to");
            Console.WriteLine("████████████████████████████████████████████████\n" +
                              "█▄─▄▄─█─█─█▄─▄▄─█▄─▄███─▄─▄─█▄─██─▄█▄─█─▄██▀▄─██\n" +
                              "██─▄▄▄█─▄─██─▄█▀██─██▀███─████─██─███─▄▀███─▀─██\n" +
                              "▀▄▄▄▀▀▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀\n");
            Music();
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            Story();


            void Story()
            {
                Console.WriteLine("You are a former archeologist. \n" +
                    "You were recently fired for your obsession with this lost civilization, Pheltuka. \n" +
                    "The only clues you have that Pheltuka civilization even existed is from some old broken pottery \n" + "and a busted writing slab that you have been trying to dechpiher for 5 years. \n" + "You have only translated a small portion of the slab, but you found out that the text talks about two things: \n" + "trading with Pheltuka and the Uuprese river as the only way to get to Pheltuka. \n" +
                   "\nWill you set out on a journey to uncover this lost civilization? \n" +
                   "\n\nType START or YES to start game, then press the ENTER key.");
                string start = Console.ReadLine().ToLower();
                bool beginJourney = true;
                while (beginJourney)
                {
                    if (start.StartsWith("yes") || start.StartsWith("start"))
                    {
                        Console.Clear();
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
                Console.WriteLine("You set out on your adventure, the fastest way to the Uuprese river is through a small forest. \n" + "Thankfully, your good friend Konami has a map of the forest that he is willing to give you. \n\n\n" + "Do you enter into the forest? \n" + "YES or NO");

                string start2 = Console.ReadLine().ToLower();
                bool beginForest = true;
                while (beginForest)
                {
                    if (start2.StartsWith("yes") || start2.StartsWith("start"))
                    {
                        Console.Clear();
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

                Console.WriteLine("You start off on your adventure. \n" +
                    "Shortly into your journey you come across your first decision. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nUp: The incline is small but steep.");
                Console.WriteLine("Right: It's quiet....");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You can see the sun shining through the trees.");
                forest1 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest1)
                {
                    case "1":
                    case "up":
                        {
                            Console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            ToRiverOne();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.WriteLine("What? You scared? \n" + "Press 'Enter' to contniue.");
                            Console.ReadLine();
                            Console.Clear();
                            First();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void ForestTwo()
            {
                string forest2;

                Console.WriteLine("You made it to a small landing on the incline. \n" +
                    "You have another decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nUp: Continue up the incline.");
                Console.WriteLine("Right: You saw some brush moving up ahead...");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: It's quiet...");
                forest2 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest2)
                {
                    case "1":
                    case "up":
                        {
                            Console.Clear();
                            ForestThree();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestOne();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Console.WriteLine("While walking down the path, you decide to look around and admire the nature./n" + "You are in such awe by the view, you don't realize that you are walking into a bear trap./n" + "Way to go, you bled to death by stepping in a bear trap..../n" + "...hope the view was worth it....");
                            Console.WriteLine("\n\n\nPress 'Enter'.");
                            Console.ReadLine();
                            GameOver();
                            break;
                        }
                }
            }

            void ForestThree()
            {
                string forest3;

                Console.WriteLine("You made it to the top of the incline. \n" +
                    "You can see your house from here! \n" +
                    "But enough sight seeing, you have another decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nDown: Start the trek down the incline.");
                Console.WriteLine("Right: The sun is shining brightly over there.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You saw some brush moving up ahead...");
                forest3 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest3)
                {
                    case "1":
                    case "down":
                        {
                            Console.Clear();
                            ForestFour();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("There's a gold coin on the ground...it seems ancient..");
                            Console.WriteLine("Do you want to pick it up?");
                            Console.ReadLine();
                            Console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestTwo();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void ForestFour()
            {
                string forest4;

                Console.WriteLine("You made it to another clearing on the incline. \n" +
                    "You see that you have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nDown: Continue down the incline.");
                Console.WriteLine("Right: There's a strange fog down this path.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: It's quiet...");
                forest4 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest4)
                {
                    case "1":
                    case "down":
                        {
                            Console.Clear();
                            ForestFive();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestThree();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestFour();
                            break;
                        }
                }
            }

            void ForestFive()
            {
                string forest5;

                Console.WriteLine("You made it down the incline! \n" +
                    "You see that you have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: The trees are so dense down this path that they block out the sun.");
                Console.WriteLine("Right: It's quiet...");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You saw some brush moving up ahead...");
                forest5 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest5)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestFive();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("As you are walking down the path, you accidentally run into a spiderweb\n" + "The spider of the now destroyed web fell onto you and bit you.\n" + "After being biten by the spider, you started to feel strange.\n" + "Next thing you know everything around you is gigantic! You have been turned into a spider!\n" + "The spider that turned you aproaches and then leads you to the spider king.");
                            Console.WriteLine("\n\n\nWay to go, you were turned into a spider...\n" + "Press 'Enter' to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestFour();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Console.Clear();
                            ForestSix();
                            break;
                        }
                }
            }

            void ForestSix()
            {
                string forest6;

                Console.WriteLine("Congratulations! You didn't die going down that path! \n" + "Now pick another path!\n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: Left path is lying.");
                Console.WriteLine("Right: The left path is the correct path.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: Right path is lying.");
                forest6 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest6)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestSix();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestFive();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void ForestSeven()
            {
                string forest7;

                Console.WriteLine("You know the drill... \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: I can barely see down this path....");
                Console.WriteLine("Right: There's a strange fog down this path.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: The sun is shining brightly over there.");
                forest7 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest7)
                {
                    case "1":
                    case "striaght":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestSix();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Console.Clear();
                            ForestEight();
                            break;
                        }
                }
            }

            void ForestEight()
            {
                string forest8;

                Console.WriteLine("You see something up ahead... \n" +
                    "You see that you have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: Continue down the incline.");
                Console.WriteLine("Right: The sun is shining brightly over there.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You saw some brush moving up ahead...");
                forest8 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest8)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestEight();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            ForestNine();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestSeven();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void ForestNine()
            {
                string forest9;

                Console.WriteLine("You notice some signs up ahead. Each sign has a different letter. \n" + "You notice that the handwriing looks similar to Konami's...\n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nX: Continue down the incline.");
                Console.WriteLine("A: The sun is shining brightly over there.");
                Console.WriteLine("B: Do you want to go back?");
                Console.WriteLine("Y: You saw some brush moving up ahead...");
                Console.WriteLine("Back: Do you want to go back?");
                forest9 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest9)
                {
                    case "x":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "a":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestNine();
                            break;
                        }
                    case "b":
                        {
                            Console.Clear();
                            ForestTen();
                            break;
                        }
                    case "y":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestNine();
                            break;
                        }
                    case "5":
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestEight();
                            break;
                        }
                }
            }

            void ForestTen()
            {
                string forest10;

                Console.WriteLine("You see more signs writen in what appears to be Konami's handwriting. \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nX: Continue down the incline.");
                Console.WriteLine("A: The sun is shining brightly over there.");
                Console.WriteLine("B: Do you want to go back?");
                Console.WriteLine("Y: You saw some brush moving up ahead...");
                Console.WriteLine("Back: Do you want to go back?");
                forest10 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (forest10)
                {
                    case "x":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "a":
                        {
                            Console.WriteLine("There's a note on the ground...it says if you go back and go down the path with sign 'Y', there is a surprise.");
                            Console.WriteLine("\n\nPress 'Enter' to go back.");
                            Console.ReadLine();
                            Console.Clear();
                            ForestTen();
                            break;
                        }
                    case "b":
                        {
                            Console.WriteLine("There was a pitfall there....\n" + "You fell...\n" + "How am I not surprised...");
                            Console.WriteLine("\n\nPress 'Enter' to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                            break;
                        }
                    case "y":
                        {
                            Console.WriteLine("You run into a bunch of talking animals...\n" + "They call themselves the 'Woodland Critters'. \n" + "They seemed to have misplaced a gold coin. The critters need the coin for a.....party....\n" + "They are asking if you have the coin.\n\n" + "Type 'Use' or 'Give' to give the coin to the Woodland Critters.\n" + "If you don't have the coin or don't want to give them the coin, type 'NA'.");
                            string coin = Console.ReadLine().ToLower();
                            bool item = true;
                            while (item)
                            {
                                if (coin.StartsWith("use") || coin.StartsWith("give"))
                                {
                                    Console.Clear();
                                    Console.WriteLine("The Woodland Critters thank you for helping them find thier coin.\n" + "As payment for helping them, they show you a fast route to the Uuprese river.");
                                    Console.WriteLine("\n\n\nPress the 'Enter' key tocontinue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    River();
                                }
                                if (coin.StartsWith("no") || coin.StartsWith("na"))
                                {
                                    item = false;
                                    Console.Clear();
                                    Console.WriteLine("You either don't have the coin or chose not to give the coin to the Woodland Critters. They did not like this answer....");
                                    Console.WriteLine("Press 'Enter' to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    GameOver();

                                }
                            }
                            break;
                        }
                    case "5":
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestNine();
                            break;
                        }
                }
            }

            void ToRiverOne()
            {
                string toRiver1;

                Console.WriteLine("You decided that there was no way you were going up that incline.\n" + "You figure that there is a way around the incline to the Uuprese river.\n\n" +
                  "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: You saw some brush moving up ahead...");
                Console.WriteLine("Right: The trees are so dense down this path that they block out the sun.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You saw some brush moving up ahead...");
                toRiver1 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (toRiver1)
                {
                    case "1":
                    case "straight":
                        {
                            Console.Clear();
                            ToRiverTwo();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ToRiverOne();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ForestOne();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void ToRiverTwo()
            {
                string toRiver2;

                Console.WriteLine("You can hear the faintest sound of water.. \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: You can see the sun shining through the trees.");
                Console.WriteLine("Right: There's a strange fog down this path.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You saw some brush moving up ahead...");
                toRiver2 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (toRiver2)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ToRiverTwo();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            ToRiverThree();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ToRiverOne();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ToRiverTwo();
                            break;
                        }
                }
            }

            void ToRiverThree()
            {
                string toRiver3;

                Console.WriteLine("You know what to do...\n\n" +
                      "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: I am the correct path to take.");
                Console.WriteLine("Right: Straight path is lying..");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: Right path is lying..");
                toRiver3 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (toRiver3)
                {
                    case "1":
                    case "straight":
                        {
                            Console.Clear();
                            ToRiverFour();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ToRiverTwo();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void ToRiverFour()
            {
                string toRiver4;

                Console.WriteLine("The water sounds so close! \n" +
                    "You have a decision to make. \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: Continue down the incline.");
                Console.WriteLine("Right: The sun is shining brightly over there.");
                Console.WriteLine("Back: Do you want to go back?");
                Console.WriteLine("Left: You saw some brush moving up ahead...");
                toRiver4 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (toRiver4)
                {
                    case "1":
                    case "straight":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            River();
                            break;
                        }
                    case "3":
                    case "back":
                        {
                            Console.Clear();
                            ToRiverThree();
                            break;
                        }
                    case "4":
                    case "left":
                        {
                            Console.WriteLine("Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            ToRiverFour();
                            break;
                        }
                }
            }

            void River()
            {
                Console.WriteLine("You made it to the Uuprese river!\n" + "While looking around, you notice a paddle boat near the water.");
                Console.WriteLine("\n\n\nDo you take the paddle boat down the river?\n" + "Type 'Start' or 'Yes' to continue down the river.");
                string riverStart = Console.ReadLine().ToLower();
                bool beginRiverJourney = true;
                while (beginRiverJourney)
                {
                    if (riverStart.StartsWith("yes") || riverStart.StartsWith("start"))
                    {
                        Console.Clear();
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

                Console.WriteLine("You finally start to make your way down the Uuprese river!\n" + "You are one step closer to discovering Pheltuka! ....hopefully..\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The mist from the river has created a haze over this path.");
                Console.WriteLine("Right: The water is calm..");
                Console.WriteLine("Left: You see alot of giant rocks sticking out of the water...");
                river1 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river1)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverOne();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Console.Clear();
                            RiverTwo();
                            break;
                        }
                }
            }

            void RiverTwo()
            {
                string river2;

                Console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: Something just jumped out of the water!");
                Console.WriteLine("Right: The water seems to be moving faster down this path..");
                Console.WriteLine("Left: The water is so clear.");
                river2 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river2)
                {
                    case "1":
                    case "straight":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Console.Clear();
                            RiverThree();
                            break;
                        }
                }
            }

            void RiverThree()
            {
                string river3;

                Console.WriteLine("You think about how long you have been on this advenutre......how far from home you are......with no cellphone service.....\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The water is calm..");
                Console.WriteLine("Right: The mist from the river has created a haze over this path.");
                Console.WriteLine("Left: You saw something splash into the water...");
                river3 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river3)
                {
                    case "1":
                    case "straight":
                        {
                            Console.Clear();
                            RiverFour();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverThree();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void RiverFour()
            {
                string river4;

                Console.WriteLine("You feel as if you are being wathced.....\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The water seems to be moving faster down this path..");
                Console.WriteLine("Right: You see alot of giant rocks sticking out of the water...");
                Console.WriteLine("Left: You saw something splash into the water...");
                river4 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river4)
                {
                    case "1":
                    case "straight":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverFour();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Console.Clear();
                            RiverFive();
                            break;
                        }
                }
            }

            void RiverFive()
            {
                string river5;

                Console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The mist from the river has created a haze over this path.");
                Console.WriteLine("Right: The sun is gleaming off of the water. It is blinding.");
                Console.WriteLine("Left: Something just jumped out of the water!");
                river5 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river5)
                {
                    case "1":
                    case "straight":
                        {
                            Console.Clear();
                            RiverSix();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverFive();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void RiverSix()
            {
                string river6;

                Console.WriteLine("You start to see things like directional signs and what appears to be a field for crops.\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The water seems to be moving faster down this path..");
                Console.WriteLine("Right: The water is so clear.");
                Console.WriteLine("Left: You see alot of giant rocks sticking out of the water...");
                river6 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river6)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("Your boat accidentally runs into some brush on top of the water, \n" + "you didn't realize that there was a bees that lived in the brush.\n" + "The bees start attacking you.\n\n" + "You're allergic to bees!\n\n" + "You forgot to pack an EpiPen...\n" + "I don't even feel sorry for you....");
                            Console.WriteLine("\n\nPress the 'Enter' key to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            RiverSeven();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void RiverSeven()
            {
                string river7;

                Console.WriteLine(" You know the drill.... \n\n" + "Which way do you want to go?");
                Console.WriteLine("\n\nStraight: Don't pick the left path.");
                Console.WriteLine("Right: Straight path is lying..");
                Console.WriteLine("Left: Don't pick the right path.");
                river7 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river7)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverSeven();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Console.Clear();
                            RiverEight();
                            break;
                        }
                }
            }

            void RiverEight()
            {
                string river8;

                Console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: Something just jumped out of the water!");
                Console.WriteLine("Right: The sun is gleamig off of the water. It is blinding.");
                Console.WriteLine("Left: The water looks so clear.");
                river8 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river8)
                {
                    case "1":
                    case "straight":
                        {
                            Console.Clear();
                            RiverNine();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverEight();
                            break;
                        }
                }
            }

            void RiverNine()
            {
                string river9;

                Console.WriteLine("You see some large pillars in the water. They look like worn totem poles..\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The mist from the river has created a haze over this path.");
                Console.WriteLine("Right: The water seems to be moving faster down this path..");
                Console.WriteLine("Left: You see alot of giant rocks sticking out of the water...");
                river9 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river9)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverNine();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            RiverTen();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            Console.WriteLine("You end up in a small lake.\n" + "The water is calm and everything is peacful, but ultimately there is nowhere to go from here.\n" + "Dead end. To go back, press 'Enter'.");
                            Console.ReadLine();
                            Console.Clear();
                            RiverNine();
                            break;
                        }
                }
            }

            void RiverTen()
            {
                string river10;

                Console.WriteLine("You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: The water looks so clear.");
                Console.WriteLine("Right: The sun is gleamig off of the water. It is blinding.");
                Console.WriteLine("Left: Something just jumped out of the water!");
                river10 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river10)
                {
                    case "1":
                    case "straight":
                        {
                            Console.WriteLine("Something's not right......It's too quiet.....\n\n\n" + "SNAP!\n\n\n" + "A river monster just ate your boat.....and everything in it.....\n\n");
                            Console.WriteLine("Press the 'Enter' key to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            RiverEleven();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void RiverEleven()
            {
                string river11;

                Console.WriteLine("The forest surrounding the river gets denser...\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight: You see alot of giant rocks sticking out of the water...");
                Console.WriteLine("Right: You saw something splash into the water...");
                Console.WriteLine("Left: The water seems to be moving faster down this path..");
                river11 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river11)
                {
                    case "1":
                    case "straight":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.Clear();
                            RiverTwelve();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void RiverTwelve()
            {
                string river12;

                Console.WriteLine("The tree line above you is so thick that you can't see any of the sky.\n" +
                    "You notice that the river splits off into three different directions ahead. \n\n" + "Which way do you go?");
                Console.WriteLine("\n\nStraight");
                Console.WriteLine("Right");
                Console.WriteLine("Left");
                river12 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (river12)
                {
                    case "1":
                    case "straight":
                        {
                            Console.Clear();
                            YouWin();
                            break;
                        }
                    case "2":
                    case "right":
                        {
                            Console.WriteLine("As your floating down the river, you hear the sound of rushing water....\n\n\n\n" + "WATERFALLL!!!\n\n");
                            Console.WriteLine("Press the 'Enter' key to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            GameOver();
                            break;
                        }
                    case "3":
                    case "left":
                        {
                            //insert animal attack here
                            //fight or flight
                            break;
                        }
                }
            }

            void GameOver()
            {
                Console.Clear();
                Console.WriteLine("GAME OVER");
                Console.WriteLine("Creators: \n\n\n" +
                    " ░█▀▄▀█ █▀▀ █▀▀█ █▀▀▀ 　 █▀▀█ █▀▀▄ █▀▀▄ 　 ░█▀▀█ █▀▀ █▀▀\n" +
                    " ░█░█░█ █▀▀ █▄▄█ █─▀█ 　 █▄▄█ █──█ █──█ 　 ░█▀▀▄ █▀▀ █──\n" +
                    " ░█──░█ ▀▀▀ ▀──▀ ▀▀▀▀ 　 ▀──▀ ▀──▀ ▀▀▀─ 　 ░█▄▄█ ▀▀▀ ▀▀▀\n\n\n");
                Music();
                Console.WriteLine("\n\n\n\n\n Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                Run();
            }

            void YouWin()
            {
                Console.WriteLine("Congratulations!\n" + "You have found the lost civilization Pheltuka!\n" + "You Won!\n\n\n\n\n");
                Console.WriteLine("Creators: \n\n\n" +
                    " ░█▀▄▀█ █▀▀ █▀▀█ █▀▀▀ 　 █▀▀█ █▀▀▄ █▀▀▄ 　 ░█▀▀█ █▀▀ █▀▀\n" +
                    " ░█░█░█ █▀▀ █▄▄█ █─▀█ 　 █▄▄█ █──█ █──█ 　 ░█▀▀▄ █▀▀ █──\n" +
                    " ░█──░█ ▀▀▀ ▀──▀ ▀▀▀▀ 　 ▀──▀ ▀──▀ ▀▀▀─ 　 ░█▄▄█ ▀▀▀ ▀▀▀\n\n\n");
                Music();
                Console.WriteLine("\n\n\n\nPress 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                Run();
            }
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
    }
}
