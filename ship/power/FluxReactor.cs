using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using universe.resource;
using universe.resource.atom;

namespace universe.ship.power
{
    public class FluxReactor : PowerSource
    {
        private int hydrogenLevel;
        private int fluxLevel;
        private int fluxCap = 1000;
        private int temperture;
        private double spin;
        private int maxSpin;


        public FluxReactor ()
        {
            this.spin = 0.01;
        }

        public override void Input (Supply supply)
        {
            Type t = supply.GetType();

            if (t.Equals(typeof(Element)))
            {
                Element element = (Element)supply.getResource;
                if (element.getElement == "H")
                {
                    this.hydrogenLevel += supply.getVolume;
                }
            }
        }

        public override void Step ()
        {
            this.spin = this.spin * (2 - this.spin);
            heatUpReactor();
            if (this.temperture > 100000000) powerReactor();
        }

        public override void Power (int mW)
        {
            this.megaWatts = mW;
        }

        public int FlushFlux (int flow)
        {
            if (this.fluxLevel < flow)
            {
                flow = this.fluxLevel;
                this.fluxLevel = 0;
            }
            else this.fluxLevel -= flow;
            return flow;
        }

        private void heatUpReactor ()
        {
            int deltaTemp = this.megaWatts * 1400;
            this.temperture += deltaTemp;
            this.megaWatts = 0;
        }

        private void powerReactor ()
        {
            int hUsage = this.hydrogenLevel / 2;

            if (hUsage > 50) hUsage = 50;

            this.megaWatts += (int)Math.Round(hUsage * this.spin) * 40;
            this.fluxCap += (int)Math.Round(hUsage * (1.0 - this.spin));
            this.hydrogenLevel -= hUsage;
            this.temperture -= hUsage * 2500;
        }
    }
}
