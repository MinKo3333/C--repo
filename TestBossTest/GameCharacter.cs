using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBossTest
{
    public class GameCharacter
    {
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }

        public GameCharacter(int health, int strength, int stamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public void Fight(GameCharacter enemy)
        {
            if (Stamina <= 0)
            {
                throw new InvalidOperationException("Not enough stamina to fight.");
            }

            enemy.Health -= Strength;
            Stamina -= 10; // Assume each fight costs 10 stamina
        }

        public void Fight(GameCharacter enemy, int strength)
        {
            if (Stamina <= 0)
            {
                throw new InvalidOperationException("Not enough stamina to fight.");
            }
            enemy.Health -= strength;
            Stamina -= 10; // Assume each fight costs 10 stamina
        }

        public void DrainStamina(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to drain cannot be negative.");
            }

            Stamina -= amount;
            if (Stamina < 0)
            {
                Stamina = 0; // Prevent stamina from going below zero
            }
        }

        public void Recharge()
        {
            Stamina = 10; // Recharge stamina to a fixed value, e.g., 10

        }

    }
}
