using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interier_designer
{
    internal class Oppussing
    {   
        public List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "White", "Black" };
        public List<string> tiles = new List<string> { "Marble", "Checker Board", "Black and white"};
        public void Paint(Room room) { 

            Console.WriteLine("What color do you want to paint the room? (Red, Blue, Green, Yellow, White, Black)");
            string answer =  Console.ReadLine().ToLower();
            switch (answer) {

                case "red": 
                    room.Wallcolor = colors[0];
                    break;
                case "blue":
                    room.Wallcolor = colors[1];
                    break;
                case "green":
                    room.Wallcolor = colors[2];
                    break;
                case "yellow":
                    room.Wallcolor = colors[3];
                    break;
                case "white":
                    room.Wallcolor = colors[4];
                    break;
                case "black":
                    room.Wallcolor = colors[5];
                    break;
            }            

        }

        public void PutTiles(Room room)
        {

            Console.WriteLine("Which tile do you want to have on the floor? (Red, Blue, Green, Yellow, White, Black)");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {

                case "marble":
                    room.Tiles = tiles[0];
                    break;
                case "checker board":
                    room.Tiles = tiles[1];
                    break;
                case "black and white":
                    room.Tiles = tiles[2];
                    break;

            }

        }
    }
}
