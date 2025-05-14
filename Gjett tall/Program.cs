//Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100
//Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere, helt til man gjetter riktig tall. Da skal man få spørsmål om man vil spille på nytt



namespace Gjett_tall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool getAnswer = false;
            Console.WriteLine("Velkommen til gjett tallet!\n" +
                              "Gjett nummeret mellom 1 og 100");

            int random = generateNum();
           
            while (getAnswer == false)
            { 
                int answer = int.Parse(Console.ReadLine());
                getAnswer = checkAnswer(answer, random);
                if (getAnswer == true)
                {
                    Console.WriteLine("Vil du spille på nytt? (ja/nei)");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "ja")
                    {
                        random = generateNum();
                        getAnswer = false;
                        Console.WriteLine("Velkommen til gjett tallet!\n" +
                                          "Gjett nummeret mellom 1 og 100");
                    }
                    else
                    {
                        Console.WriteLine("Takk for at du spilte!");
                        break;
                    }
                }
            }

        }

        static int generateNum()
        {
            var random = new Random().Next(1, 101);
            return random;
        }

        static bool checkAnswer(int answer, int random)
        {
            if (answer < random)
            {
                Console.WriteLine("Answer is higher");
                return false;
            }
            else if (answer > random)
            {
                Console.WriteLine("Answer is lower");
                return false;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                return true;

            }
        }
    
}
}
