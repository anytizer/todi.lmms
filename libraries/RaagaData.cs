using libraries.RaagasSetup;
using System.Collections.Generic;

namespace libraries
{
    public class RaagaData
    {
        /**
        // https://www.sharda.org/raga-taal/
        private Raaga AABHOGI; // = new Raaga(ThaatData.KAFI, "SA RE ga MA DHA SA*", "SA* ni DHA MA ga RE SA");
        private Raaga ABHOGI_KANHRA; // = new Raaga(ThaatData.KAFI, "S R g M D S.", "S. D M g R S, .D S");
        private Raaga ADANA; // = new Raaga(ThaatData.ASAVARI, "S R M P, d N S.", "S. d n P M P, g M R S");
        private Raaga AHIR_BHAIRAV; // = new Raaga(ThaatData.BHAIRAV, "S r G M, P D n S.", "S. n D P, M G r S");
        private Raaga ALAHIYA_BILAVAL; // = new Raaga(ThaatData.BILAVAL, "SR GMGR, GP,D N S.", "S. NDP, DnDP, MG MRS");
        private Raaga ASAVARI; // = new Raaga(ThaatData.ASAVARI, "S R M P d S.", "S. n d P M g R S");
        private Raaga BAGESHRI; // = new Raaga(ThaatData.KAFI, "S g M D n S.", "S. n D M g R S");
        private Raaga BAHAR; // = new Raaga(ThaatData.KAFI, ".n S, g M P, g M, n D N S.", "S. n D n P, M P g M R S");
        private Raaga BASANT; // = new Raaga(ThaatData.POORVI, "S G M’ d r. S", "r. N d P, M’ G, M’ d M’ G , r S");
        private Raaga BHAIRAV; // = new Raaga(ThaatData.BHAIRAV, "S r G M P d N S.", "S. N d P MG r S");
        private Raaga BHAIRAVI; // = new Raaga(ThaatData.BHAIRAV, "S r g M P d n S.", "S. n d P M g r S");
        private Raaga BHIMPALASI; // = new Raaga(ThaatData.KAFI, ".n S g M P n S.", "S. n D P M g R S");
        private Raaga BIHAG; // = new Raaga(ThaatData.BILAVAL, ".N S G M P N S.", "S. N D P M G R S");
        private Raaga BIHAGRA; // = new Raaga(ThaatData.BILAVAL, ".N S G, G M P D n D P, N S.", "S. N D, n D P, G M G R S");
        */

