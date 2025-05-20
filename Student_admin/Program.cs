namespace Student_admin
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<Fag> fagList = new List<Fag>
        {
            new Fag("Datateknologi","1134","12"),
            new Fag("Zoology", "1132", "8"),
            new Fag("Fysikk", "1534", "4"),
            new Fag("engelsk", "2442", "5")
        };
            var student1 = new Student("Ola Nordmann", "20", "Datateknologi", "123456",new List<Fag> { fagList[0], fagList[3] });
            var student2 = new Student("Elsa", "21", "Zoology", "123457", new List<Fag> { fagList[1], fagList[3] });

            var karakter1 = new Karakter(student1, fagList[0]);
            var karakter2 = new Karakter(student1, fagList[3]);
            
            var karakter3 = new Karakter(student2, fagList[1]);
            var karakter4 = new Karakter(student2, fagList[3]);

            karakter1.SkrivUtInfo();
            karakter2.SkrivUtInfo();

            karakter3.SkrivUtInfo();
            karakter4.SkrivUtInfo();

            student1.SkrivUtInfo();
            student2.SkrivUtInfo();
  
        }
    }
}
