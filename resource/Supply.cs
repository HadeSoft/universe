using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universe.resource
{
    public class Supply
    {
        private int volume;

        private Resource resource;

        public Supply (Resource res, int vol)
        {
            this.resource = res;
            this.volume = vol;
        }

        public int getVolume
        {
            get { return this.volume; }
        }

        public Resource getResource
        {
            get { return this.resource; }
        }

        public void increaseVolume (int quant)
        {
            this.volume += quant;
        }
    }
}
