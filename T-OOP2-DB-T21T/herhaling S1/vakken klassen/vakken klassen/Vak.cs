using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vakken_klassen
{
    class Vak
    {
        public string VakCode { get; set; }
        public string VakNaam { get; set; }
        public int SBU { get; set; }

        public Vak(string vakcode, string vaknaam, int sbu)
        {
            VakCode = vakcode;
            VakNaam = vaknaam;
            SBU = sbu;
        }

        public override string ToString()
        {
            return $"{VakCode}, {VakNaam}, {SBU}";
        }

    }
}
