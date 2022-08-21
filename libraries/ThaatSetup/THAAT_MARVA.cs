using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_MARVA : _IThaat
    {
        public THAAT_MARVA()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.MARVA, "SA re GA MA' PA DHA NI SA*");
            // re komal and MA’ tivra

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Marva_(thaat)");
        }

        // https://en.wikipedia.org/wiki/Marva_(thaat)
        // Marva	Marva	S r G M' P D N S	Lydian b2	53rd, Gamanashrama	Teevra M, Komal r
        // S r G M' P D N S
        // Western: Lydian b2

    }
}
