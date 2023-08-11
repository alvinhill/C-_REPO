using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class DECK
    {
        public DECK()
        {
            CARDS = new List<CARD>(); // property// ** list name might be wrong "part 2-4:30"
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    CARD card = new CARD();
                    card.Face = (Face)j;
                    card.Suit = (Suit)i;
                    CARDS.Add(card);
                }

            }
        }
        public List<CARD> CARDS { get; set; } // PROPERTY

        public void Shuffle(int times=1)
        {
            for (int i = 0; i < times; i++)
            {
                List<CARD> TempList = new List<CARD>();
                Random random = new Random();

                while (CARDS.Count>0)
                {
                    int randomIndex = random.Next(0, CARDS.Count);
                    TempList.Add(CARDS[randomIndex]);
                    CARDS.RemoveAt(randomIndex);


                }

                CARDS = TempList;

            }


        }


        
    }
}
