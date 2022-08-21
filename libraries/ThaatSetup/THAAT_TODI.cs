using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_TODI : _IThaat
    {
        public THAAT_TODI()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.TODI, "SA re ga MA' PA dha NI SA*");
            // re, ga and dha komal and MA’ tivra

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Todi_(thaat)");
        }


        // https://en.wikipedia.org/wiki/Todi_(thaat)
        // Todi	Miyan ki Todi	S r g M' P d N S	-	45th, Shubhapantuvarali	Teevra M, Komal r, Komal g, Komal d
        // S r g M' P d N S
        // Western: -
    }
}
