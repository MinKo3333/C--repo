namespace Oppgave2;

internal class Program
{
    static void Main(string[] args)
    {
        Person marianne = new Person("Marianne", 20, "black", "programming", "Genshin Impact");
        Person minseong = new Person("Minseong", 31, "black", "drinking coffee", "taking care of parrots");

        marianne.Introduction();
        minseong.Introduction();
    }

    public class Person
    {
        private string name;
        private int age;
        private string hairColor;
        private string activity;
        private string hobby;

        public Person(string name, int age, string hairColor, string activity, string hobby)
        {
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
            this.activity = activity;
            this.hobby = hobby;
        }

        public void Introduction()
        {
            Console.WriteLine($"My name is {name}, and I am {age} years old. My hair color is {hairColor}.");
            Console.WriteLine($"Currently, I am {activity}, and my hobby is {hobby}.");
        }
    }
}