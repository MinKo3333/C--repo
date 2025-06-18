namespace PP6;

class Program
{
    static void Main(string[] args)
    {
        List<Bug> bugs = new List<Bug>
        {
            new Mosquito(),
            new House_Flies(),
            new Spider(),
            new Tick(),
            new Wasp()
        };
        
        while(true)
        { 
            int num = 1;
            foreach (var bug in bugs)
            {
                Console.WriteLine(num+". "+bug.GetName());
                num++;
            }

            Console.WriteLine("Press index of the insect to see more information.");
            
            try
            {
                int answer = int.Parse(Console.ReadLine());
                Console.WriteLine(bugs[answer-1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();
            Console.Clear();
        }
        



    }
}