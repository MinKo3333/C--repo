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
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string WorkOrSchool { get; set; }
        public string UserId { get; private set; }
        public string Password { get; private set; }

        
        public List<Profile> friendList { get; set; }

        public Profile(string name, int age, string job, string workOrSchool, string userId, string password)
        {
            Name = name;
            Age = age;
            Job = job;
            WorkOrSchool = workOrSchool;
            UserId = userId;
            Password = password;
        }

        
    }
}