        private Raaga _AABHOGI = new RAAGA_AABHOGI().get();
        private Raaga _ABHOGI_KANHRA = new RAAGA_ABHOGI_KANHRA().get();
        private Raaga _ADANA = new RAAGA_ADANA().get();
        private Raaga _AHIR_BHAIRAV = new RAAGA_AHIR_BHAIRAV().get();
        private Raaga _ALAHIYA_BILAVAL = new RAAGA_ALAHIYA_BILAVAL().get();
        private Raaga _ASAVARI = new RAAGA_ASAVARI().get();
        private Raaga _BAGESHRI = new RAAGA_BAGESHRI().get();
        private Raaga _BAHAR = new RAAGA_BAHAR().get();
        private Raaga _BASANT = new RAAGA_BASANT().get();
        private Raaga _BHAIRAV = new RAAGA_BHAIRAV().get();
        private Raaga _BHAIRAVI = new RAAGA_BHAIRAVI().get();
        private Raaga _BHIMPALASI = new RAAGA_BHIMPALASI().get();
        private Raaga _BHOOPALI = new RAAGA_BHOOPALI().get();
        private Raaga _BIHAG = new RAAGA_BIHAG().get();
        private Raaga _BIHAGRA = new RAAGA_BIHAGRA().get();
        private Raaga _BILASKHANI_TODI = new RAAGA_BILASKHANI_TODI().get();
        private Raaga _BILAVAL = new RAAGA_BILAVAL().get();
        private Raaga _CHANDRAKAUNS = new RAAGA_CHANDRAKAUNS().get();
        private Raaga _CHAYANAT = new RAAGA_CHAYANAT().get();
        private Raaga _DARBARI_KANHDRA = new RAAGA_DARBARI_KANHDRA().get();
        private Raaga _DES = new RAAGA_DES().get();
        private Raaga _DESHKAR = new RAAGA_DESHKAR().get();
        private Raaga _DESI = new RAAGA_DESI().get();
        private Raaga _DHANASHRI = new RAAGA_DHANASHRI().get();
        private Raaga _DURGA = new RAAGA_DURGA().get();
        private Raaga _GAUR_MALHAR = new RAAGA_GAUR_MALHAR().get();
        private Raaga _GAUR_SARANG = new RAAGA_GAUR_SARANG().get();
        private Raaga _GURJARI_TODI = new RAAGA_GURJARI_TODI().get();
        private Raaga _HAMIR = new RAAGA_HAMIR().get();
        private Raaga _HANSADHVANI = new RAAGA_HANSADHVANI().get();
        private Raaga _HINDOL = new RAAGA_HINDOL().get();
        private Raaga _JAI_JAI_VANTI = new RAAGA_JAI_JAI_VANTI().get();
        private Raaga _JAUNPURI = new RAAGA_JAUNPURI().get();
        private Raaga _JHINJHOTI = new RAAGA_JHINJHOTI().get();
        private Raaga _JOGIYA = new RAAGA_JOGIYA().get();
        private Raaga _KAFI = new RAAGA_KAFI().get();
        private Raaga _KALAVATI = new RAAGA_KALAVATI().get();
        private Raaga _KAMOD = new RAAGA_KAMOD().get();
        private Raaga _KAUSI_KANHDA = new RAAGA_KAUSI_KANHDA().get();
        private Raaga _KEDAR = new RAAGA_KEDAR().get();
        private Raaga _KHAMAJ = new RAAGA_KHAMAJ().get();
        private Raaga _LALIT = new RAAGA_LALIT().get();
        private Raaga _MADHUVANTI = new RAAGA_MADHUVANTI().get();
        private Raaga _MADHYAMAD_SARANG = new RAAGA_MADHYAMAD_SARANG().get();
        private Raaga _MALGUNJI = new RAAGA_MALGUNJI().get();
        private Raaga _MALKAUNS = new RAAGA_MALKAUNS().get();
        private Raaga _MALUHA_KEDAR = new RAAGA_MALUHA_KEDAR().get();
        private Raaga _MAND = new RAAGA_MAND().get();
        private Raaga _MARU_BIHAG = new RAAGA_MARU_BIHAG().get();
        private Raaga _MARVA = new RAAGA_MARVA().get();
        private Raaga _MIYA_KI_SARANG = new RAAGA_MIYA_KI_SARANG().get();
        private Raaga _MIYA_MALHAR = new RAAGA_MIYA_MALHAR().get();
        private Raaga _MULTANI = new RAAGA_MULTANI().get();
        private Raaga _NAND_ANANDI = new RAAGA_NAND_ANANDI().get();
        private Raaga _PAHADI = new RAAGA_PAHADI().get();
        private Raaga _PARAJ = new RAAGA_PARAJ().get();
        private Raaga _PATDEEP = new RAAGA_PATDEEP().get();
        private Raaga _PILOO = new RAAGA_PILOO().get();
        private Raaga _POORIYA = new RAAGA_POORIYA().get();
        private Raaga _POORIYA_DHANASHRI = new RAAGA_POORIYA_DHANASHRI().get();
        private Raaga _POORVI = new RAAGA_POORVI().get();
        private Raaga _RAGESHWARI = new RAAGA_RAGESHWARI().get();
        private Raaga _RAMDASI_MALHAR = new RAAGA_RAMDASI_MALHAR().get();
        private Raaga _RAMKALI = new RAAGA_RAMKALI().get();
        private Raaga _RASRANJANI = new RAAGA_RASRANJANI().get();
        private Raaga _SARASWATI = new RAAGA_SARASWATI().get();
        private Raaga _SHANKARA = new RAAGA_SHANKARA().get();
        private Raaga _SHIVRANJANI = new RAAGA_SHIVRANJANI().get();
        private Raaga _SHRI = new RAAGA_SHRI().get();
        private Raaga _SHUDDH_KALYAN = new RAAGA_SHUDDH_KALYAN().get();
        private Raaga _SHUDDH_SARANG = new RAAGA_SHUDDH_SARANG().get();
        private Raaga _SHYAM_KALYAN = new RAAGA_SHYAM_KALYAN().get();
        private Raaga _SINDHU_BHAIRAVI = new RAAGA_SINDHU_BHAIRAVI().get();
        private Raaga _SOHNI = new RAAGA_SOHNI().get();
        private Raaga _SUGHRAI = new RAAGA_SUGHRAI().get();
        private Raaga _TILAK_KAMOD = new RAAGA_TILAK_KAMOD().get();
        private Raaga _TILANG = new RAAGA_TILANG().get();
        private Raaga _TODI = new RAAGA_TODI().get();
        private Raaga _VIBHAS = new RAAGA_VIBHAS().get();
        private Raaga _VRIDAVANI_SARANG = new RAAGA_VRIDAVANI_SARANG().get();
        private Raaga _YAMAN_KALYAN = new RAAGA_YAMAN_KALYAN().get();
        private Raaga _YAMANI_BILAVAL = new RAAGA_YAMANI_BILAVAL().get();

