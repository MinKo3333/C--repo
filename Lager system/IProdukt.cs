using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager_System
{
    public interface IProdukt
    {
    
            string Navn { get; set; }
            double Pris { get; set; }
            void SkrivUtInfo();
        
    }
}
