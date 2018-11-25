using BattleShip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Controller
{
    public class Controller
    {
        BattleField bf;
        public Controller()
        {
            bf = new BattleField();
        }

        /// <summary>
        /// creates a new ship on the battlefield
        /// </summary>
        /// <param name="decksCount">count of the ship decks</param>
        /// <param name="startPosX">start ship position on the battlefield</param>
        /// <param name="startPosY">start ship position on the battlefield</param>
        /// <param name="orientation">ship orientation. 1 - vertical, 0 - horizontal</param>
        public void CreateShip(int decksCount, int startPosX, int startPosY, bool orientation)
        {
            if (IsPossibleToCreate(decksCount, startPosX, startPosY, orientation))
            {
                List<Deck> d = new List<Deck>();
                for (int i = 0; i < decksCount; i++)
                {
                    d.Add(new Deck(startPosX, startPosY));
                    if (orientation)
                    {
                        startPosY++;
                    }
                    else startPosX++;
                }
                bf.AddShip(new Ship(d));
            }
        }

        private bool IsPossibleToCreate(int decksCount, int startPosX, int startPosY, bool orientation)
        {
            bool _isPos = false;
            if (orientation)
            {
                for (int i = 0; i < decksCount; i++)
                {
                    if (bf.ReturnDeckAtCoords(startPosX + i, startPosY) == null &&
                        bf.ReturnDeckAtCoords(startPosX + 1 + i, startPosY) == null &&
                        bf.ReturnDeckAtCoords(startPosX - 1 + i, startPosY) == null &&
                        bf.ReturnDeckAtCoords(startPosX + i, startPosY + 1) == null &&
                        bf.ReturnDeckAtCoords(startPosX + i, startPosY - 1) == null &&
                        bf.ReturnDeckAtCoords(startPosX + 1+i, startPosY + 1) == null &&
                        bf.ReturnDeckAtCoords(startPosX + 1 + i, startPosY - 1) == null &&
                        bf.ReturnDeckAtCoords(startPosX - 1 + i, startPosY + 1) == null &&
                        bf.ReturnDeckAtCoords(startPosX - 1 + i, startPosY + 1) == null)
                    {
                        _isPos = true;
                    }
                    else return false;
                }
            }
            if (!orientation)
            {
                for (int i = 0; i < decksCount; i++)
                {
                    if (bf.ReturnDeckAtCoords(startPosX , startPosY + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX + 1 + i, startPosY + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX - 1 + i, startPosY + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX, startPosY + 1 + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX, startPosY - 1 + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX + 1, startPosY + 1 + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX + 1, startPosY - 1 + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX - 1, startPosY + 1 + i) == null &&
                        bf.ReturnDeckAtCoords(startPosX - 1, startPosY + 1 + i) == null)
                    {
                        _isPos = true;
                    }
                    else return false;
                }
            }
            return _isPos;
        }

        public bool IsDeck(int x, int y)
        {
            if (bf.ReturnDeckAtCoords(x, y) != null) return true;
            return false;
        }
        public void ClearShips()
        {
            bf.ClearShips();
        }

    }
}
