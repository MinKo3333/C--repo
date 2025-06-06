using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace Social_Media
{
    internal class Data_Handling
    {
        public Profile CurrentUser { get;  set; } // 현재 로그인된 유저 프로필 정보
        public Dictionary<string, Profile> users { get; private set; } = new Dictionary<string, Profile>(); // 시스템내 전체 유저리스트

        public Data_Handling()
        {
            CurrentUser = Current_User.CurrentUser;
        }

        public void Load()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string filePath = Path.Combine(folderPath, "users.json");
            string allUser = File.ReadAllText(filePath);

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

            users[friendToAdd.UserId].friendList.Add(Current_User.CurrentUser);
            users[Current_User.CurrentUser.UserId].friendList.Add(friendToAdd);
            Console.WriteLine($"{friendToAdd.Name} is added");

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

            Profile theFriend = CurrentUser.friendList.Find(user => user.Name == name);
            CurrentUser.friendList.Remove(theFriend);


        }

        public Profile CreateUser() //유저 생성 후 json에 저장
        {
            Console.WriteLine("Write \n" +
                              "name/age/job/work or school name/id/password");
            string answer = Console.ReadLine();

            string[] userInfo = answer.Split('/');

            Profile newUser = new Profile(userInfo[0], int.Parse(userInfo[1]), userInfo[2], userInfo[3], userInfo[4], userInfo[5]);

            if (users.ContainsKey(newUser.UserId))
            {
                Console.WriteLine("user already exist.");
                return null;
            }

            users.Add(newUser.UserId, newUser);
            newUser.friendList = new List<Profile>();
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string filePath = Path.Combine(folderPath, "users.json");
            string json = JsonSerializer.Serialize(users);

            File.WriteAllText(filePath, json);

            return newUser;
        }
    }
}
