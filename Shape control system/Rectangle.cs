using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_control_system
{
    internal class Rectangle : Shape
    {
        int Length;
        int Width;

        public Rectangle(string name, string color, int length, int width) : base(name, color)
        {
            Length = length;
            Width = width;
        }

        public override int BeregnAreal()
        {
            double areal = Length * Width;
            return (int)areal;
        }
    }
}
