using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_BHAIRAV : _IThaat
    {
        public THAAT_BHAIRAV()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.BHAIRAV, "SA re GA MA PA dha NI SA*");
            // re and dha komal

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Bhairav_(thaat)");
        }

        // https://en.wikipedia.org/wiki/Bhairav_(thaat)
        // Bhairav	Bhairav	S r G M P d N S	Double Harmonic	15th, Mayamalavagowla	Komal r, Komal d
        // S r G M P d N S
        // Western: Double Harmonic

    }
}
