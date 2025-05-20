namespace PP_Virtual_Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pikachu = new Action("pikachu", 3, 2, 2);
            var kanin = new Action("kanin", 1, 0, 1);

            Console.WriteLine("Velg en kjæledyr\n" +
                              "1. pikachu\n" +
                              "2. kanin");
        }
    }
}
