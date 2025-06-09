using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interier_designer
{
    internal class View
    {

        int num = 1;
        int answer = 0;

        Construction construction = new Construction();


        public void chooseRoom(House house)
        {
            Console.Write("Velkommen! Hvilken room ønsker du å pusse opp?\n" +
                          "Velg room\n");
            foreach (var room in house.rooms)
            {
                Console.WriteLine($"{num}. {room.Key}");
                num++;
            }

            answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    house.setCurrentRoom("bathRoom");
                    break;
                case 2:
                    house.setCurrentRoom("Kitchen");
                    break;
                case 3:
                    house.setCurrentRoom("livingRoom");
                    break;
            }
        }

        public void workFlow(House house)
        {
            Console.WriteLine("Hva ønsker du å jobbe med?\n" +
                              "1. Paint\n" +
                              "2. put tiles\n");

            bool Valid = true;
            do
            {
                Valid = int.TryParse(Console.ReadLine(), out answer);
                if (Valid == false)
                {
                    Console.WriteLine("Invalid answer");
                }
            }
            while (Valid == false);


            if (answer == 1)
            {
                construction.Paint(house);
            }

            else
            {
                construction.PutTiles(house);
            }
        }
    


}
}
