using libraries;

namespace todi.lmms
{
    class SARGAMizer
    {
        private const int MAX_TOTAL_LINES_Y = 64;
        private const int MIN_TOTAL_LINES_Y = 4;

        public List<string> lyrics(int total_lines_y = 12, int numerator = 3, int denumerator = 4)
        {
            if (total_lines_y > MAX_TOTAL_LINES_Y) total_lines_y = MAX_TOTAL_LINES_Y;
            if (total_lines_y < MIN_TOTAL_LINES_Y) total_lines_y = MIN_TOTAL_LINES_Y;


            RaagaData rd = new RaagaData();
            Raaga raaga = rd.get_one_raaga(); // aabhogi | hameer | yaman | bhoopali | hamsadhvani


            List<string> notations = new List<string>() { };
            for (int line = total_lines_y; line > 0; --line)
            {
                for (int d = 0; d < denumerator; ++d)
                {
                    for (int n = 0; n < numerator; ++n)
                    {
                        bool pick_special_note = new Data().randomize_if_special_notes();
                        if (!pick_special_note)
                        {
                            // regular note
                            Cell cell = new Cell();
                            cell.comma = new Data().randomize_commas();

                            // treat cell's comma.
                            // eg. 1 comma = 2 entries
                            // 2 commas = 3 entries (do not use if possible: might produce a glitch)
                            // 3 commas = 4 entries (quarter notes)
                            for (int c = 0; c < cell.comma + 1; ++c)
                            {
                                string note = raaga.generate_random_note();
                                cell.notes.Add(note);
                            }
                            notations.Add(string.Join(",", cell.notes));
                        }
                        else
                        {
                            notations.Add(new Data().special_note());
                        }
                    } // numerator

                } // denumerator

                notations.Add("\r\n");
            }

            if (notations[0] == "-") notations[0] = "SA"; // patch

            return notations;
        }
    }
}
