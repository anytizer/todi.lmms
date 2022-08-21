using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_KAFI : _IThaat
    {
        public THAAT_KAFI()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.KAFI, "SA RE ga MA PA DHA ni SA*");
            // ga and ni komal

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Kafi_(thaat)");
        }
    }
}
