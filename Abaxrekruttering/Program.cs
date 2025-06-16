using System.Security.Cryptography.X509Certificates;

namespace Abaxrekruttering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITransportation> transportations = new List<ITransportation>
            {
                new Car("NF123456",147,200,"green"),
                new Car("NF654321",150,195,"blue"),
                new Flight("LN1234",1000,30,2,10),
                new Ship("ABC123",100,30,500)
            };

            

            foreach (var t in transportations)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                t.PrintInfo();
                t.Run();
                Console.ResetColor();
                Console.WriteLine(String.Empty.PadLeft(40,'-'));
                
            }

            SameOrNot(transportations[0], transportations[1]);
        }

        public static void SameOrNot(ITransportation a, ITransportation b)
        {
            if (a.RegisteredNum == b.RegisteredNum)
            {
                Console.WriteLine("They are same vehicles.");
            }
            else
            {
                Console.WriteLine("They are not same.");
            }
        }
    }
}
