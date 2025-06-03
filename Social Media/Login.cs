using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Social_Media
{
    internal class Login
    {   
        public static Profile CurrentUser { get; private set; }

        public Login(string userId,string password,Dictionary<string,Profile> users)
        {   
            
            switch (users.ContainsKey(userId))
            {
                case false:
                    Console.WriteLine("Invalid Id");
                    break;

                case true:

                    CurrentUser = users[userId];
                    switch (password == CurrentUser.password)
                    {
                        case false:
                            Console.WriteLine("Invalid password");
                            break;
                        case true:
                            break;
                    } 
                    break;
            }

        }
            
        




    }
}
