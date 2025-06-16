using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Car : ITransportation
    {
        public string RegisteredNum { get; private set; }
        public int Effect { get; private set; }
        public int MaxSpeed { get; private set; }
        public string Color { get; private set; }
        public string Type { get; private set; }

        public Car(string registeredNum, int effect, int maxspeed, string color)
        {
            RegisteredNum = registeredNum;
            Effect = effect;
            MaxSpeed = maxspeed;
            Color = color;
            Type = "light transportation";
        }

        public void Run()
        {
            Console.WriteLine("The car drives");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Registered number : {RegisteredNum}\n" +
                              $"Effect : {Effect}kw\n" +
                              $"Max speed : {MaxSpeed}km/h\n" +
                              $"Color : {Color}\n" +
                              $"Type : {Type}");
        }
    }
}
