using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Console_Game
{
    public class GameHeavyLogic
    {
        public void LifePath()
        {
            Console.Clear();
            Console.WriteLine("Elder: Your journey begins now young warrior.");
            Console.WriteLine("First you have to find a job, it could potentially lead to other oppurtunities.");
            Console.WriteLine("Press Enter to continue...");
            JobCenter();
        }

        public static async void JobCenter()
        {
            ApiService apiService = new ApiService();
            Console.Clear();
            Console.WriteLine("Sherrif: Welcome young traveller.");
            Console.WriteLine("Here you will be able to access the jobs based on your level.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Would you like to view your stats? y/n");
            string choice = Console.ReadLine().ToLower();
            Console.Clear();
            if(choice == "y")
            {
                var level = await apiService.GetPlayerStats();
                Console.WriteLine($"Level: {level.PlayerLevel}");
                Console.WriteLine("You will also be able to see in menu");
                Console.WriteLine("Press Enter to continue...");

            }
            else
            {
                Console.WriteLine("Press Enter to continue...");
            }
        }
    }
}
