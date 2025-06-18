using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_control_system
{
    internal abstract class Shape
    {
        public string Name { get; protected set;}
        public string Color { get; protected set; }
        public int? areacache { get; protected set; }
        public int Area {
            get {
                if (areacache == null)
                {
                    areacache = BeregnAreal();
                }

                return areacache.Value;
            }
            protected set { areacache = value; }

        }

        protected Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public virtual int BeregnAreal()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{Name},{Color},{BeregnAreal()}cm²";
        }





    }
}
