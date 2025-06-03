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
        public string userId { get; private set; }
        public string password { get; private set; }

        public Profile CurrentUser { get; set; }

        public List<Profile> friendList { get; set; }

        public Profile()
        {

        }

        public Profile(string login)
        {
            CurrentUser = Login.CurrentUser;
        }

        public Dictionary<string,Profile> users { get; private set; } = new Dictionary<string,Profile>(); // 시스템내 전체 유저리스트

        public void Load()
        {
            string allUser = File.ReadAllText($"C:\\Users\\Princess Ko\\Desktop\\C--repo\\Social Media\\data\\users.json");

            if (string.IsNullOrWhiteSpace(allUser))
            {
                users = new Dictionary<string, Profile>();
            }

            else
            {
                users = JsonSerializer.Deserialize<Dictionary<string, Profile>>(allUser) ??
                                new Dictionary<string, Profile>();
            }
        }

        public void AddFriend()
        {

            Console.WriteLine("Write userId");
            string userid = Console.ReadLine();

            if (users.ContainsKey(userid) == false)
            {
                Console.WriteLine("Can't find the user");
                return;
            }

            Profile friendToAdd = users[userid]; // 해당 유저 찾아서 친구추가할 프로필 임시저장

            users[CurrentUser.userId].friendList.Add(friendToAdd);
            Console.WriteLine($"{friendToAdd.name} is added");
        }

        public void removeFriend()
        {
            Console.WriteLine("Write user id of the friend that you want to get rid of from your friend list ");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You can't leave this field empty.");
                removeFriend();
            }

            Profile theFriend = CurrentUser.friendList.Find(user => user.name == name);
            CurrentUser.friendList.Remove(theFriend);
           

        }

        public Profile CreateUser() //유저 생성 후 json에 저장
        {
            Console.WriteLine("Write \n" +
                              "name/age/job/work or school name/id/password");
            string answer = Console.ReadLine();
            Profile newUser = new Profile();

            string[] userInfo = answer.Split('/');
            newUser.name = userInfo[0];
            newUser.age = int.Parse(userInfo[1]);
            newUser.job = userInfo[2];
            newUser.workOrSchool = userInfo[3];
            newUser.userId = userInfo[4];
            newUser.password = userInfo[5];

            if (users.ContainsKey(newUser.userId))
            {
                Console.WriteLine("user already exist.");
                return null;
            }

            users.Add(newUser.userId, newUser);


            string json = JsonSerializer.Serialize(users);

            File.WriteAllText($"C:\\Users\\Princess Ko\\Desktop\\C--repo\\Social Media\\data\\users.json", json);

            return newUser;
        }



    }
}
