using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Social_Media
{
    internal class Profile
    {
        public string name { get; set; }
        public int age { get; set; }
        public string job { get; set; }
        public string workOrSchool { get; set; }

        public List<Profile> users { get; set; } = new List<Profile>();
        public List<Profile> LoadJson()
        {
            string jsonString = File.ReadAllText("C:\\Users\\Princess Ko\\Desktop\\C--repo\\Social Media\\users.json");
            List<Profile> users = JsonSerializer.Deserialize<List<Profile>>(jsonString);


            return users;
        }




    }
}
