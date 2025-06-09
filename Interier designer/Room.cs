using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interier_designer
{
    internal class Room
    {
        public string Wallcolor { get; private set;}
        public string Tiles { get; private set; }
        public string Door { get; private set; }
        public string Decoration_Items { get; private set; }

        public Room(string wallcolor, string tiles, string door, string decoration_Items)
        {
            Wallcolor = wallcolor;
            Tiles = tiles;
            Door = door;
            Decoration_Items = decoration_Items;
        }

        public void setRoomDeco(string item)
        {
            Decoration_Items = item;
        }
        public void setRoomWallcolor(string color)
        {
            Wallcolor = color;
        }

        public void setRoomTile(string tile)
        {
            Tiles = tile;
        }

        public void setDoor(string door)
        {
            Door = door;
        }
    }
}
