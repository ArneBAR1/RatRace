using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class RaceManager
    {
        //Contructor
        public RaceManager()
        {
            Track MiniLane = new Track();
            Track SmallLine = new Track();
            Track MediumLane = new Track();
            Track LargeLane = new Track();
            Track HugeLane = new Track();

            List<Track> Tracks = new List<Track>() { MiniLane, SmallLine, MediumLane, LargeLane, HugeLane };
            List<Player> Players = new List<Player>() { };
            List<Race> Races = new List<Race>() { };
            List<Rat> Rats = new List<Rat>() { };
        }
        //Metode til at skabe et race
        public void CreateRace(int RaceID, List<Rat> rats, Track track)
        {
            
        }
        //Metode til at skabe en bane
        public void CreateTrack(string name, int tracklength)
        {
            
        }
        //Metode til at afholde racet
        public void ConductRace(Race race)
        {
            Race Race = new Race();    
        }
        //Metode til at se racet
        public string ViewRaceRapport(Race race)
        {

        }
        //Metode til at skabe en rotte
        public string CreateRat()
        {
            
        }
        //Metode til at skabe en spiller
        public void CreatePlayer(Player player)
        {
            string Name = "wdwd";
            int Money = RNG.Range(100, 1000);
        }
    }

}
