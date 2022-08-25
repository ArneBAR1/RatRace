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

        public void ConductRace()
        {
            Console.WriteLine("And the race is starting! Look at them go");
            //MoveRat();
        }
        public void GetWinner()
        {
            Console.WriteLine("And the winner of this race is...");
            Console.WriteLine();
        }
        public string GetRaceReport()
        {
            
        }
        private void logRace()
        {
            
        }
    }
}
