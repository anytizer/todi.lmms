using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    internal class THAAT_KALYAN: _IThaat
    {
        public THAAT_KALYAN()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.thaat = new Thaat();
            this.thaat.set_thaat(ThaatNames.KALYAN, "SA RE GA MA' PA DHA NI SA*");
            // MA’ tivra

            this.thaat.set_thaat_link("https://en.wikipedia.org/wiki/Kalyan_(thaat)");
        }


        // https://en.wikipedia.org/wiki/Kalyan_(thaat)
        // Kalyan	Yaman (earlier known as Kalyan)	S R G M' P D N S	Lydian	65th, (Mecha) Kalyani	Teevra M

        // S R G M' P D N S
        // Western: Lydian
        // bhupali => "SA RE GA PA DHA SA*"
        // Yaman, Bhupali, Hindol, Kedar, Shuddha Kalyan, Shyam Kalyan,
        // Yaman Kalyan, Khem Kalyan, Savani Kalyan Chhayanat,
        // Hameer, Gaud Sarang, Kamod, Maru Bihag, Nand
    }
}
