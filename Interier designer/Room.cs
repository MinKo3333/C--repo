using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interier_designer
{
    internal class Room
    {
        public string Wallcolor {get;set;}
        public string Tiles { get; set; }
        public string Door { get; set; }
        public string Decoration_Items { get; set; }

        public Room(string wallcolor, string tiles, string door, string decoration_Items)
        {
            Wallcolor = wallcolor;
            Tiles = tiles;
            Door = door;
            Decoration_Items = decoration_Items;
        }

        public Room() { }
    

    }
}
