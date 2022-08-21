using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries
{
    public class Notation
    {
        private List<string> NOTES = new List<string>() { };

        public void set_formatted_notes(string notes_string = "")
        {
            string[] notes = notes_string.Split(' ');
            foreach (string note in notes)
            {
                string _note = note.Trim();
                if (_note != "")
                {
                    this.NOTES.Add(_note);
                }
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.NOTES);
        }

        public int count()
        {
            return this.NOTES.Count;
        }

        /**
         * Swining index can be negative number
         */
        public string nth_note(int swinging_index, int character_index)
        {
            string note = "";

            int count = this.count();
            int index = 0;

            if (count >= 1)
            {
                //index = swinging_index % count;
                // sa re ga pa dha sa sa dha pa ga re sa
                // clock like notations
                index = Math.Abs(count + swinging_index) % count;
                note = this.NOTES[index];
            }

            return note;
        }
    }
}
