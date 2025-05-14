namespace TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ref = new Program();
            Console.WriteLine("Write your word between 1 and 9 characters");
            string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Please write a word");
                Main(args);
            }
            if (text.Length<1 || text.Length>10)   
            {
                Console.WriteLine("Please write a word between 1 and 9 characters");
                Main(args);
            }

            Console.WriteLine("Choose What you want to do with the word \n" +
                "1.Write the word in reverse order \n" +
                "2. Turn all 'E' to 'A'");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                string newText = Ref.RotateText(text);
                Console.WriteLine($"The word in reverse order is: {newText}");
            }

            else if (answer == 2)
            {
                string newText = Ref.ReplaceEtoA(text);
                Console.WriteLine($"The word with all 'E' replaced with 'A' is: {newText}");
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
                Main(args);
            }

        }

        public string RotateText(string text)
        {   
            char[] theWord = text.ToCharArray();
            for (int i = 0; i < theWord.Length; i++)
            {
                theWord[i] = text[text.Length - 1 - i];

            }

            string newText = new string(theWord);
            return newText;
        }

        public string ReplaceEtoA(string text)
        {
            string newText = text.Replace("e", "a");
            return newText;
        }
    }
}
