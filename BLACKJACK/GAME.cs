using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public abstract class GAME
    {
        public List<PLAYER> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<PLAYER, int> Bets { get; set; }

        public abstract void Play();// MUST USE THIS METHOD -  this is a abastact method

        public virtual void ListPlayers()
        {

            foreach (PLAYER player in Players)
            {
                Console.WriteLine(player.Name);
            }

        }








    }
}
