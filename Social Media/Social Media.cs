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
        public void welcome(Dictionary<string, Profile> users, Data_Handling forFunction)
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
                        Profile newUser = forFunction.CreateUser();
                        List<Profile> dummy = new List<Profile>();
                        break;
                    case 0:
                        
                        break;

                }
            }
        }

        public void MainPage(Profile profile,Data_Handling forFunction)
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

                Run(Current_User.CurrentUser,answer2,forFunction); // 알고리즘 돌리기
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


        void Run(Profile profile,int answer,Data_Handling dataHandling)
        {
            switch (answer)
            {
                case 1:
                    Console.Clear();

                    int usernumber = 1;
                    foreach (var friend in profile.friendList)
                    {
                        Console.WriteLine($"{usernumber}. name: {friend.Name}");
                        usernumber++;
                    }

                    Console.WriteLine(
                        "If you want to see more information about your friend, please type the number in front of your friend's name");

                    if (profile.friendList.Count == 0)
                    {
                        Console.WriteLine("You don't have any friends.");
                        break;
                    }

                    int index = 0;
                    int.TryParse(Console.ReadLine(), out index);

                    while (index == 0 || index > profile.friendList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid answer");
                        Console.WriteLine(
                            "If you want to see more information about your friend, please type the number in front of your friend's name");
                        int.TryParse(Console.ReadLine(), out index);
                    } //이상한 값 넣었을 때

                    Console.Clear();
                    Console.WriteLine($"name :{profile.friendList[index - 1].Name}\n" +
                                      $"age :{profile.friendList[index - 1].Age}\n" +
                                      $"job: {profile.friendList[index - 1].Job}\n" +
                                      $"name of work or school: {profile.friendList[index - 1].WorkOrSchool}");

                    break;

                case 2:
                    Console.Clear();
                    dataHandling.AddFriend();
                    break;

                case 3:
                    Console.Clear();
                    dataHandling.removeFriend();
                    break;

                case 4:
                    bool loop = true;
                    string json = JsonSerializer.Serialize(dataHandling.users);
                    File.WriteAllText("C:\\Users\\Princess Ko\\Desktop\\C--repo\\Social Media\\users.json", json);
                    Environment.Exit(0);
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine($"name:{Current_User.CurrentUser.Name}\n" +
                                      $"age:{Current_User.CurrentUser.Age}\n" +
                                      $"job:{Current_User.CurrentUser.Job}\n" +
                                      $"work or school name:{Current_User.CurrentUser.WorkOrSchool}\n" +
                                      $"user ID: {Current_User.CurrentUser.UserId}\n" +
                                      $"password: {Current_User.CurrentUser.Password}");
                    break;
                default:
                    Console.WriteLine("Invalid answer");
                    break;
            }

        }
    }
}

