using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sænkeslagskibe1
{
    internal abstract class Player
    {
        // Your playerboard
        protected internal string[,] playerboard = new string[11,11]
        {
        { "[ ]","[A]","[B]", "[C]", "[D]", "[E]", "[F]", "[G]", "[H]", "[I]", "[J]"},
        { "[1]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[2]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[3]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[4]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[5]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[6]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[7]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[8]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[9]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        { "[10]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]","[ ]", "[ ]", "[ ]"}
        };

        // Enemy playerboard
        public string[,] enemyplayerboard = new string[11,11]
        {
        {"[ ]","[A]","[B]", "[C]", "[D]", "[E]", "[F]", "[G]", "[H]", "[I]", "[J]"},
        {"[1]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[2]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[3]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[4]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[5]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[6]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[7]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[8]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[9]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"},
        {"[10]","[ ]","[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]","[ ]", "[ ]", "[ ]"}
        };

       

        // instances and valueables
        protected internal List<Ship> ships = new List<Ship>();
        protected internal Ship hangar = new HangarShip();
        protected internal Ship battleship = new BattleShip();
        protected internal Ship destroyer = new Destroyer();
        protected internal Ship uboat = new Uboat();
        protected internal Ship patrol = new PatrolBoat();
        protected internal PlayerOne player = new PlayerOne();
        protected internal Random random = new Random();
        protected internal int playerlife;


        protected internal string [,] PlayerBoard
        {
            get { return PlayerBoard; }
            private set { PlayerBoard = value; }
        }

        public string[,] Enemyplayerboard
        {
            get { return Enemyplayerboard;}
            private set { Enemyplayerboard = value;}
        }


        protected internal Player()
        {
            playerlife = 17;
        }

        protected internal abstract void ShipIntoList();

        protected internal abstract void PlaceShips();

        protected internal abstract string Shooting(int x, int y);
    }
}
