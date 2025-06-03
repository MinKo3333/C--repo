using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace Boss_fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter Hero = new GameCharacter(100, "20", 40,"hero");
            GameCharacter Boss = new GameCharacter(400, "random", 10,"boss"); // Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles. 

            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(Hero);
            characters.Add(Boss);

            while (Hero.Health >= 0 && Boss.Health >= 0)
            {
                foreach (var character in characters)
                {
                  if (character.Stamina < 10) {
                    Console.WriteLine($"{character.Name} is recharging stamina to {character.startStamina}.");
                    character.Recharge(); continue;
                  }

                  GameCharacter enemy = characters.Find(c => c != character);

                  character.Fight(enemy);
                  

                }
            }

            if (Hero.Health > 0)
            {
                Console.WriteLine("Hero wins!");
            }
            else
            {
                Console.WriteLine("Boss wins!");
            }
        }


    }
}
