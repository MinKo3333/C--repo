using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Ship : ITransportation
    {
        public string RegisteredNum { get; private set; }
        public int Effect { get; private set; }
        public int MaxSpeed { get; private set; }
        public string Type { get; private set; }
        public int LoadAbility { get; private set; }

        public Ship(string registeredNum, int effect, int maxSpeed, int loadAbility)
        {
            RegisteredNum = registeredNum;
            Effect = effect;
            MaxSpeed = maxSpeed;
            LoadAbility = loadAbility;
            Type = "Ship";
        }

        public void Run()
        {
            Console.WriteLine("The ship drives");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Registered Number : {RegisteredNum}\n" +
                              $"Effect : {Effect} kw\n" +
                              $"Max speed : {MaxSpeed} knots\n" +
                              $"Load Ability : {LoadAbility} ton\n" +
                              $"Type : {Type}");
        }
    }
}
