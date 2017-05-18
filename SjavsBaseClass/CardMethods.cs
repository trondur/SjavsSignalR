using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SjavsBaseClass
{
    public static class CardMethods
    {
        public static int GetTrumps(List<Card> hand)
        {
            return hand.Select(
                card => card.Number == Number.Jack || 
                (card.Number == Number.Queen && (card.Suit == Suit.Clubs || 
                (card.Suit == Suit.Spades))))
                .Count();
        }
        public static int GetNumberOfSuit(List<Card> hand, Suit suit)
        {
            return hand.Select(card => card.Suit == suit).Count();
        }

        public static List<Card> CreateDeck()
        {
            var deck = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var number in Enum.GetValues(typeof(Number)))
                {
                    deck.Add(new Card((Suit)suit, (Number)number));
                }
            }
            deck.Shuffle();
            return deck;
        }
        private static Random rng = new Random();

        private static void Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }   
}
