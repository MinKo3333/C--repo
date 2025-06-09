using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interier_designer
{
    internal class Construction
    {   
        public Dictionary<string,string> colors = new Dictionary<string, string>
        {
            {"red","Red"},
            {"blue","Blue"},
            {"green","Green"},
            {"yellow", "Yellow"},
            {"white", "White"},
            {"black", "Black"}
        };
        public List<string> tiles = new List<string> { "Marble", "Checker Board", "Black and white"};

        public void Paint(House house) { 

            Console.WriteLine("What color do you want to paint the room? (Red, Blue, Green, Yellow, White, Black)");
            string answer =  Console.ReadLine().ToLower();

            house.currentRoom.setRoomWallcolor(colors[answer]);

        }

        public void PutTiles(House house)
        {

            Console.WriteLine("Which tile do you want to have on the floor? Marble, Checker Board, Black and white");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {

                case "marble":
                    house.currentRoom.setRoomTile(tiles[0]);
                    break;
                case "checker board":
                    house.currentRoom.setRoomTile(tiles[1]);
                    break;
                case "black and white":
                    house.currentRoom.setRoomTile(tiles[2]);
                    break;

            }
            ViewRoomInfo(house);

        }

        public void ViewRoomInfo(House house)
        {
            Console.WriteLine($"Tile: {house.currentRoom.Tiles}");
            Console.WriteLine($"Door: {house.currentRoom.Door}");
            Console.WriteLine($"Color: {house.currentRoom.Wallcolor}");
            Console.WriteLine($"Decoration Items: {house.currentRoom.Decoration_Items}");

        }
    }
}
