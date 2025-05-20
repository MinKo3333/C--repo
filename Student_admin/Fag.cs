using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_admin
{
    internal class Fag
    {
        internal string Fagnavn { get; private set; }
        internal string Fagkode { get; private set; }
        internal string AntallStudiepoeng { get; private set; }


        public Fag(string fagnavn, string fagkode, string antallStudiepoeng)
        {
            Fagnavn = fagnavn;
            Fagkode = fagkode;
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo() {
            Console.WriteLine(
                $"Fagnavn: {Fagnavn}\n" +
                $"Fagkode: {Fagkode}\n" +
                $"Antall studiepoeng: {AntallStudiepoeng}");
        }
    }
}
