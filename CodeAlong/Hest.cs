using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Hest
    {
        public string Navn { get; private set; }
        private bool mett = false;
        private bool stelle = false;
        private int hastighet;
        private int rund = 1;
        public int km { get; private set;}

        public Hest(string navn, int hastighet)
        {
            Navn = navn;
            this.hastighet = hastighet;
        }

        public  void Mate()
        {
            Console.WriteLine("Hesten er mett nå.");
            mett = true;
        }

        public  void Stelle()
        {
            Console.WriteLine("Hesten er glad");
            stelle = true;
        }

        public void Run()
        {
            km = hastighet * rund;
            rund++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Navn} har løpt {km}kilometer.");
        }

    }
}
