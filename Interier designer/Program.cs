using System.Diagnostics.SymbolStore;

namespace Interier_designer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int answer = 0;
            Room currentRoom = new Room();


            Oppussing oppussing = new Oppussing();
            Dictionary<string,Room> rooms = new Dictionary<string,Room>();
            Room bathRoom = new Room("none", "none", "none", "none");
            Room Kitchen = new Room("none", "none", "none", "none");
            Room livingRoom = new Room("none", "none", "none", "none");

            rooms.Add("bathRoom", bathRoom);
            rooms.Add("Kitchen", Kitchen);
            rooms.Add("livingRoom", livingRoom);

            Console.Write("Velkommen! Hvilken room ønsker du å pusse opp?\n" +
                          "Velg room");
            foreach (var room in rooms)
            {
                Console.WriteLine($"{num}. {room.Key}");
                num++;
            }

            answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1: currentRoom = bathRoom;
                    break;
                case 2:
                    currentRoom = Kitchen;
                    break;
                case 3:
                    currentRoom = livingRoom;
                    break;
            }

            Console.WriteLine("Hva ønsker du å jobbe med?\n" +
                              "1. Paint\n" +
                              "2. put tiles\n");
            
            bool Valid = true;
            do
            {
                Valid = int.TryParse(Console.ReadLine(),out answer);
                if (Valid == false)
                {
                    Console.WriteLine("Invalid answer");
                }
            } 
            while (Valid == false);


            if (answer == 1)
            {
                oppussing.Paint(currentRoom);
            }

            else 
            {
                oppussing.PutTiles(currentRoom);
            }


        }
        }
    }

