using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Application
{
    internal class Car : ICar
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }

        public string Color { get; private set; }
        public int HorsePowers { get; private set; }

        public Car(string name, int weight, string color, int horsepowers)
        {
            Name = name;
            Weight = weight;
            Color = color;
            HorsePowers = horsepowers;
        }

        protected int GetTopSpeed()
        {
            int TopSpeed = HorsePowers * Weight / 650;
            return TopSpeed;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Weight: {Weight}kg\n" +
                              $"Color: {Color}\n" +
                              $"Horse powers: {HorsePowers}\n" +
                              $"Top speed: {GetTopSpeed()}");
        }
    }
}
