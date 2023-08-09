using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
   public class TWENTYONEGAME:GAME,Iwalkaway
    {
        public TWENTYONEDEALER DEALER { get; set; }
        public override void Play()
        {

            DEALER = new TWENTYONEDEALER();
            foreach (PLAYER player in Players)
            {
                player.HAND = new List<CARD>();
                player.Stay = false;
            }

            DEALER.DECK = new DECK();
            DEALER.Stay = false;
            DEALER.DECK = new DECK();
            Console.WriteLine("Place Your Bet ");

            foreach (PLAYER player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;

            }
            for (int i = 0; i < 2; i++)

            {
                Console.WriteLine("Dealing....");
                foreach (PLAYER player in Players) /// MAY NEED TO CHANGE THIS *** **** **** 
                {
                    Console.Write("{0}:", player.Name);
                    DEALER.Deal(player.HAND);
                    if (i == 1)
                    {


                    }

                }

            }

        }

        public override void ListPlayers()
        {

            Console.WriteLine("21 players");
            base.ListPlayers();
        }
        public void walkaway(PLAYER player)
        {
            throw new NotImplementedException();
        }
    }











}
}
