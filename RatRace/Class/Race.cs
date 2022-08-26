using System;
using System.Collections.Generic;
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

        public Race(int raceID, List<Rat> rats, Track track)
        {
            raceID = RaceID;
            rats = Rats;
            track = RaceTrack;
        }

        public void ConductRace()
        {
            Console.WriteLine("And the race has started! Look at them go");
            //for hver rotte, flyt x felter. Forsæt indtil alle er i mål
            //Hold styr på rækkefølgen rotterne kommer i mål
        }
        public void GetWinner()
        {
            Console.WriteLine("And the winner of this race is...");
            Console.WriteLine();
        }
        public string GetRaceReport()
        {
            return "";
        }
        private void logRace()
        {
            
        }
    }
}
