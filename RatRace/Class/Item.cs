using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace.Class
{
    class Item
    {
        public void Equip(Rat rat)
        {
            rat.item = this;
            rat.speed += 2;
        }

        public virtual string Action() { return null; }

        public void Unequip(Rat rat)
        {
            rat.item = null;
            rat.speed -= 2;
        }
    }
}
