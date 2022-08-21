using libraries.ThaatSetup;

namespace libraries
{
    public class ThaatData
    {
        public Thaat _UNKNOWN = new THAAT_UNKNOWN().get();

        /**
         * https://en.wikipedia.org/wiki/Thaat
         * 
         * A thaat must have seven tones out of the twelve tones [seven natural, four flat (Re, Ga, Dha, Ni), one sharp (Ma)]
         * The tones must be in ascending sequence: Sa Re Ga Ma Pa Dha Ni
         * A thaat cannot contain both the natural and altered versions of a note
         * A thaat, unlike a raga, does not have separate ascending and descending lines
         * A thaat has no emotional quality (which ragas, by definition, do have)
         * Thaats are not sung but the ragas produced from the thaats are sung
         */
        private Thaat _BILAVAL = new THAAT_BILAVAL().get();
        private Thaat _KALYAN = new THAAT_KALYAN().get();
        private Thaat _KHAMAJ = new THAAT_KHAMAJ().get();
        private Thaat _BHAIRAV = new THAAT_BHAIRAV().get();
        private Thaat _KAFI = new THAAT_KAFI().get();
        private Thaat _ASAVARI = new THAAT_ASAVARI().get();
        private Thaat _BHAIRAVI = new THAAT_BHAIRAVI().get();
        private Thaat _POORVI = new THAAT_POORVI().get();
        private Thaat _MARVA = new THAAT_MARVA().get();
        private Thaat _TODI = new THAAT_TODI().get();

        List<Thaat> thaats = new List<Thaat>();

        public ThaatData()
        {
            this.thaats.Add(this._BILAVAL);
            this.thaats.Add(this._KALYAN);
            this.thaats.Add(this._KHAMAJ);
            this.thaats.Add(this._BHAIRAV);
            this.thaats.Add(this._KAFI);
            this.thaats.Add(this._ASAVARI);
            this.thaats.Add(this._BHAIRAVI);
            this.thaats.Add(this._POORVI);
            this.thaats.Add(this._MARVA);
            this.thaats.Add(this._TODI);
        }

        ~ThaatData()
        {

        }

        public List<string> get_names()
        {
            List<string> names = new List<string>() { };
            foreach (Thaat thaat in this.get_thaats())
            {
                names.Add(thaat.THAAT_NAME);
            }

            return names;
        }

        public List<Thaat> get_thaats()
        {
            return thaats;
        }

        internal Thaat get_thaat_by_name(string selected_thaat)
        {
            Thaat thaat = this.thaats.Where(x => x.THAAT_NAME == selected_thaat).FirstOrDefault();
            return thaat;
        }
    }
}
