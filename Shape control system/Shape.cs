using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_control_system
{
    internal abstract class Shape
    {
        private protected string Name;
        protected string Color;

        protected Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public virtual int BeregnAreal() 
        {
           int areal = 0;
           return areal;
        }

        public override string ToString()
        {
            return $"{Name},{Color},{BeregnAreal()}cm²";
        }

    }
}
