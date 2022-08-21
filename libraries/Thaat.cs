using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries
{
    public class Thaat
    {
        public string THAAT_NAME { get; set; } = "";
        public string THAAT_NOTATIONS_ALLOWED { get; private set; } = "";
        private List<string> THAAT_LINKS { get; set; } = new List<string>() { };

        public string get_thaat_link()
        {
            string link = "";
            if (this.THAAT_LINKS.Count > 0)
            {
                // @todo pink random link
                link = this.THAAT_LINKS.First();
            }

            return link;
        }


        public void set_thaat(string thaat_name, string thaat_notations_allowed)
        {
            this.THAAT_NAME = thaat_name;
            this.THAAT_NOTATIONS_ALLOWED = thaat_notations_allowed;
        }
        
        public void set_thaat_link(string link)
        {
            this.THAAT_LINKS.Add(link);
        }
    }
}
