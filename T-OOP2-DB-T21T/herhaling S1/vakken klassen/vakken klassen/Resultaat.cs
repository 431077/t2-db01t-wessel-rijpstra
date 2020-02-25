using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vakken_klassen
{
    class Resultaat
    {
        public Vak Vak { get; set; }
        public int Cijfer { get; set; }

        public Resultaat(Vak vak, int cijfer)
        {
            Vak = vak;
            Cijfer = cijfer;
        }

        public override string ToString()
        {
            return $"{Vak}, {Cijfer}";
        }
    }
}
