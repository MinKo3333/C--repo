namespace Overloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var welcome = new PrintWelcomeMessage();
            var welcomeWithName = new PrintWelcomeMessage("Du er veldig fin.");
        }
    }

    internal class PrintWelcomeMessage
    {
        internal PrintWelcomeMessage(string compliment = "Du er snill!")
        {
            Console.WriteLine($"Hei og velkommen\n" +
                              $"{compliment}");
        }
    }
}
