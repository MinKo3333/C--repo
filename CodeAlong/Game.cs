using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Game 
    {
       public List<Hest> Deltaker = new List<Hest>
       {
           new Hest("wind",100),
           new Hest("Newyork",150)
       };

       public void Registere(Hest hest)
       {
           Deltaker.Add(hest);
           Console.WriteLine($"{hest.Navn} er registrert.");
       }

       public void RunGame()
       {
           while(Deltaker.All(hest => hest.km <= 3000))
           {
                foreach (var hest in Deltaker)
                {
                    hest.Run();
                    hest.PrintInfo();
                }

           }

           Hest winner = Deltaker.FirstOrDefault(hest => hest.km >= 3000);

           Console.WriteLine($"{winner.Navn} har vant!");

       }
    }
}
