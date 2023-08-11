using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class DEALER
    {
        //adding a class as a property instead of inheriting it
        public string Name { get; set; }
        public DECK DECK { get; set; }
        public int Balance { get; set; }


        public void Deal(List<CARD> HAND)
        {
            HAND.Add(DECK.CARDS.First());
            Console.WriteLine(DECK.CARDS.First().ToString() + "\n");
            DECK.CARDS.RemoveAt(0);

        }


    }
}
