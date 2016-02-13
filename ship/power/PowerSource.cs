using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universe.ship.power
{
    public class PowerSource : aActiveStructure
    {
        public virtual void Step()
        {

        }

        public override void Power(int megaWatts)
        {
            int flow = 0;
            if (this.megaWatts < flow)
            {
                flow = this.megaWatts;
                this.megaWatts = 0;
            }
            else this.megaWatts -= flow;
            //return flow;
        }
    }
}
