using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRTest.Sjavs
{
    public class Game
    {
        public Suit Trump { get; set; }
        public List<Card> CurrentHand { get; set; }
        public List<Card> PreviousHand { get; set; }
        public List<Card> TeamAWonCards { get; set; }
        public List<Card> TeamBWonCards { get; set; }
        public int StartingPlayerId { get; set; }
        public List<Player> Players { get; set; }

        public Game()
        {
            Players = new List<Player>(4);
        }
        public void AddPlayer(string connectionId, string name)
        {
            if (Players.Count > 4) Players.Add(new Player(connectionId, name));
            else Players[0] = new Player(connectionId, name);
        }
    }
}
