using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_ASAVARI : _IThaat
    {
        public THAAT_ASAVARI()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.ASAVARI, "SA RE ga MA PA dha ni SA*");
            // ga, dha and ni komal

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Asavari_(thaat)");
        }

        // https://en.wikipedia.org/wiki/Asavari_(thaat)
        // Asavari	Asavari	S R g M P d n S	Aeolian	20th, Natabhairavi	Komal n, Komal g, Komal d
        // S R g M P d n S
        // Western: Aeolian
    }
}