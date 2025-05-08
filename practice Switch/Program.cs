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
            var rand = new Random();
            int randomNumber = rand.Next(1, 8);
            string day = ""; 

                switch(randomNumber)
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
            string answer = $"{randomNumber} is {day}";
            return answer;
            
        }
 
    }
}
