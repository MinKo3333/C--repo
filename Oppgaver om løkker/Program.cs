namespace Oppgaver_om_løkker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            whileløkke();
        }


      static void forløkke()
        {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Terje er kul"); 
            }
        } 
      
       static void foreachløkke()
        {
            string ord = "Cats are the best";
            foreach (char i in ord)
            {
                Console.WriteLine(i);
            }
        }

       static void whileløkke()
        {
            int runde = 1;
            while (runde<10) {
                Console.WriteLine($"Runde nummber: nr {runde}");
                runde++;
            }
        }
    }
}
