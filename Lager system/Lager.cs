using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager_System
{
    internal class Lager
    {
        private List<IProdukt> produkt = new List<IProdukt>{};
        


        public void leggeTilItem(IProdukt name)
        {
            produkt.Add(name);
        }

        public void fjerneItem(IProdukt name)
        {
            produkt.Remove(name);
        }

        public void listeOppItems()
        {
            foreach (var p in produkt)
            {
                p.SkrivUtInfo();
            }
        }

    }
}
