using System;
using System.Dynamic;

namespace SjavsBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = CardMethods.CreateDeck();
            foreach (var card in deck)
            {
                Console.WriteLine("Card: " + card.Number + " of " + card.Suit);
            }
        }
    }
}