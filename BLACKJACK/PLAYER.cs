using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class PLAYER
    {
        public PLAYER(string name, int beginningBalance)
        {
            HAND = new List<CARD>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<CARD> _hand = new List<CARD>();
        public List<CARD> HAND { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivlyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size. ");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static GAME operator +(GAME game, PLAYER player)
        {
            game.Players.Add(player);
            return game;
        }

        public static GAME operator -(GAME game, PLAYER player)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
