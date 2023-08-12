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

            DEALER.HAND = new List<CARD>();// new

          
            DEALER.Stay = false;
            DEALER.DECK = new DECK();
            DEALER.DECK.Shuffle();
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
                   // START NEW PART
                    
                    // I WENT BACK TO VIDEO # 4 STILL NOT SURE 
                    
                    
                    
                    // END NEW PART
                    Console.Write("                  {0}:", player.Name);
                    DEALER.Deal(player.HAND);
                    if (i == 1)
                    {

                        bool blackjack = TwentyOneRules.CheckForBlackJack(player.HAND);
                            if(blackjack)
                        {
                            Console.WriteLine("Blackjack!:{0} wins {1}", player, Name, Bets[player]);
                            player.Balance+=Convert.ToInt32((Bets[player]*1.5)+Bets[player]);
                            Bets.Remove(player);
                            return;
                        }
                    }

                }


                // THINK OVERRIDE SHOULD GO HERE
                Console.Write("Dealer: ");
                DEALER.Deal(DEALER.HAND);
                    if (i==1)
                {
                    bool blackjack = TwentyOneRules.CheckForBlackJack(DEALER.HAND);
                    if(blackjack)
                        {
                        Console.WriteLine("Dealer has Blackjack! Everybody Loses!");
                        foreach(KeyValuePair<PLAYER, int> entry in Bets)
                        {
                         DEALER.Balance += entry.Value;    
                        }


                    }
                }
            }
          
            foreach (PLAYER player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach(CARD card in player.HAND)
                    {
                        Console.Write("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                        DEALER.Deal(player.HAND);
                }
                bool busted = TwentyOneRules.isBusted(player.HAND);
                if(busted)
                {
                    DEALER.Balance += Bets[player];
                    Console.WriteLine("{0} Busted!, You lose you bet of {1},Your balance is now {2}.",player.Name, Bets[player], player.Balance);
                    Console.WriteLine("Do you want to play again?");
                    string answer = Console.ReadLine().ToLower();// I PUT STRING IN FRONT OF ANSWER
                    if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "Y")
                    {
                        player.isActivlyPlaying = true;

                    }
                    else
                    {
                        player.isActivlyPlaying = false;
                    }


                }

            }

            DEALER.isBusted = TwentyOneRules.isBusted(DEALER.HAND);//MIGHT NEED TO GO ONE LOWER
            DEALER.Stay = TwentyOneRules.ShouldDealerStay(DEALER.HAND);
            while(DEALER.Stay && !DEALER.isBusted)
            {
                Console.WriteLine("Dealer is Hitting...");
                    DEALER.Deal(DEALER.HAND);
                DEALER.isBusted = TwentyOneRules.isBusted(DEALER.HAND);
                DEALER.Stay = TwentyOneRules.ShouldDealerStay(DEALER.HAND);
            }
            if( DEALER.Stay)
            {

                Console.WriteLine("Dealer is Staying");
            }
            if (DEALER.isBusted)
            {
                Console.WriteLine("Dealer Busted!");

               foreach (KeyValuePair<PLAYER,int> entry in Bets)
                    {
                   // Console.WriteLine("{0} won {1}!", entry.Key, Name, entry.Value);// line 142
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);// line 142
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    DEALER.Balance -= entry.Value;

                }
                return;
            }
            foreach (PLAYER player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.HAND,DEALER.HAND);
                if (playerWon==null)
                {
                    Console.WriteLine("Push! No one wins. ");
                    player.Balance += Bets[player];

                }
                else if (playerWon==true)
                {

                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    DEALER.Balance -= Bets[player];

                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    DEALER.Balance += Bets[player];
                }

                Console.WriteLine("Play again? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "Y")
                {
                    player.isActivlyPlaying = true;

                }
                else
                {
                    player.isActivlyPlaying = false;
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

