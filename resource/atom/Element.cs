using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universe.resource.atom
{
    public class Element : Resource, iAtom
    {
        private int atomicNumber;

        private string element;

        public Element (string ele, int aN)
        {
            this.atomicNumber = aN;
            this.element = ele;
        }

        public int AtomicNumber
        {
            get { return this.atomicNumber; }
        }

        public string getElement
        {
            get { return this.element; }
        }
    }
}
