using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.RaagasSetup
{
    internal class RAAGA_BHOOPALI : _IRAAGA
    {
        public RAAGA_BHOOPALI()
        {
            this.setup();
        }

        protected override void setup()
        {
            this.raaga = new Raaga(ThaatNames.KALYAN, RaagaNames.BHOOPALI, "SA RE GA PA DHA SA*", "SA* DHA PA GA RE SA");

            this.raaga.set_pakad("GRS.D, SRG, PG, DPG, R S");
            this.raaga.set_pakad("S R G R S D1 S R G");
            this.raaga.set_pakad("S R G R S D1 S R G P G D P G R S");
            this.raaga.set_pakad("G R P G G R S R D1 S");
            this.raaga.set_pakad("G R S D1 S R G R P G D P G R S");
            this.raaga.set_pakad("G R P G S R D1 S");

            this.raaga.set_chalan("S R G R S D1 S R G");
            this.raaga.set_chalan("S R G R S D1 P1");
            this.raaga.set_chalan("P1 D1 S R G R G");
            this.raaga.set_chalan("S R P G");
            this.raaga.set_chalan("G R S R G P");
            this.raaga.set_chalan("G P D P D D S’");
            this.raaga.set_chalan("P G P D P D S’ R’ G’ R’ G’");
            this.raaga.set_chalan("G’ R’ S’ D P G R S");
            
            this.raaga.set_vaadi("G"); // https://en.wikipedia.org/wiki/Vadi_(music)
            this.raaga.set_samavaadi("D"); // https://en.wikipedia.org/wiki/Samavadi

            this.set_raaga_link("https://en.wikipedia.org/wiki/Bhoopali");

            this.set_completed();
        }
    }
}
