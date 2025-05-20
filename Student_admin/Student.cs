using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_admin
{
    internal class Student
    {
        internal string Navn { get; private set; }
        internal string Alder { get; private set; }
        internal string Studieprogram { get; private set; }
        internal string StudentID { get; private set; }

        internal List<Fag>fagListe { get; private set; }

        public Student(string navn, string alder, string studieprogram, string studentID, List<Fag>fag )
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentID;
            fagListe = fag;
        }



        internal List<int> fagkarakter { get; set; } = new List<int>();


        public double getAverage()
        {
            int poeng =0;

            foreach (var fag in fagkarakter)
            {   
                poeng += fag;
            }

            double average = (double)poeng / fagkarakter.Count;
            return average;
        }

        public int getStudyPoint()
        {
            int poeng = 0;
            foreach (var fag in fagListe)
            {
                poeng += int.Parse(fag.AntallStudiepoeng);
            }
            return poeng;
        }

        public void SkrivUtInfo()
        {   
            Console.WriteLine(""+string.Empty.PadLeft(30,'*'));
            Console.WriteLine($"Navn : {Navn}\n" +
                              $"Alder: {Alder}\n" +
                              $"Studie program: {Studieprogram}\n" +
                              $"Student ID: {StudentID}\n" +
                              $"Antall studiepoeng: {getStudyPoint()}\n" +
                              $"Gjennomsnittskarakter: {getAverage()}"
                              );
            Console.WriteLine("" + string.Empty.PadLeft(30, '*'));

        }
    }
}
