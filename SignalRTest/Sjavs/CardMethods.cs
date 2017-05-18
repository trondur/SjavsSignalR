using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Security.Cryptography;

namespace SignalRTest.Sjavs
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

        public static void Shuffle<T>(this IList<T> list)
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

        public static int GetHandWinner(List<Card> cards, Suit trump)
        {
            var strongestCard = cards[0];
            foreach (var card in cards)
            {
                
            }
        }
        public static Suit ParseSuit(string suit)
        {
            return (Suit) Enum.Parse(typeof(Suit), suit);
        }
        public static Number ParseNumber(string number)
        {
            return (Number)Enum.Parse(typeof(Number), number);
        }
    }   
}
