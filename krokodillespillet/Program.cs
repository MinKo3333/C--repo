using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til krokodillespillet");
            int Poeng = 0;

            do
            {
                var (numberA, numberB) = GenerateNumbers();
                Console.WriteLine($"{numberA}_{numberB}");
                Poeng = Score(numberA, numberB, Poeng);
                if (Poeng == 10000) { Console.WriteLine("Avsluttes spillet"); return;
                        }
                Console.WriteLine($"Din poeng : {Poeng}");

            }
            while (Poeng != 10000);

        }
        static public (int A, int B) GenerateNumbers()
        {

            int numberA = new Random().Next(1, 12);
            int numberB = new Random().Next(1, 12);

            return (numberA, numberB);
        }

        static public int Score(int A, int B, int Poeng)
        {
            var svaret = Console.ReadLine();

            if (A < B)
            {
                if (svaret == "<")
                {
                    Console.WriteLine("Riktig! Du får 1 poeng");
                    Poeng++;
                }
                if (svaret == ">" || svaret == "=")
                {
                    Console.WriteLine("feil! Du mister 1 poeng.");
                    Poeng--;
                }
            }
            if (A > B)
            {
                if (svaret == "<" || svaret == "=")
                {
                    Console.WriteLine("feil! Du mister 1 poeng.");
                    Poeng--;
                }
                if (svaret == ">")
                {
                    Console.WriteLine("Riktig! Du får 1 poeng");
                    Poeng++;
                }
            }
            if (A == B)
            {
                if (svaret == "=")
                {
                    Console.WriteLine("Riktig! Du får 1 poeng");
                    Poeng++;
                }
                if (svaret == ">" || svaret == "<")
                {
                    Console.WriteLine("feil! Du mister 1 poeng.");
                    Poeng--;
                }
            }


            if (svaret != "<" && svaret != ">" && svaret != "=") {
                Poeng = 10000;
            }
            return Poeng;

        }

               
        
    }
}

