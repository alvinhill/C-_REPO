using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Casino - What is Your Name? ");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("How Much Mondey Do You Have?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello,{0},Would you like to join a game of 21 right now? ", playerName);
            string answer = Console.ReadLine().ToLower();
            
            
            if (answer == "yes" || answer == "yeah" || answer == "y" )
            {
                PLAYER player = new PLAYER(playerName, bank);
                GAME game = new TWENTYONEGAME();
                game += player;
                player.isActivlyPlaying = true;
                while (player.isActivlyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("thank you for playing");
            }
            Console.WriteLine("Feel free to look aroung the casino. bye for now. ");
            Console.Read();



        }
    }
}
