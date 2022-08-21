using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries
{
    /**
     * Thaat: Name of Thaat or Scale
     * Aroh – Ascending order
     * Avroh – Descending order
     * Pakad – Main structure / order of using notes in the raag
     * Chalan – other uses?
     * Vadi – Most used note
     * Samvadi – Second most used note
     * Time – of Singing or playing
     */

    public class Raaga: Thaat
    {
        public string RAAGA_NAME = "";
        protected Notation ASCENDING_NOTES = new Notation(); // aaroh
        protected Notation DESCENDING_NOTES = new Notation(); // avaroh

        protected string JAATI = "";
        protected List<string> PAKAD = new List<string>();
        protected List<string> CHALAN = new List<string>();

        // https://en.wikipedia.org/wiki/Vadi_(music)
        protected string VAADI_NOTE = "";

        // https://en.wikipedia.org/wiki/Samavadi
        protected string SAMVAADI_NOTE = "";

        protected string TIME2PLAY = "";
        protected string REMARKS = "";


        protected List<string> RAAGA_LINKS = new List<string>() { };

        public bool COMPLETED { get; set; } = false;
        public Raaga(string thaat_name, string raaga_name, string aaroh, string avaroh)
        {
            this.THAAT_NAME = thaat_name;
            this.RAAGA_NAME = raaga_name;
            string raag_remarks = "";
            
            this.set_notes(aaroh, avaroh, raag_remarks);
        }

        public string get_raaga_link()
        {
            string link = "";
            if (this.RAAGA_LINKS.Count > 0)
            {
                // @todo pick random link
                link = this.RAAGA_LINKS.First();
            }

            return link;
        }

        public void set_notes(string aaroh_list, string avroah_list, string remarks)
        {
            this.set_ascending_notes(aaroh_list);
            this.set_descending_notes(avroah_list);

            this.set_remarks(remarks);
        }

        private void set_ascending_notes(string aaroh_list)
        {
            this.ASCENDING_NOTES.set_formatted_notes(aaroh_list);
        }
        private void set_descending_notes(string avaroh_list)
        {
            // aaroh and avaroh may be different; not alwyas just opposite
            // https://musicwithaditi.com/aaroh-avroh/

            // @todo: If last element of aaroh note matches first element of avaroha, pop from avaroha
            //avroah_list.Remove(0);
            //string notes_list = avaroh_list.Remove(0).Remove(LAST);
            //avaroh_list.SkipLast(1).ToArray();

            // patch line - because descending notes are not used so far
            // returning notes patched to the ascending ones, so that descending notes are not necessary to consider
            this.ASCENDING_NOTES.set_formatted_notes(avaroh_list);


            this.DESCENDING_NOTES.set_formatted_notes(avaroh_list);
        }

        public void set_pakad(string notes)
        {
            this.PAKAD.Add(notes);
        }

        public void set_chalan(string notes)
        {
            this.CHALAN.Add(notes);
        }

        public void set_vaadi(string vadi_note) { this.VAADI_NOTE = vadi_note; }
        public void set_samavaadi(string samavaadi_note) { this.SAMVAADI_NOTE = samavaadi_note; }
        public void set_timing(string time_range) { this.TIME2PLAY = time_range; }
        public void set_remarks(string remarks) { this.REMARKS = remarks; }

        public string generate_random_note()
        {
            // @todo see how this works?
            // https://scratch.mit.edu/projects/1122324/

            int hops = new Population().randomize_hops(); // -2, -1, 0, +1, +2
            string next_note = this.random_note(this.ASCENDING_NOTES, this.DESCENDING_NOTES, hops);
            return next_note;
        }
        
        private int swinging_index = 0; // where did the pointer move?
        private int positional_index = 0; // how many notes are generated?
        private string random_note(Notation ascending, Notation descending, int hops)
        {
            //string higher_octave = "*";
            //string lower_octave = ".";

            //swinging_index += Math.Abs(hops);
            this.swinging_index += hops;
            ++this.positional_index;

            //int next_index = swinging_index % ascending.count();
            //int next_index = swinging_index;


            string next_note = ascending.nth_note(swinging_index, positional_index);
            return next_note;
        }

        /**
         * Be careful when turning this flag to TRUE!
         * App can raise divide by zero error.
         */
        public void set_completed()
        {
            this.COMPLETED = true;
        }

        public string get_aaroh()
        {
            return this.ASCENDING_NOTES.ToString();
        }

        public string get_avaroh()
        {
            return this.DESCENDING_NOTES.ToString();
        }

        internal void set_raaga_link(string link)
        {
            this.RAAGA_LINKS.Add(link);
        }
    }
}