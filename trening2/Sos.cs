using System;
using System.Collections.Generic;
using System.Text;

namespace trening2
{
    class Sos: Skladnik
    {
        public Sos(string nazwaSkladnika, double cenaSkladnika)
            : base(nazwaSkladnika,cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }
        public override string ToString()
        {
            return "Sos: " + nazwaSkladnika +  ", cena:" + cenaSkladnika;
        }

    }
}
