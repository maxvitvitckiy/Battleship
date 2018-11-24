using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Model
{
    class Deck
    {
        char Key { get; }
        int Value { get; }

        public Deck()
        {
            Key = 'A';
            Value = 0;
        }

        public Deck(char k, int v)
        {
            Key = k;
            Value = v;
        }
        
    }
}
