using System;
using System.Collections.Generic;
using System.Text;

namespace SjavsBaseClass
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
    }
}
