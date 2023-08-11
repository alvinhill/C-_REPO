using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public abstract class GAME
    {
        private List<PLAYER> _players = new List<PLAYER>();
        private Dictionary<PLAYER, int> _bets = new Dictionary<PLAYER, int>();

        public List<PLAYER> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<PLAYER, int> Bets { get { return _bets; } set { _bets = value; } }

        
        

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
