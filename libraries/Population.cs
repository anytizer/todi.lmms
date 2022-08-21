namespace libraries
{
    public class Population
    {
        private List<int> commas = new List<int>() { };
        private List<int> hops = new List<int>() { };
        private List<bool> if_pick_special_notes = new List<bool>() { };
        private List<string> special_notes = new List<string>() { };

        private Random r = new Random();

        public Population()
        {
            this.populate_commas();
            this.populate_hops();
            this.populate_special_notes();
        }

        private void populate_commas()
        {
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

            // 30% chance creator
            commas.Add((int)Commas.Half);
            commas.Add((int)Commas.Half);

            // 10% chance creator
            commas.Add((int)Commas.Quarter);
        }

        private void populate_hops()
        {
            //this.hops.Add(-2);
            this.hops.Add(-1); // downwards / back
            this.hops.Add(-1); // downwards / back
            this.hops.Add(-1); // downwards / back
            this.hops.Add(-1); // downwards / back
            this.hops.Add(-1); // downwards / back
            this.hops.Add(+0); // forward: Continue a note | Do not use at peaks and valleys
            this.hops.Add(+1); // upwards
            this.hops.Add(+1); // upwards
            this.hops.Add(+1); // upwards
            this.hops.Add(+1); // upwards
            this.hops.Add(+1); // upwards
            //this.hops.Add(+2); // upwards: skipping a note
        }

        private void populate_special_notes()
        {
            // decide if to pick a special note
            this.if_pick_special_notes.Add(false);
            this.if_pick_special_notes.Add(false);
            this.if_pick_special_notes.Add(false);
            this.if_pick_special_notes.Add(false);
            this.if_pick_special_notes.Add(true);
            this.if_pick_special_notes.Add(true);

            // if I have to pick up a special note, it would be:
            this.special_notes.Add("-");
            this.special_notes.Add("-");
            //this.special_notes.Add("-");
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
            int random_index = r.Next(0, hops.Count - 1);
            int rc = hops[random_index];
            return rc;
        }

        public bool randomize_if_pick_special_notes()
        {
            int random_index = r.Next(0, this.if_pick_special_notes.Count - 1);
            bool rc = this.if_pick_special_notes[random_index];
            return rc;
        }

        public string special_note()
        {
            int random_index = r.Next(0, this.special_notes.Count - 1);
            string rc = this.special_notes[random_index];
            return rc;
        }
    }
}
