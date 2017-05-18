using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRTest.Sjavs;

namespace SignalRTest
{
    public class ChatHub : Hub
    {
        public static Game Game { get; set; }
        public void PlayCard(string player, string suit, string number)
        {
            if (Game == null)
            {
                Game = new Game { CurrentHand = new List<Card>() };
            }
            Game.CurrentHand.Add(new Card(CardMethods.ParseSuit(suit), CardMethods.ParseNumber(number)));
            if (Game.CurrentHand.Count == 4)
            {
                Clients.All.broadcastPlayedCard(Context.ConnectionId, "hand finished");
                CardMethods.
            }
        }

        public void StartGame()
        {
            Game = new Game();
            var hands = CardMethods.CreateDeck()
                    .Select((x, i) => new { Index = i, Value = x })
                    .GroupBy(x => x.Index / 4)
                    .Select(x => x.Select(v => v.Value).ToList())
                    .ToList();
            Clients.Client("").deal(hands[0]);
            Clients.Client("").deal(hands[1]);
            Clients.Client("").deal(hands[2]);
            Clients.Client("").deal(hands[3]);
        }
    }
}