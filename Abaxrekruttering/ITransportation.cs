using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal interface ITransportation
    {
        string RegisteredNum { get; }
        int Effect { get; }
        string Type { get; }

        public void Run();

        public void PrintInfo();
    }
}
