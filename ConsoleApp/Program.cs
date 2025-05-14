namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                text = text.ToLower();
                int countNum = 0;
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                    countNum++;
                }
                for (var i = 0; i < range; i++)
                {   
                    if(countNum == 0)
                    {
                        break;
                    }
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        int prosent =  counts[i] * 100 / countNum;
                        
                        int totalWidth = 120;

                        Console.WriteLine((character + " - " + prosent + "%").PadLeft(totalWidth));
                    }
                }
            }
        }
    }
}