        private List<Raaga> ALL_RAAGAS = new List<Raaga>();

        public RaagaData()
        {
            this.ALL_RAAGAS.Add(this._AABHOGI);
            this.ALL_RAAGAS.Add(this._ABHOGI_KANHRA);
            this.ALL_RAAGAS.Add(this._ADANA);
            this.ALL_RAAGAS.Add(this._AHIR_BHAIRAV);
            this.ALL_RAAGAS.Add(this._ALAHIYA_BILAVAL);
            this.ALL_RAAGAS.Add(this._ASAVARI);
            this.ALL_RAAGAS.Add(this._BAGESHRI);
            this.ALL_RAAGAS.Add(this._BAHAR);
            this.ALL_RAAGAS.Add(this._BASANT);
            this.ALL_RAAGAS.Add(this._BHAIRAV);
            this.ALL_RAAGAS.Add(this._BHAIRAVI);
            this.ALL_RAAGAS.Add(this._BHIMPALASI);
            this.ALL_RAAGAS.Add(this._BHOOPALI);
            this.ALL_RAAGAS.Add(this._BIHAG);
            this.ALL_RAAGAS.Add(this._BIHAGRA);
            this.ALL_RAAGAS.Add(this._BILASKHANI_TODI);
            this.ALL_RAAGAS.Add(this._BILAVAL);
            this.ALL_RAAGAS.Add(this._CHANDRAKAUNS);
            this.ALL_RAAGAS.Add(this._CHAYANAT);
            this.ALL_RAAGAS.Add(this._DARBARI_KANHDRA);
            this.ALL_RAAGAS.Add(this._DES);
            this.ALL_RAAGAS.Add(this._DESHKAR);
            this.ALL_RAAGAS.Add(this._DESI);
            this.ALL_RAAGAS.Add(this._DHANASHRI);
            this.ALL_RAAGAS.Add(this._DURGA);
            this.ALL_RAAGAS.Add(this._GAUR_MALHAR);
            this.ALL_RAAGAS.Add(this._GAUR_SARANG);
            this.ALL_RAAGAS.Add(this._GURJARI_TODI);
            this.ALL_RAAGAS.Add(this._HAMIR);
            this.ALL_RAAGAS.Add(this._HANSADHVANI);
            this.ALL_RAAGAS.Add(this._HINDOL);
            this.ALL_RAAGAS.Add(this._JAI_JAI_VANTI);
            this.ALL_RAAGAS.Add(this._JAUNPURI);
            this.ALL_RAAGAS.Add(this._JHINJHOTI);
            this.ALL_RAAGAS.Add(this._JOGIYA);
            this.ALL_RAAGAS.Add(this._KAFI);
            this.ALL_RAAGAS.Add(this._KALAVATI);
            this.ALL_RAAGAS.Add(this._KAMOD);
            this.ALL_RAAGAS.Add(this._KAUSI_KANHDA);
            this.ALL_RAAGAS.Add(this._KEDAR);
            this.ALL_RAAGAS.Add(this._KHAMAJ);
            this.ALL_RAAGAS.Add(this._LALIT);
            this.ALL_RAAGAS.Add(this._MADHUVANTI);
            this.ALL_RAAGAS.Add(this._MADHYAMAD_SARANG);
            this.ALL_RAAGAS.Add(this._MALGUNJI);
            this.ALL_RAAGAS.Add(this._MALKAUNS);
            this.ALL_RAAGAS.Add(this._MALUHA_KEDAR);
            this.ALL_RAAGAS.Add(this._MAND);
            this.ALL_RAAGAS.Add(this._MARU_BIHAG);
            this.ALL_RAAGAS.Add(this._MARVA);
            this.ALL_RAAGAS.Add(this._MIYA_KI_SARANG);
            this.ALL_RAAGAS.Add(this._MIYA_MALHAR);
            this.ALL_RAAGAS.Add(this._MULTANI);
            this.ALL_RAAGAS.Add(this._NAND_ANANDI);
            this.ALL_RAAGAS.Add(this._PAHADI);
            this.ALL_RAAGAS.Add(this._PARAJ);
            this.ALL_RAAGAS.Add(this._PATDEEP);
            this.ALL_RAAGAS.Add(this._PILOO);
            this.ALL_RAAGAS.Add(this._POORIYA);
            this.ALL_RAAGAS.Add(this._POORIYA_DHANASHRI);
            this.ALL_RAAGAS.Add(this._POORVI);
            this.ALL_RAAGAS.Add(this._RAGESHWARI);
            this.ALL_RAAGAS.Add(this._RAMDASI_MALHAR);
            this.ALL_RAAGAS.Add(this._RAMKALI);
            this.ALL_RAAGAS.Add(this._RASRANJANI);
            this.ALL_RAAGAS.Add(this._SARASWATI);
            this.ALL_RAAGAS.Add(this._SHANKARA);
            this.ALL_RAAGAS.Add(this._SHIVRANJANI);
            this.ALL_RAAGAS.Add(this._SHRI);
            this.ALL_RAAGAS.Add(this._SHUDDH_KALYAN);
            this.ALL_RAAGAS.Add(this._SHUDDH_SARANG);
            this.ALL_RAAGAS.Add(this._SHYAM_KALYAN);
            this.ALL_RAAGAS.Add(this._SINDHU_BHAIRAVI);
            this.ALL_RAAGAS.Add(this._SOHNI);
            this.ALL_RAAGAS.Add(this._SUGHRAI);
            this.ALL_RAAGAS.Add(this._TILAK_KAMOD);
            this.ALL_RAAGAS.Add(this._TILANG);
            this.ALL_RAAGAS.Add(this._TODI);
            this.ALL_RAAGAS.Add(this._VIBHAS);
            this.ALL_RAAGAS.Add(this._VRIDAVANI_SARANG);
            this.ALL_RAAGAS.Add(this._YAMAN_KALYAN);
            this.ALL_RAAGAS.Add(this._YAMANI_BILAVAL);
            
            // There are many ragas that don't fall in Thaat system.
            // 1. Kirvani
            // 2. Nat Bhairav
            // 3. Charukeshi
            // 4. Madhuvanti
            // 5. Ahir Bhairav
        }

        public List<Raaga> get_raagas(string selected_thaat)
        {
            List<Raaga> raagas = this.ALL_RAAGAS.Where(x => x.THAAT_NAME == selected_thaat).ToList();
            return raagas;
        }

        public Raaga get_raag_by_name(string selected_raaga)
        {
            Raaga desired = this.ALL_RAAGAS.Where(x => x.RAAGA_NAME == selected_raaga).First();
            return desired;
        }

        public Raaga get_specific_raaga(string raag_name_selected)
        {
            Raaga raaga = this.ALL_RAAGAS.Where(x => x.RAAGA_NAME == raag_name_selected).FirstOrDefault();
            //.OrderBy(y => Guid.NewGuid()).FirstOrDefault();
            return raaga;
        }
    }
}
