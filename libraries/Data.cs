namespace libraries
{
    public class Data
    {
        private List<int> commas = new List<int>() { };
        private List<int> hops = new List<int>() { };
        private List<bool> if_special_notes = new List<bool>() { };
        private List<string> special_notes = new List<string>() { };

        private Random r = new Random();

        public Data()
        {
            //this.r = new Random(new System.DateTime().Millisecond);

            // 60% chance creator
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            commas.Add((int)Commas.FullLength);
            
            // 30% chance creator
            commas.Add((int)Commas.Half);
            commas.Add((int)Commas.Half);

            // 10% chance creator
            commas.Add((int)Commas.Quarter);
            commas.Add((int)Commas.Quarter);


            hops.Add(-2); // downwards / rare
            hops.Add(-2); // downwards / rare
            hops.Add(-1); // downwards / back
            hops.Add(-1); // downwards / back
            hops.Add(+0); // forward: Continue
            hops.Add(+1); // upwards
            hops.Add(+1); // upwards
            hops.Add(+1); // upwards
            hops.Add(+2); // upwards: skipping a note

            // decide if to pick a special note
            this.if_special_notes.Add(false);
            this.if_special_notes.Add(false);
            this.if_special_notes.Add(false);
            this.if_special_notes.Add(false);
            //this.if_special_notes.Add(false);
            //this.if_special_notes.Add(true);
            this.if_special_notes.Add(true);

            // if I have to pick up a special note, it would be:
            this.special_notes.Add("-");
            this.special_notes.Add("-");
            this.special_notes.Add("-");
            this.special_notes.Add("x");
        }


        /**
         * Pick how many commas are required.
         * Calculations based on percentages.
         */
        public int randomize_commas()
        {
            int random_index = r.Next(0, commas.Count - 1);
            int rc = commas[random_index];
            return rc;
        }


        public int randomize_hops()
        {
            int rc = hops[r.Next(0, hops.Count - 1)];
            return rc;
        }

        public bool randomize_if_special_notes()
        {
            bool rc = this.if_special_notes[r.Next(0, this.if_special_notes.Count - 1)];
            return rc;
        }


        public string special_note()
        {
            string rc = this.special_notes[r.Next(0, this.special_notes.Count - 1)];
            return rc;
        }
    }
}
