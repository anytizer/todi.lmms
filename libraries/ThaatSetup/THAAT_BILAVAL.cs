using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_BILAVAL : _IThaat
    {
        public THAAT_BILAVAL()
        {
            this.setup();
        }


        // https://en.wikipedia.org/wiki/Bilaval
        // https://en.wikipedia.org/wiki/Bilaval_(thaat)
        // Bilaval	Bilaval	S R G M P D N S	Ionian	29th, Sankarabharanam	All Shuddha Svaras

        // Arohi: Sa, Re, Ga, ma, Pa, Dha, Ni, Sa'
        // Avarahi: Sa' Ni Dha, Pa, ma Ga, Ma, Re Sa
        // S R G M P D N S
        // Western: Ionian

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.BILAVAL, "SA RE GA MA PA DHA NI SA*");
            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Bilaval_(thaat)");
            // All pure notes
        }

    }
}
