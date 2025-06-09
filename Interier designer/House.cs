using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interier_designer
{
    internal class House
    {
        public Dictionary<string, Room> rooms { get; private set; }
        public Room currentRoom { get; private set; }

        public House()
        {
            rooms = new Dictionary<string, Room>();
            currentRoom = new Room("none", "none", "none", "none");
        }
        public void startSetting()
        {
            Room bathRoom = new Room("none", "none", "none", "none");
            Room Kitchen = new Room("none", "none", "none", "none");
            Room livingRoom = new Room("none", "none", "none", "none");

            addRooms("bathRoom", bathRoom);
            addRooms("Kitchen", Kitchen);
            addRooms("livingRoom", livingRoom);
        }

        public void setCurrentRoom(string name)
        {
            rooms.TryGetValue(name, out Room thisRoom);
            currentRoom = thisRoom;
        }

        public void addRooms(string key, Room room)
        {
            rooms.Add(key, room);
        }

        
    }
}
