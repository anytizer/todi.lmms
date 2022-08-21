using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_BHAIRAVI : _IThaat
    {
        public THAAT_BHAIRAVI()
        {
            this.setup(); 
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.BHAIRAVI, "SA re ga MA PA dha ni SA*");
            // // re, ga, dha and ni komal

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Bhairavi_(thaat)");
        }

        // https://en.wikipedia.org/wiki/Bhairavi_(thaat)
        // Bhairavi	Bhairavi	S r g M P d n S	Phrygian	8th, Hanumatodi	Komal n, Komal g, Komal d, Komal r
        // S r g M P d n S
        // Western: Phrygian
    }
}
