using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sænkeslagskibe1
{
    internal class PlayerTwo : Player
    {
        
         // Places ships in list
        protected internal override void ShipIntoList()
        {
            ships.Add(hangar);
            ships.Add(battleship);
            ships.Add(destroyer);
            ships.Add(uboat);
            ships.Add(patrol);

        }


        // Places ships on board
        protected internal override void PlaceShips()
        {
            Random random = new Random();

            int x = random.Next(1, 10);
            int y = random.Next(1, 10);

            bool found = true;

            while (found)
            {
                for (int i = 0; i < playerboard.Length; i++)
                {
                    if (playerboard[i, y] == "[ ]")
                    {
                        playerboard[i, y] = "X";
                    }
                }

            }

        }

        // Player shooting
        protected internal override string Shooting(int x, int y)
        {
            if (player.playerboard[x, y] == "X")
            {
                playerlife--;

                return $"You hit";
            }
            else
            {
                return $"You missed";
            }


        }


    }
}
