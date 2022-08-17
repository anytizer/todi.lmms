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
     * Vadi – Most used note
     * Samvadi – Second most used note
     * Time – of Singing or playing
     */
    public class Raaga
    {
        private string THAAT_NAME = "";
        private string THAAT_NOTATIONS = "";

        private List<string> ascending_notes = new List<string>() { }; // aaroh
        private List<string> descending_notes = new List<string>() { }; // avaroh


        public void set_thaat(string thaat_name, string thaat_notations)
        {
            this.THAAT_NAME = thaat_name;
            this.THAAT_NOTATIONS = thaat_notations;
        }

        public void set_notes(string aaroh_list, string avroah_list, string remarks)
        {
            this.set_ascending_notes(aaroh_list);
            this.set_descending_notes(avroah_list);
            this.set_remarks(remarks);
        }

        private void set_ascending_notes(string aaroh_list)
        {
            // aaroh and avaroh may be different; not alwyas just opposite
            // https://musicwithaditi.com/aaroh-avroh/
            string[] notes_ascending = aaroh_list.Split(' ');
            foreach (string note in notes_ascending)
            {
                string _note = note.Trim();
                if (_note != "") // this.THAAT_NOTATIONS.Contains(_note))
                {
                    this.ascending_notes.Add(_note);
                }
            }
        }
        private void set_descending_notes(string avaroh_list)
        {
            // probably unuseful when descending notes are just opposite
            string[] notes_descending = avaroh_list.Split(' '); // .Reverse().ToArray(); // already reversed
            foreach (string note in notes_descending)
            {
                string _note = note.Trim();
                if (_note != "")
                {
                    this.descending_notes.Add(_note);
                    
                    
                    // patch line
                    this.ascending_notes.Add(_note);
                }
            }
        }
        public void set_pakad(string notes) { }
        public void set_chalan(string notes) { }
        public void set_vaadi(string note) { }
        public void set_samavaadi(string note) { }
        public void set_timing(string note) { }
        public void set_remarks(string remarks) { }


        int hops = 0;
        public string generate_random_note()
        {
            string next_note = "";
            hops = new Data().randomize_hops(); // -2, -1, 0, +1, +2


            next_note = this.random_note(this.ascending_notes, hops);

            /*
            if (direction > 0)
            {
                // up: CDEFGAB
                next_note = this.random_note(this.ascending_notes, direction);
            }
            else
            {
                // down: GBAGFEDC
                next_note = this.random_note(this.descending_notes, direction);
                
                
                //next_note = this.random_note(this.ascending_notes, direction);
            }*/

            return next_note;

        }

        
        private int current_index = 0;
        private string random_note(List<string> notes, int hops = 0)
        {
            //string higher_octave = "*";
            //string lower_octave = ".";

            current_index += hops;
            
            
            // patch block
            /*
            if(current_index < 0)
            {
                current_index = notes.Count - 1;
            }
            if(current_index >= notes.Count)
            {
                current_index = 0;
            }*/


            string next_note = "";

            int divider = (notes.Count > 0)?notes.Count:1; // ensure +1 and more value
  
            //int next_index = Math.Abs(hops + current_index) % divider;
            int next_index = Math.Abs(current_index) % divider;
            
            
            next_note = notes[next_index];

            return next_note;
        }

    }
}
