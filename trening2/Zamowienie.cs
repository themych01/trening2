using System;
using System.Collections.Generic;
using System.Text;

namespace trening2
{
    abstract class Zamowienie
    {
        protected string czasDostawy;
        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UstawCzasDostawy(string v)
        {
            czasDostawy = v;
        }
    }
}
