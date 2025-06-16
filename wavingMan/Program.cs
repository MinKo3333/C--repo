using WavingMan;

namespace wavingMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           WavingMan.WavingMan wavingman1 = new WavingMan.WavingMan(3,5);
           WavingMan.WavingMan wavingman2 = new WavingMan.WavingMan(8, 5);
           LeftHandWaver wavingman3 = new LeftHandWaver(12, 5);
            while (true)
           {    
               Console.Clear();
               wavingman1.Wave();
               wavingman1.Show();
               wavingman2.Wave();
               wavingman2.Show();
               wavingman3.Wave();
               wavingman3.Show();
               Thread.Sleep(1000);

           }
           
        }
    }
}
