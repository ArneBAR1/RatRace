using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class Race
    {
        public int RaceID;
        public List<Rat> Rats;
        public Track RaceTrack;
        private Rat Winner;
        public Rat winner
        {
            get { return Winner; }
            set { Winner = value; }
        }
        private string log;
        //public List<Rat> Order = new List<Rat>();

       public Race(int raceID, List<Rat> rats, Track track)
        {
            RaceID = raceID;
            Rats = rats;
            RaceTrack = track;
        }

        public void ConductRace()
        {
            Console.WriteLine("And the race has started! Look at them go");
            //for hver rotte, flyt x felter

            bool winnerFound =  false;
            int crntTurn = 1;
            while (!winnerFound)
            {
                foreach (Rat item in Rats)
                {
                    item.MoveRat();
                    Console.WriteLine("Turn " + crntTurn+": " + item.Name+" has moved " + item.SpacesMoved + " spaces");
                    log += ("Turn " + crntTurn + ": " + item.Name + " has moved " + item.SpacesMoved + " spaces") + "\n";
                }
                foreach (Rat item in Rats)
                {
                    if (item.Position>= RaceTrack.TrackLength)
                    {
                        winnerFound  = true;
                        Winner = item;
                    }
                }

                crntTurn++;
            }
            
        }
        public void GetWinner()
        {
            Console.Clear();
            Console.WriteLine("And the winner of this race is...");
            Console.WriteLine(Winner.Name);
            //Console.WriteLine(Order[0]);
            Console.WriteLine("Whoever betted on this rat, sure is lucky today");
        }
        public string GetRaceReport()
        {
            Console.WriteLine("What a wonderful race!");
            string Rapport = log;
            return Rapport;
        }
        private void logRace()
        {
            string directory = Directory.GetCurrentDirectory();
            string path = System.IO.Path.Combine(directory + "\\RaceLog.txt");

            File.WriteAllText("RaceLog.txt", "Inge left the server");
        }
    }
}

