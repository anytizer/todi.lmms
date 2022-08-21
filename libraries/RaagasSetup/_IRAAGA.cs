using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.RaagasSetup
{
    abstract public class _IRAAGA
    {
        protected Raaga raaga = new Raaga(ThaatNames._UNKNOWN, RaagaNames._UNKNOWN, "", "");
        

        protected abstract void setup();


        public Raaga get()
        {
            return raaga;
        }

        protected void set_raaga_link(string link)
        {
            this.raaga.set_raaga_link(link);
        }

        protected void set_completed()
        {
            // @todo: For automation, define more logic
            // links, notations, remarks, etc. are filled up?
            this.raaga.set_completed();
        }

    }
}
