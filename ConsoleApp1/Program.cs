namespace Pikachu
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var pika = new Pikachu();
            pika.health = 50;
            pika.level = 22;
            Console.WriteLine($"Pikachu har health:{pika.health} level:{pika.level}");
        }
    }

    internal class Pikachu
    {
        internal int health;
        internal int level;
    }
}
