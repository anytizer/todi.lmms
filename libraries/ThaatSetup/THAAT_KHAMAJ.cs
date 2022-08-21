using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_KHAMAJ : _IThaat
    {
        public THAAT_KHAMAJ()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.KHAMAJ, "SA RE GA MA PA DHA ni SA*");
            // ni komal

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Khamaj_(thaat)");
        }


        // https://en.wikipedia.org/wiki/Khamaj_(thaat)
        // Khamaj	Khamaj	S R G M P D n S	Mixolydian	28th, Harikambhoji	Komal n

        // S R G M P D n S
        // Western: Mixolydian

        // https://www.parrikar.org/hindustani/khamaj/
        /**
         * Khamaj
Rageshree | Rageshwari?
Jhinjhoti
Desh
Sorath
Manj Khamaj
Tilang
Gara
Tilak Kamod
Jaijaiwanti
Khambavati
Kalavati
Khokar
Khamboji
Champak
Deepak
Gavati
Janasammohini
         */

    }
}
