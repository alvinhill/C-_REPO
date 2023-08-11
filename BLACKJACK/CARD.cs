using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK
{
    public struct CARD
    {

        public Suit Suit { get; set; } // THIS IS A PROPERTY
        public Face Face { get; set; } // THIS IS A PROPERTY
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);

        }


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

