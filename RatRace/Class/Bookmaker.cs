using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class Bookmaker:RaceManager
    {
        public List<Bet> bets = new List<Bet>();
        public Bet PlaceBet(Race race, Rat rat, Player player, int money )
        {
            Console.WriteLine("Alright, which rat do you want to bet on?");
            Console.WriteLine(Rats);
            int whichRat = int.Parse(Console.ReadLine());
            Console.WriteLine("And how much do you want to bet? Remember, you get double back if you win");
            int whichAmount = int.Parse(Console.ReadLine());
            return new Bet(race, rat, player, money);
        }
        public void PayOutWinnings(Bet bet)
        {
            
        }
    }
}
