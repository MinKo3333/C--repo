using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_fight
{
    internal class GameCharacter
    {
        public int Health { get; private set; }
        public string Strength { get; private set; }
        public int Stamina { get; private set; }
        public int startStamina { get; private set; }

        public string Name { get; private set; }
        public GameCharacter(int health, string strength, int stamina, string name)
        {

            Name = name;
            Health = health;
            Strength = strength;
            startStamina = stamina;
            Stamina = stamina;
        }
        public void Fight(GameCharacter enemy)
        {   
            if (Strength == "random")
            {
                Random random = new Random();
                int num = random.Next(0, 31);
                this.Strength = num.ToString();
            }
            if (Stamina < 10)
            {
                Console.WriteLine($"Not enough stamina to fight!");
                Recharge();

            }
            
            this.Stamina -= 10;
            enemy.Health -= int.Parse(this.Strength);
            Console.WriteLine($"{Name} hit {enemy.Name} with {Strength} damage, now {enemy.Name} has {enemy.Health} health.");

            if(Name == "boss")
            {
                Strength = "random"; // Reset boss strength to random after each fight
            }

        }

        public void Recharge()
        {
            this.Stamina = startStamina;
        }


    }
}
