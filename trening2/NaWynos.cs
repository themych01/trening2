using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace trening2
{
    class NaWynos: Zamowienie
    {
        public override bool PoprawnyCzas()
        {
            if ( czasDostawy == "jutro"  )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
