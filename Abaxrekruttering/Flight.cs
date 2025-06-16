using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Flight : ITransportation
    {
        public string RegisteredNum { get; private set; }
        public int Effect { get; private set; }
        public string Type { get; private set; }

        public int Wingspan { get; private set; }

        public int LoadAbility { get; private set; }

        public int Weight { get; private set; }

        public Flight(string registeredNum, int effect,int wingspan, int loadAbility, int weight)
        {
            RegisteredNum = registeredNum;
            Effect = effect;
            Wingspan = wingspan;
            LoadAbility = loadAbility;
            Weight = weight;
            Type = "Jet flight";
        }

        public void Run()
        {
            Console.WriteLine("The flight flies");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Registered Number : {RegisteredNum}\n" +
                              $"Effect : {Effect} kw\n" +
                              $"Wing span : {Wingspan} m\n" +
                              $"Load Ability : {LoadAbility} ton\n" +
                              $"Weight : {Weight} ton\n" +
                              $"Type : {Type}");
        }
    }
}
