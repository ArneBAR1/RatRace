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
            Console.WriteLine("But first, what is your name?")
            string PlayerName = Console.ReadLine();
            RaceManager raceManager = new RaceManager;
        }
    }
}
