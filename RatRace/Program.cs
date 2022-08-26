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
            raceManager.CreateRat();
            raceManager.CreateTrack();
            Console.WriteLine("Do you wish to bet on any rats today? \n 1: Yes \n 2: No");
            int ChooseBet = int.Parse(Console.ReadLine());
            switch (ChooseBet)
            {
                case 1:
                    //PlaceBet();
                    break;
                case 2:
                    Console.WriteLine("Alright, your choice");
                    break;
            }
            //raceManager.ConductRace();
        }
    }
}
