using System.Diagnostics.SymbolStore;

namespace Interier_designer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myhouse = new House();
            var view = new View();

            myhouse.startSetting();
            view.chooseRoom(myhouse);
            view.workFlow(myhouse);

        }
        }
    }

