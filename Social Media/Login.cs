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
        public Profile CurrentUser { get; private set; }

        public Login(string userId,string password,Dictionary<string,Profile> users)
        {
            

            switch (users.ContainsKey(userId))
            {
                case false:
                    Console.WriteLine("Invalid Id");
                    break;

                case true:

                    CurrentUser = users[userId];
                    switch (password == CurrentUser.Password)
                    {
                        case false:
                            Console.WriteLine("Invalid password");
                            break;
                        case true:
                            Current_User.CurrentUser = CurrentUser; // 로그인 성공시 현재 유저 프로필 세팅
                            break;
                    } 
                    break;
            }
        }
            
        




    }
}
