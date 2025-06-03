using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Social_Media;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Social_Media
{
    internal class Social_Media
    {
        public void welcome(Dictionary<string, Profile> users, Profile profile)
        {
            bool leave = false;

            while (leave == false)
            {

                Console.WriteLine("Velkommen til Friend Face!\n" +
                                  "1. if you are already Friend Face member \n" +
                                  "2. if you want to sign up");
                int num = 0;
                bool answer1 = int.TryParse(Console.ReadLine(), out num);


                while (answer1 == false)
                {
                    Console.WriteLine("Invalid answer");
                    break;
                }

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Please write your id and password (example : yourid/password)");
                        string answer2 = Console.ReadLine();

                        if (!answer2.Contains('/'))
                        {
                            Console.WriteLine("invalid answer");
                            break;
                        }

                        string[] answer = answer2.Split('/');
                        Login currentUser = new Login(answer[0], answer[1], users); // currentUser 로그인하고 세팅하기
                        leave = true;
                        break;

                    case 2:
                        Profile newUser = profile.CreateUser();
                        List<Profile> dummy = new List<Profile>();
                        break;
                    case 0:
                        break;

                }
            }
        }

        public void MainPage(Profile profile)
        {
            while (true)
            {
                Console.WriteLine("Choose what you want to do\n" +
                                  "0. show my information\n" +
                                  "1. show my friends\n" +
                                  "2. add a friend\n" +
                                  "3. remove a friend\n" +
                                  "4. close");

                int answer2 = getAnswer(); // 사용자로부터 뭐할지 받기

                Run(profile,answer2); // 알고리즘 돌리기
                Console.WriteLine(string.Empty.PadLeft(30, '*'));
            }
           
        }

        int getAnswer()
        {
            int answer = 0;
            bool result = int.TryParse(Console.ReadLine(), out answer);

            while (result == false || answer > 5 || answer < 0)
            {
                Console.WriteLine("Invalid answer");
                result = int.TryParse(Console.ReadLine(), out answer);
            }

            return answer;
        }


        void Run(Profile profile,int answer)
        {
            switch (answer)
            {
                case 1:
                    Console.Clear();

                    int usernumber = 1;
                    foreach (var friend in profile.CurrentUser.friendList)
                    {
                        Console.WriteLine($"{usernumber}. name: {friend.name}");
                        usernumber++;
                    }

                    Console.WriteLine(
                        "If you want to see more information about your friend, please type the number in front of your friend's name");

                    if (profile.CurrentUser.friendList.Count == 0)
                    {
                        Console.WriteLine("You don't have any friends.");
                        break;
                    }

                    int index = 0;
                    int.TryParse(Console.ReadLine(), out index);

                    while (index == 0 || index > profile.CurrentUser.friendList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid answer");
                        Console.WriteLine(
                            "If you want to see more information about your friend, please type the number in front of your friend's name");
                        int.TryParse(Console.ReadLine(), out index);
                    } //이상한 값 넣었을 때

                    Console.Clear();
                    Console.WriteLine($"name :{profile.CurrentUser.friendList[index - 1].name}\n" +
                                      $"age :{profile.CurrentUser.friendList[index - 1].age}\n" +
                                      $"job: {profile.CurrentUser.friendList[index - 1].job}\n" +
                                      $"name of work or school: {profile.CurrentUser.friendList[index - 1].workOrSchool}");

                    break;

                case 2:
                    Console.Clear();
                    profile.AddFriend();
                    break;

                case 3:
                    Console.Clear();
                    profile.removeFriend();
                    break;

                case 4:
                    bool loop = true;
                    string json = JsonSerializer.Serialize(profile.users);
                    File.WriteAllText("C:\\Users\\Princess Ko\\Desktop\\C--repo\\Social Media\\users.json", json);
                    Environment.Exit(0);
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine($"name:{profile.CurrentUser.name}\n" +
                                      $"age:{profile.CurrentUser.age}\n" +
                                      $"job:{profile.CurrentUser.job}\n" +
                                      $"work or school name:{profile.CurrentUser.workOrSchool}\n" +
                                      $"user ID: {profile.CurrentUser.userId}\n" +
                                      $"password: {profile.CurrentUser.password}");
                    break;
                default:
                    Console.WriteLine("Invalid answer");
                    break;
            }

        }
    }
}

