using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_POORVI : _IThaat
    {
        public THAAT_POORVI()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.POORVI, "SA re GA MA' PA dha NI SA*");
            // re and dha komal and MA’ tivra

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Poorvi_(thaat)");
        }

        // https://en.wikipedia.org/wiki/Poorvi_(thaat)
        // Poorvi	Poorvi	S r G M' P d N S	-	51st, Kamavardhani	Teevra M, Komal r, Komal d
        // S r G M' P d N S
        // Western: -
    }
}
