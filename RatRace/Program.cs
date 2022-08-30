using System;
using System.Collections.Generic;
using RatRace.Class;

namespace RatRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the rat race!");
            Console.WriteLine("Bet on rats and earn rewards! If you dare");
            RaceManager raceManager = new RaceManager();
            Console.WriteLine("But first, what is your name?");
            string PlayerName = Console.ReadLine();
            int money = RNG.Range(100, 1000);
            raceManager.CreatePlayer(PlayerName, money);
            raceManager.CreatePlayer();
            Console.WriteLine("Great! Welcome " + PlayerName);
            //Start over from here?
            while (raceManager.Players[0].Money > 0)
            {
                Console.WriteLine("Your balance: " + raceManager.Players[0].Money);
                Console.WriteLine("Here's the line up for the next race");
                Console.WriteLine("The runners are:");

                int NumberRats = RNG.Range(2, 11);
                string[] names = { "Lui", "Palle", "Humus", "Ost", "Paladin", "Bard", "Kartoffel", "Ratatouille", "Flæskesteg", "BrunSovs", "Bluey", "Rory" };
                for (int i = 0; i <= NumberRats; i++)
                {
                    string RatName = names[i];
                    raceManager.CreateRat(RatName);

                    Console.WriteLine(RatName);
                }
                string TrackName = "";
                int NumberTrack = RNG.Range(20, 51);
                int tracklength = NumberTrack;
                if (NumberTrack >= 20 && NumberTrack < 30)
                {
                    TrackName = "Small Track";
                }
                if (NumberTrack >= 30 && NumberTrack < 40)
                {
                    TrackName = "Medium Track";
                }
                if (NumberTrack >= 40 && NumberTrack <= 50)
                {
                    TrackName = "Large Track";
                }
            
                raceManager.CreateTrack(TrackName, tracklength);

                raceManager.CreateRace(raceManager.RaceID, raceManager.Rats, raceManager.Tracks[0]);
                Console.WriteLine("And the track is " + TrackName);
                Console.ReadLine();
                Console.Clear();
                string ratname = "";
                Rat rat = null;
                Console.WriteLine("Do you wish to bet on any rats today? \n 1: Yes \n 2: No");
                int ChooseBet = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (ChooseBet)
                {
                    case 1:
                        Console.WriteLine("Alright, which rat do you want to bet on?");
                        for (int i = 0; i < raceManager.Rats.Count; i++)
                        {
                            Console.WriteLine(raceManager.Rats[i].Name);
                        }
                        ratname = Console.ReadLine();
                        for (int j = 0; j < raceManager.Rats.Count; j++)
                        {
                            if (ratname == raceManager.Rats[j].Name)
                            {
                                rat = raceManager.Rats[j];
                                Console.WriteLine("You've chosen " + ratname);
                            }
                        }
                        Console.WriteLine("Your balance: " + raceManager.Players[0].Money);
                        Console.WriteLine("And how much do you want to bet? Remember, you get 2x back if you win");
                        money = int.Parse(Console.ReadLine());
                        while (money > raceManager.Players[0].Money)
                        {
                            Console.WriteLine("That's more than you have! That won't do, try again");
                            money = int.Parse(Console.ReadLine());
                        }
                        raceManager.Players[0].Money -= money;
                        raceManager.bookmaker.PlaceBet(raceManager.Races[0], rat, raceManager.Players[0], money);
                        break;
                    case 2:
                        Console.WriteLine("Alright, your choice");
                        break;

                }
                Console.Clear();
                raceManager.ConductRace(raceManager.Races[0]);
                Console.WriteLine("The race is now over and we have our winner! Ready to find out who it was?");
                Console.ReadLine();
                raceManager.Races[0].GetWinner();
                raceManager.bookmaker.Bets[0].PayWinnings();
                Console.WriteLine("your balance after the race: " + raceManager.Players[0].Money);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Do you whis to see the report of the race? \n 1: Yes \n 2: No");
                int chooseRapport = int.Parse(Console.ReadLine());
                switch (chooseRapport)
                {
                    case 1:
                        raceManager.ViewRaceRapport(raceManager.Races[0]);
                        break;
                    case 2:
                        Console.WriteLine("No problem");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
