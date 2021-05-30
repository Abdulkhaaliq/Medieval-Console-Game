using Medieval_Console_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Console_Game
{
    public class GameLogic
    {
        public void WelcomeTitle()
        {
            Console.WriteLine("Welcome to Medieval England 1320.");
            Console.WriteLine("The king is King edward the second and he is a nasty piece of work");
            Console.WriteLine("Your goal is to overthrow King Edward II and become the king of England");
            Console.WriteLine("Goodluck!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Player();
        }
        public static void QuitGame()
        {
            Console.WriteLine("Game Over");
            Console.WriteLine("Want to start over? y/n");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y")
            {
                Player();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Press Enter to Exit...");
                Console.ReadKey();
            }
        }
        public static async void Menu()
        {
            ApiService apiService = new ApiService();
            Console.WriteLine("1. Your Stats");
            Console.WriteLine("2. Your Items");
            Console.WriteLine("3. Quit Game");
            Console.WriteLine("4. Continue Your Journey");
            Console.WriteLine();
            Console.WriteLine("**Only type the number. eg '1'**");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "1":
                    {
                        var stats = await apiService.GetPlayerStats();
                        Console.WriteLine("Your name:" + stats.PlayerName.ToString().ToLower());
                        Console.WriteLine("Your level:" + stats.PlayerLevel.ToString().ToLower());
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        LifePath();
                        break;
                    }

                case "2":
                    {

                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        QuitGame();
                        break;
                    }

                case "4":
                    {
                        LifePath();
                        break;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        public static void Player()
        {

            Console.WriteLine("Elder: Welcome young one. This is the village of York.");
            Console.WriteLine("Your mother spoke about you, what is your name?");
            Console.WriteLine();
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            PlayerModel playerModel = new PlayerModel()
            {
                PlayerName = name,
                PlayerLevel = 1
            };
            //  ApiService apiService = new ApiService();
            // apiService.NewPlayer(playerModel);
            Console.Clear();
            Console.WriteLine($"Elder: A warm welcome to you {playerModel.PlayerName}, it's been so long since I've seen a smile on anyones face.");
            Console.WriteLine("Our king has gone mad and through all of madness, unrest has broken out amongst the people.");
            Console.WriteLine("The king's father died not too long ago and England is about to loose Scotland and our French territories.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            WalkThrough();
        }
        public static void WalkThrough()
        {
            Console.WriteLine("Elder: You're in the righ place if you're aiming to start a new life.");
            Console.WriteLine("But be warned! As easy it is to make friends, it is just as easy to make enemies.");
            Console.WriteLine("If you are ever stuck, just come find me.");
            Console.WriteLine();
            Console.WriteLine("**If you ever need to contact the Elder. Just hit the '?' key on your keyboard.**");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            LifeBegins();
        }
        public static void LifeBegins()
        {
            Console.WriteLine("What would you like to do?:");
            Console.WriteLine("1. Get more info");
            Console.WriteLine("2. Begin to play");
            Console.WriteLine();
            Console.WriteLine("Enter the number:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Console.Clear();
                        MoreInfo();
                        break;
                    }

                case "2":
                    {
                        Console.Clear();
                        LifePath();
                        break;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }


        }

        public static void MoreInfo()
        {
            Console.WriteLine("What would you like to know?");
            Console.WriteLine();
            Console.WriteLine("1. How do you win?");
            Console.WriteLine("2. Which year is this game based in?");
            Console.WriteLine("3. Nevermind, lets play!");
            Console.WriteLine("4. Menu");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Your aim is to become king which will allow England to become a stable country and be at peace once more");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        MoreInfo();
                        break;
                    }

                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("1320");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        MoreInfo();
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        LifePath();
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public static void LifePath()
        {
            
        }
    }

}
