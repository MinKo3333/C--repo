using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Application
{
    internal class ElectricCar  : Car
    {
        public bool IsElectric { get; private set; } = true;

        public ElectricCar(string name, int weight, string color, int horsepowers) : base(name,weight,color,horsepowers)
        {
            
        }

        private int GetTopSpeed() {

            int TopSpeed = (int)((base.GetTopSpeed())*0.8);

            return TopSpeed;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Weight: {Weight}kg\n" +
                              $"Color: {Color}\n" +
                              $"Horse powers: {HorsePowers}\n" +
                              $"Top speed: {GetTopSpeed()}\n"+
                              $"+Half price for road toll");
        }
    }
}
