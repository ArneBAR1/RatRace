using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class Bookmaker
    {
        public List<Bet> bets = new List<Bet>();
        public List<Rat> Rats;
        public List<Player> Players;
        public string whichRat = "";
        public int whichAmount = 0;
        public string whichNPCRat = "";
        public int whichNPCAmount = 0;

        public Bet PlaceBet(Race race, Rat rat, Player player, int money)
        {
            Console.WriteLine("Do you wish to bet on any rats today? \n 1: Yes \n 2: No");
            int ChooseBet = int.Parse(Console.ReadLine());
            switch (ChooseBet)
            {
                case 1:
                    Console.WriteLine("You've placed a bet, (we'll fix it later)");
                    Console.WriteLine("Alright, which rat do you want to bet on?");
                    Console.WriteLine(Rats);
                    whichRat = Console.ReadLine();
                    Console.WriteLine("And how much do you want to bet? Remember, you get 2x back if you win");
                    whichAmount = int.Parse(Console.ReadLine());
                    rat = whichRat;
                    money = whichAmount;
                    bets.Add(new Bet(race, rat, player, money));
                    break;
                case 2:
                    Console.WriteLine("Alright, your choice");
                    break;
            }
            //for (int i = 0; i < Players.Count; i++)
            //{
            //    int ra = RNG.Range(0, Rats.Count);
            //    whichNPCAmount = RNG.Range(0, 100);
            //    Rats[ra].Name = whichNPCRat;
            //    money = whichNPCAmount;
            //    bets.Add(new Bet(whichNPCRat, whichNPCAmount));
            //}
            return new Bet(race, rat, player, money);
        }
        public void PayOutWinnings(Bet bet)
        {
            if (whichRat == ratWinner)
            {
                whichAmount += whichAmount;
            }
            else { whichAmount = 0; }
            
        }
    }
}
