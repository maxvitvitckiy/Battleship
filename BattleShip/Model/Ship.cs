using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Model
{
    class Ship
    {
        public List<Deck> Decks { get; }
        
        public Ship()
        {

        }
        public Ship(List<Deck> d)
        {
            Decks = d;
        }
        public void AddDeck( Deck d)
        {
            Decks.Add(d);
        }
    }

}
