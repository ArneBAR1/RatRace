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
        public int RaceID = 1;
        public List<Rat> Rats;
        public Track RaceTrack;
        private Rat Winner;
        private string log;
        public List<Rat> Order = new List<Rat>;

        public Race(int raceID, List<Rat> rats, Track track)
        {
            raceID = RaceID;
            rats = Rats;
            track = RaceTrack;
        }

        public void ConductRace()
        {
            Console.WriteLine("And the race has started! Look at them go");
            //for hver rotte, flyt x felter
            while (Winner.Position < RaceTrack.TrackLength)
            {
                for (int i = 0; i < Rats.Count; i++)
                {
                    Winner.MoveRat();
                    if (Winner.Position >= RaceTrack.TrackLength)
                    {
                        Order.Add(new Rat(name));
                    }
                }
            }
            //Hold styr på rækkefølgen rotterne kommer i mål
        }
        public void GetWinner()
        {
            Console.WriteLine("And the winner of this race is...");
            Console.WriteLine(Order[0]);
            Console.WriteLine("Whoever betted on this rat, sure is lucky today");
        }
        public string GetRaceReport()
        {
            int place = 1;
            Console.WriteLine("What a wonderful race! Let's see the full list of when the rats passed the finish line");
            for (int i = 0; i < Order.Count; i++)
            {
                Console.WriteLine("\nIn" + place + " place" + Order[i]);
                place++;
            }
            return "";
        }
        private void logRace()
        {
            string directory = Directory.GetCurrentDirectory();
            string path = System.IO.Path.Combine(directory + "\\RaceLog.txt");

            File.WriteAllText("RaceLog.txt", "Inge left the server");
        }
    }
}
