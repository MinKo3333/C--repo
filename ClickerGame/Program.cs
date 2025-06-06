using System.Runtime.ConstrainedExecution;

namespace ClickerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var clickerGame = new ClickerGame();
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n" +
                                  "- SPACE = klikk(og få poeng)\r\n" +
                                  "- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n" +
                                  "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n" +
                                  "- X = avslutt applikasjonen");

                Console.WriteLine($"Du har {clickerGame.points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;



            }


        }

    }

    class C_K : ICommand
    {
        public void Run(ClickerGame clikerGame)
        {
            // Increase points per click by 1 for 10 points
            clikerGame.C_K();
        }
    }

    class C_X : ICommand
    {
        public void Run(ClickerGame clikerGame)
        {
            Environment.Exit(0);
        }
    }

    class C_Space : ICommand
    {
        public void Run(ClickerGame clikerGame)
        {
            clikerGame.C_K();
        }
    }

    class C_S : ICommand
    {
        public void Run(ClickerGame clikerGame)
        {
            clikerGame.C_S();
        }
    }


}
