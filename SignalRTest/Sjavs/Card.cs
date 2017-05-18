using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRTest.Sjavs
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Number Number { get; set; }

        public Card(Suit suit, Number number)
        {
            Suit = suit;
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString() + " of " + Suit.ToString();
        }

        public bool DefeatedBy(Card card, Suit trump)
        {
            
        }
    }
}
