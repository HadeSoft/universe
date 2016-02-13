using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using universe.resource;

namespace universe.ship
{
    public abstract class aActiveStructure
    {
        protected int megaWatts;
        protected Supply supply;

        public abstract void Step();

        public virtual void Power (int megaWatts)
        {
            this.megaWatts = megaWatts;
        }

        public virtual void Input (Supply sup)
        {
            if (this.supply.getResource.Equals(sup.getResource))
            {
                this.supply.increaseVolume(sup.getVolume);
            }
            else
            {

            }
        }
    }
}
