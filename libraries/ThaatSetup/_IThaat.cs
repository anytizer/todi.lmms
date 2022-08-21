using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries.ThaatSetup
{
    abstract public class _IThaat
    {
        protected Thaat thaat;

        abstract protected void setup();

        public Thaat get()
        {
            return this.thaat;
        }
    }
}
