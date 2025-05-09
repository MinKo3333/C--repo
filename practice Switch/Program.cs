using System.CodeDom.Compiler;

namespace practice_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Generated = new Program();
           Console.WriteLine(Generated.WhichDay());
        }

        public string WhichDay()
        {
            //var rand = new Random();
            //int randomNumber = rand.Next(1, 8);
            string Value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Value)) // empty check
            {
                return "Please enter a number between 1 to 7";
            }
          
            int number;

            if(!int.TryParse(Value, out number)) // parse check
            {
                return "Please enter a number between 1 to 7";
            }

            if (number < 1 || number > 7) // range check
            {
                return "Please enter a number between 1 to 7";
            }

            string day = ""; 

                switch(number)
            {
                case 1: day = "Monday";
                    break;
                case 2: day = "Tuesday";
                    break;
                case 3: day = "Wednesday";
                    break;
                case 4: day = "Thursday";
                    break;
                case 5: day = "Friday";
                    break;
                case 6: day = "Saturday";
                    break;
                case 7: day = "Sunday";
                    break;
            }
            string answer = $"{number} is {day}";
            return answer;
            
        }
 
    }
}
