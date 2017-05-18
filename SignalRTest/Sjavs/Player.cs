using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRTest.Sjavs
{
    public class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

        public Player(string connectionId, string name)
        {
            Id = connectionId;
            Name = name;
        }
    }
}
