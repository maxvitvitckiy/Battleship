using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Model
{
    class BattleField
    {
        List<Ship> ships;

        public BattleField()
        {
            ships = new List<Ship>();
        }
        
        public void ClearShips() { ships = new List<Ship>(); }

        public void AddShip(Ship s)
        {
            ships.Add(s);
        }

        public Deck ReturnDeckAtCoords(int x, int y)
        {
            foreach(Ship s in ships)
            {
                foreach(Deck d in s.Decks)
                {
                    if (d.X == x && d.Y == y) return d;
                }
            }
            return null;
        }
    }
}
