namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hest yourHest;
            Game game = new Game();

            int answer = 0;
            Console.WriteLine("Hei, velg din hest\n" +
                              "1. Sally\n" +
                              "2. Thunder\n" +
                              "3. Mary");
            answer = int.Parse(Console.ReadLine());
            yourHest = Stall.hests[answer - 1];

           
            while(true)
            {
                Console.WriteLine("Velg hva du ønsker å gjøre med din hest\n" +
                              "1. Stelle hesten\n" +
                              "2. Mate hesten\n" +
                              "3. Registrere til hesteløp\n" +
                              "4. Starte hesteløp\n" +
                              "5. Ferdig");

                answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 1: yourHest.Stelle();
                    break;
                    case 2: yourHest.Mate();
                    break;
                    case 3: game.Registere(yourHest);
                    break;
                    case 4: 
                        Console.Clear();
                        game.RunGame();
                    break;
                    case 5: Environment.Exit(0);
                    break;
                }
                

            }
        }
    }
}
