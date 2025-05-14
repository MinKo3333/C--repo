namespace Random_hobby_generator
{
    internal class Program
    {   static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Who would like a new hobby?");
            var who = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(who))
            {
                Console.WriteLine("Please enter a name.");
                return;
            }

            string Result = generateHobby(who);
            Console.WriteLine(Result);
        }

        static string generateHobby(string who)
        {
            string[] hobbies = { $"{who} is now a magician.", $"{who} is now a gardener.", $"{who} is now a cook.", $"{who} is now a painter.",
                $"{who} is now a photographer.",$"{who} is now a traveler.", $"{who} is now a writer.", $"{who} is now a knitter.", $"{who} is now an athlete.", $"{who} is now a fisherman." };
            
            int index = random.Next(hobbies.Length);
            return hobbies[index];
        }
    }
}
