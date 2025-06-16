namespace Lager_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lager = new Lager();

            Elektronikk hårføner = new Elektronikk("hårføner", 300,20);
            Elektronikk vannkoker = new Elektronikk("vannkoker", 150, 20);
            Matvare appelsin = new Matvare("appelsin",20,"25/05/2025");
            Matvare kiwi = new Matvare("kiwi", 5, "28/05/2025");
            Klær blåBukse = new Klær("blå bukse", 500,"S");
            Klær brunBukse = new Klær("brun bukse", 500, "L");

            lager.leggeTilItem(hårføner);
            lager.leggeTilItem(vannkoker);
            lager.leggeTilItem(appelsin);
            lager.leggeTilItem(kiwi);
            lager.leggeTilItem(blåBukse);
            lager.leggeTilItem(brunBukse);

            lager.fjerneItem(appelsin);
            lager.listeOppItems();


        }
    }
}
