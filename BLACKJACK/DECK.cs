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

            // CARD  IS A PROPERTY OF THE DECK CLASS-YOU DON'T NEED TO PUT THE DATATYPE
            // OR GIVE IT A VARIABLE NAME

            // CREATE TWO LISTS
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
             "Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"
            };
            foreach (string face in Faces)
            {

                foreach (string suit in Suits)
                {
                    CARD card = new CARD();  // CREATE A CARD OBJECT EACH TIME IT LOOPS
                    card.Suit = suit;// ASSIGN A SUIT
                    card.Face = face;// ASSIGN A FACE
                    CARDS.Add(card); // ADDS THE OUPUT TO THIS LIST

                }

            }
        }
        public List<CARD> CARDS { get; set; } // PROPERTY

    }
}
