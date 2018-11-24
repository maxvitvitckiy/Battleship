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
        string keys = "ABCDEFGHTJ";
        string values = "0123456789";

        public BattleField(List<Ship> sh)
        {
            ships = sh;
        }
        
    }
}
