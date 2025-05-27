using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Social_Media
{
    internal class functions
    {   
        public List<Profile> AddFriend(List<Profile> profiles)
        {
            List<Profile> profile = profiles;

            Console.WriteLine("Write name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You can't leave this area empty.");
               return AddFriend(profile);
            }

            Console.WriteLine("Write age");
            string age = Console.ReadLine();
            if (string.IsNullOrEmpty(age))
            {
                Console.WriteLine("You can't leave this area empty. Start again.");
                return AddFriend(profile);
            }
            Console.WriteLine("Write job");
            string job = Console.ReadLine();
            if (string.IsNullOrEmpty(job))
            {
                Console.WriteLine("You can't leave this area empty. Start again.");
                return AddFriend(profile);
            }
            Console.WriteLine("Write School or work name");
            string workOrSchool = Console.ReadLine();
            if (string.IsNullOrEmpty(workOrSchool))
            {
                Console.WriteLine("You can't leave this area empty. Start again.");
                return AddFriend(profile);
            }

            Profile newUser = new Profile
            {
                name = name,
                age = int.Parse(age),
                job= job,
                workOrSchool= workOrSchool
            };

            profile.Add(newUser);
            return profile;
        }

        public List<Profile> removeFriend(List<Profile> profiles)
        {
            List<Profile> profile = profiles;
            Console.WriteLine("Write name of the friend that you want to get rid of from friend list ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("invalid answer");
                removeFriend(profile);
            }

            Profile theFriend = profile.Find(user => user.name == name);
            profile.Remove(theFriend);

            return profile;
        }
    }
}
