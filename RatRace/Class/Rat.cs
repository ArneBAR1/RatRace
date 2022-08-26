using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class Rat
    {
        public string Name;
        private int position;
        public int Position = 0;

        public Rat(string name)
        {
            name = Name;
        }

        public void ResetRat()
        {
            //Go back to start
            if (Position != 0)
            {
                Position = 0;
            }
        }
        public int MoveRat()
        {
            
            //Move x amount of spaces based on a die
            int SpacesMoved = RNG.Range(1, 7);
            Position += SpacesMoved;

            return Position;
        }
    }
}
