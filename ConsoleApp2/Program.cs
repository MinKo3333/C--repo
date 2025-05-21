using System.Text.Json.Serialization.Metadata;

namespace PP_2_Oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("welcome to virtual pet world!\n" +
                              "1. I want to create a new pet\n" +
                              "2. I want to play with my existing pet");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a new pet");
                program.setAnimal();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have chosen to play with your existing pet");
            }
        }

        public void showAnimalList()
        {
            int numbers = 1;
            foreach (var animal in animals)
            {

                Console.WriteLine($"{numbers}. name: {animal.Name}\n" +
                                  $"age : {animal.Age}\n" +
                                  $"color : {animal.Color}");
                numbers++;
            }
        }


        public List<Animal> animals = new List<Animal>();


        void setAnimal()
        {
            Console.WriteLine("What do you want to name your pet?");
            string name = Console.ReadLine();
            Console.WriteLine("How old is your pet?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What color is your pet?");
            string color = Console.ReadLine();

            animals.Add(new Animal(name, age, color));
            
        }
    
    }


        public class Animal
        {
            public string Name { get; private set; }
            public int Age { get; private set; }
            public string Color { get; private set; }
            public int Feed { get; private set; }

            public int hungerNow { get; set; }
            public int Poop { get; private set; }
            public int toiletNow { get; set; }


            public Animal(string name, int age, string color)
            {
                Name = name;
                Age = age;
                Color = color;
                Feed = new Random().Next(1, 10);
                hungerNow = Feed;
                Poop = new Random().Next(1, 10);
                toiletNow = Poop;

            }

            
        }

        public class action
        {

            public void feedTheAnimal(Animal animal)
            {
                if (animal.hungerNow > 0)
                {
                    Console.WriteLine($"{animal.Name} is fed");

                    animal.hungerNow = animal.hungerNow - 2;
                }

                else{
                    Console.WriteLine($"{animal.Name} is full");
                    animal.hungerNow = animal.Feed;
                }
            }

            public void toiletTheAnimal(Animal animal)
            {
                if (animal.toiletNow > 0)
                {
                    Console.WriteLine($"{animal.Name} pooped");
                    animal.toiletNow = animal.toiletNow - 2;
                }
                else
                {
                    Console.WriteLine($"{animal.Name} doesn't need to poop");
                    animal.toiletNow = animal.Poop;
                }
            }

            public void cuddleTheAnimal(Animal animal)
            {
                Console.WriteLine($"{animal.Name} is very happy now");
            }
        }

 }
         
 

    
