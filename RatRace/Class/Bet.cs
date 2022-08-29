using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class Bet
    {
        private int Money;
        private Player Player;
        private Race Race;
        private Rat Rat;

        //Constructor
        public Bet(Race race, Rat rat, Player player, int money)
        {
            Race = race;
            Rat = rat;
            Player = player;
            Money = money;
        }

        public void PayWinnings()
        {

        }
    }
}
