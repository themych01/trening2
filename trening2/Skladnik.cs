using System;
using System.Collections.Generic;
using System.Text;

namespace trening2
{
    class Skladnik : IComparable
    {

        protected string nazwaSkladnika;
        protected double cenaSkladnika;
        public Skladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }
        public override string ToString()
        {
            return "Składnik: " + nazwaSkladnika + ", cena: " + cenaSkladnika;
        }
        public double PobierzCene()
        {
            return cenaSkladnika;
        }

        public int CompareTo(object obj)
        {
            return cenaSkladnika.CompareTo(cenaSkladnika);
        }
    }
}
