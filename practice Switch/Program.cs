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
            int number;

            if (string.IsNullOrWhiteSpace(Value)) // empty check
            {
                Console.WriteLine("Please enter a number between 1 to 7");
         
                return WhichDay();
                
            }
          
           

            if(!int.TryParse(Value, out number)) // parse check
            {
               Console.WriteLine("Please enter a number between 1 to 7");
              
                return WhichDay();
             }

            if (number < 1 || number > 7) // range check
            {
                Console.WriteLine("Please enter a number between 1 to 7");
          
                return WhichDay();
            }

            number = int.Parse(Value) ;

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
