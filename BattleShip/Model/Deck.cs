using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Model
{
    class Deck
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool isHit { get; set; }

        public Deck()
        {
            X = 0;
            Y = 0;
            isHit = false;
        }

        public Deck(int x, int y)
        {
            X = x;
            Y = y;
            isHit = false;
        }

        public void Hit()
        {
            isHit = true;
        }
    }
}
