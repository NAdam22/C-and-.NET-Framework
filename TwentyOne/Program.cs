using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            //string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\naifa\\Logs\\log.txt", text);

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name. ");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money didi you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}, would you like join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Fell free to look around the casino. Bye for now.");
            Console.ReadLine();


        }

    }
}
