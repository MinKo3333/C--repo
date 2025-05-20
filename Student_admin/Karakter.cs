using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_admin
{
    internal class Karakter
    {
        internal Student Student { get; private set; }
        internal Fag Fag { get; private set; }

        internal int Karakterverdi { get; private set; }

        public Karakter(Student student, Fag fag)
        {
            Student = student;
            Fag = fag;
        }


        public void SkrivUtInfo()
        {
            Karakterverdi = new Random().Next(1, 101);
            Console.WriteLine($"{Student.Navn}");
            Console.WriteLine(
                $"Fagnavn: {Fag.Fagnavn} " +
                $"Karakterverdi: {Karakterverdi}");

            Student.fagkarakter.Add(Karakterverdi);
            
        }

        
    

}
}
