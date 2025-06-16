using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_control_system
{
    internal class Circle : Shape
    {
        private int Radius;

        public Circle(string name, string color, int radius) : base(name, color)
        {
            Radius = radius;
        }

        public override int BeregnAreal()
        {
            double areal = Radius * Radius * Math.PI;
            return (int)areal;
        }

        //public override string ToString()
        //{
        //    return $"{Name},{Color},{BeregnAreal()}cm²";
        //}
    }
}
