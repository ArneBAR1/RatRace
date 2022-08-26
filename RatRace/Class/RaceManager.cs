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
        public List<Player> Players = new List<Player>() { };
        public List<Race> Races = new List<Race>() { };
        public List<Rat> Rats = new List<Rat>() { };
        public List<Track> Tracks = new List<Track>() { };
        public Bookmaker bookmaker = new Bookmaker();

        //Metode til at skabe et race
        public Race CreateRace(int RaceID, List<Rat> rats, Track track)
        {
            RaceID = RNG.Range(1, 99999999);
            return new Race(RaceID, rats, track);
        }
        //Metode til at skabe en bane
        public Track CreateTrack(string name, int tracklength)
        {
            int NumberTrack = RNG.Range(20, 51);
            tracklength = NumberTrack;
            Tracks.Add(new Track(name, tracklength));
            if (NumberTrack >= 20 && NumberTrack < 30)
            {
                name = "Small Track";
            }
            if (NumberTrack >= 30 && NumberTrack < 40)
            {
                name = "Medium Track";
            }
            if (NumberTrack >= 40 && NumberTrack <= 50)
            {
                name = "Large Track";
            }
            return new Track(name, tracklength);
        }
        //Metode til at afholde racet
        public void ConductRace(Race race)
        {
            Console.WriteLine("All the bets have been made and the rats are ready!");
            Console.ReadLine();
            Console.WriteLine("Race will start in 3...");
            Console.ReadLine();
            Console.WriteLine("2...");
            Console.ReadLine();
            Console.WriteLine("1...");
            Console.ReadLine();
            Console.WriteLine("GOOOOO!");
            Console.ReadLine();
            race.ConductRace();
        }
        //Metode til at se racet
        public string ViewRaceRapport(Race race)
        {
            return "";
        }
        //Metode til at skabe en rotte

        public Rat CreateRat(string name)
        {
            int NumberRats = RNG.Range(2, 11);
            string[] names = { "Lui", "Palle", "Humus", "Ost", "Paladin", "Bard", "Kartoffel", "Ratatouille", "Flæskesteg", "BrunSovs", "Bluey", "Rory" };
            for (int i = 0; i <= NumberRats; i++)
            {
                name = names[i];
                Rats.Add(new Rat(name));
            }
            return new Rat(name);
        }
        //Metode til at skabe en spiller
        public Player CreatePlayer()
        {
            string name = "";
            int money = RNG.Range(100, 1000);
            int NumberPlayers = RNG.Range(2, 11);
            string[] names = { "Karl", "Inge", "Lars", "Knud", "Grete", "Annabelle", "Ib", "Søren", "AnneMarie", "Gerda", "Kurt", "Ghost" };
            for (int i = 0; i < NumberPlayers; i++)
            {
                name = names[i];
                Players.Add(new Player(name, money));
                money = RNG.Range(100, 1000);

            }
            return new Player(name, money);
            //Trigger bet placing
        }      
        //Metode til at skabe en spiller
        public Player CreatePlayer(string name, int money)
        {
            Players.Add(new Player(name, money));

            CreatePlayer();
            return new Player(name, money);
            //Trigger bet placing
        }
    }

}
