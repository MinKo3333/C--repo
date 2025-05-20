using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PP_Virtual_Pet
{
    internal class Action
    {
        internal string Name { get; private set; }
        internal int Age { get; private set; }
        internal int frequencyToToilet { get; private set; }
        internal int frequencyToEat { get; private set; }
        public Action(string name, int age, int frequencyToToilet, int frequencyToEat)
        {
            Name = name;
            Age = age;
            this.frequencyToToilet = frequencyToToilet;
            this.frequencyToEat = frequencyToEat;
        }
        public void Feed()
        {
            Console.WriteLine($"Gi {Name} mat");
            frequencyToEat--;
            // Logic to feed the pet

            if (frequencyToEat <= 0)
            {
                Console.WriteLine($"{Name} er mett!");
                // Logic to handle hunger
            }
        }
        public void Play()
        {
            Console.WriteLine($"Playing with {Name}");
            // Logic to play with the pet
        }
        public void Poop()
        {
            Console.WriteLine($"{Name} bæsjet mye");
            frequencyToToilet--;
            // Logic to clean the pet
            if (frequencyToToilet <= 0)
            {
                Console.WriteLine($"{Name} kan ikke bæsje mer!");
                // Logic to handle toilet needs
            }
        }
        public void Sleep()
        {
            Console.WriteLine($"legg {Name} på senga...");
            // Logic to put the pet to sleep
        }
    }
}
