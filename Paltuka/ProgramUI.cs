using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class ProgramUI
    {
        public enum Item { slab, };

        public void Run()
        {
            Console.Clear();
            Console.Beep(432, 100);
            Console.WriteLine("You are a former archeologist. You were recently fired for your obsesion with this lost civilization, Pheltuka.The only clues you have that Pheltuka civilization even existed is from some old broken pottery and a busted writing slab that you have been trying to dechpiher for 5 years.You have only translated a small portion of the slab, but you found out that this text talks about trading with Pheltuka and the Uuprese river as the only way to get to Pheltuka. \n" +
              "Will you set out on a journey to uncover this lost civilization? \n" +
              "Type START or YES to start game, then press the ENTER key twice.");
            string command = Console.ReadLine().ToLower();
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.ReadLine();
                if (command.StartsWith("yes") || command.StartsWith("start"))
                {
                    StartGame();
                }
                if (command.StartsWith("no") || command.StartsWith("end"))
                {
                    continueToRun = false;
                }

            }
            void StartGame()
            {
                Console.Clear();
                Console.WriteLine("You wake to the sound of running water. You've been on this journey for five days now");
                //First move to Pheltuka
                Console.WriteLine("Go STRAIGHT, LEFT, RIGHT, ");


                string directionInput = Console.ReadLine().ToLower();
                switch (directionInput)
                {
                    case "straight":
                        Console.WriteLine("Civilization");
                        //Second 
                        Console.WriteLine("Go STRAIGHT, LEFT, RIGHT");
                        string directionInput2 = Console.ReadLine().ToLower();
                        switch (directionInput2)
                        {
                            case "straight":
                                Console.WriteLine("Monster");
                                break;
                            case "right":
                                Console.WriteLine("Monster.");
                                break;
                            case "left":
                                Console.WriteLine("Civilization");
                                //Third
                                Console.WriteLine("Go STRAIGHT, LEFT, RIGHT");
                                string directionInput3 = Console.ReadLine().ToLower();
                                switch (directionInput3)
                                {
                                    case "straight":
                                        Console.WriteLine("Monster.");
                                        break;
                                    case "right":
                                        Console.WriteLine("Civilization");
                                        break;
                                    case "left":
                                        Console.WriteLine("Monster");
                                        break;
                                }
                                break;
                        }
                        break;
                    case "right":
                        Console.WriteLine("Monster.");
                        break;
                    case "left":
                        Console.WriteLine("Monster");
                        break;

                }

            }



            /* bool alive = true;
             while (alive)
             {
                 Console.Clear();

                 string direction = Console.ReadLine().ToLower();
                 if (direction. || direction.StartsWith(" "))
                 {
                     bool found
                 }
             }*/

        }
        //HELPER METHODS
        public void DirectionMenu()
        {
            Console.WriteLine("Go STRAIGHT, LEFT, RIGHT");
            string directionInput = Console.ReadLine().ToLower();
            switch (directionInput)
            {
                case "straight":
                default:
                    break;
                case "right":
                    break;
                case "left":
                    break;
            }
        }
        public void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

    }
}
