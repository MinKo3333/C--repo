using System;

//Converter
//Lag et program som kan konvertere valuta, temperatur eller vekt
//Du skal kunne få alternativer for hva du vil konvertere, velge hva du vil konvertere til, og så skrive inn en verdi før du får svar i konsollen.



namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Current = new Program();
            Console.WriteLine("Hei, Hva vil du konverter med?\n" +
                "1. temperatur\n" +
                "2. valuta\n" +
                "3. volume");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Hva vil du konvertere til?\n" +
                        "1. Celsius\n" +
                        "2. Fahrenheit");
                    int answerTemp = int.Parse(Console.ReadLine());
                    if (answerTemp == 1)
                    {
                        Console.WriteLine("Skriv inn Fahrenheit verdi:");
                        int Feh = int.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius verdi er: " + Current.convertToCel(Feh));
                    }
                    else
                    {
                        Console.WriteLine("Skriv inn Celsius verdi:");
                        int Cel = int.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit verdi er: " + Current.convertToFeh(Cel));
                    }
                    break;

                case 2:
                    Console.WriteLine("Hva vil du konvertere til?\n" +
                        "1. Euro\n" +
                        "2. Krone");
                    answerTemp = int.Parse(Console.ReadLine());
                    if (answerTemp == 1)
                    {
                        Console.WriteLine("Skriv inn Krone verdi:");
                        int Krone = int.Parse(Console.ReadLine());
                        Console.WriteLine(Current.convertToEuro(Krone) + " €");
                    }
                    else
                    {
                        Console.WriteLine("Skriv inn euro verdi:");
                        int Euro = int.Parse(Console.ReadLine());
                        Console.WriteLine(Current.convertToKrone(Euro)+"kroner");
                    }
                    break;

                case 3:
                    Console.WriteLine("Hva vil du konvertere til?\n" +
                        "1. Oz\n" +
                        "2. ml");
                    answerTemp = int.Parse(Console.ReadLine());
                    if (answerTemp == 1)
                    {
                        Console.WriteLine("Skriv inn ml verdi:");
                        int ml = int.Parse(Console.ReadLine());
                        Console.WriteLine(Current.convertToOz(ml) + " Oz");
                    }
                    else
                    {
                        Console.WriteLine("Skriv inn Oz verdi:");
                        int Oz = int.Parse(Console.ReadLine());
                        Console.WriteLine(Current.convertToml(Oz) + "ml");
                    }
                    break;

                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    Main(args);
                    break;

            } 
        }
    

        public int convertToFeh(int Cel){
            int Feh = (Cel * 9 / 5) + 32;

            return Feh;
        }

        public int convertToCel(int Feh)
        {
            int Cel = (Feh - 32) * 5 / 9;
            return Cel;
        }

        public int convertToKrone(int Euro)
        {
            int Kroner = (int)(Euro * 11.5);
            return Kroner;
        }

        public int convertToEuro(int Kroner)
        {
            int Euro = (int)(Kroner / 11.5);
            return Euro;
        }

        public int convertToml(int Oz)
        {
            int ml = (int)(Oz * 29.5735);
            return ml;
        }

        public int convertToOz(int ml)
        {
            int Oz = (int)(ml / 29.5735);
            return Oz;
        }

    }

}
