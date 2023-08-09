using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public class CARD
    {

        public CARD()
        {

            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; } // THIS IS A PROPERTY

        public string Face { get; set; } // THIS IS A PROPERTY


    }
    public enum Suit
    {
        Spades,
        Clubs,
        Diamons,
        Hearts
    }
    public enum Face

    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }







}

