using System;
using System.Collections.Generic;
using System.Text;

namespace SjavsBaseClass
{
    class Game
    {
        public Suit Trump { get; set; }
        public List<Card> CurrentHand { get; set; }
        public List<Card> PreviousHand { get; set; }
        public List<Card> TeamAWonCards { get; set; }
        public List<Card> TeamBWonCards { get; set; }
        public int StartingPlayerId { get; set; }
        public List<Player> Players { get; set; }
    }
}
