using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Application
{
    internal interface ICar
    {
        string Name { get; }
        int Weight { get; }
        string Color { get; }
        int HorsePowers { get; }

        public void ShowInfo();
    }
}
