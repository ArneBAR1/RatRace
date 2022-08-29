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
            Console.WriteLine("Your balance: " + money);
            Console.WriteLine("Here's the line up for the next race");
            int RaceID = 0;
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
            raceManager.CreateRace(RaceID, names, TrackName);
            raceManager.CreateTrack(TrackName, tracklength);
            raceManager.CreateRace(RaceID, Rats, TrackName);
            Console.WriteLine("And the track is " + TrackName);
            raceManager.bookmaker.PlaceBet(RaceID, PlayerName, money);
            raceManager.ConductRace(RaceID);
        }
    }
}
