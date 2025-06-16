using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_control_system
{
    internal class Triangle : Shape
    {
        private int width;
        private int height;

        public Triangle(string name, string color, int width,int height) : base(name, color)
        {
            this.width = width;
            this.height = height;
        }

        public override int BeregnAreal()
        {
            double areal = width * height * 0.5;
            return (int)areal ;
        }
    }
}
