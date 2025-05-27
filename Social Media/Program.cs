using System.Reflection.Metadata;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Social_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Friend Face!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");

            var profile = new Profile();

            Profile mainUser = new Profile
            {
                name = name,
                age = 0,
                job = "",
                workOrSchool = ""
            };
      
            List<Profile> users = profile.LoadJson();// 파일 불러오기


            while (true)
            {
               
                Console.WriteLine("Choose what you want to do\n" +
                                  "1. show my friends\n" +
                                  "2. add a friend\n" +
                                  "3. remove a friend\n" +
                                  "4. close");

            int answer = getAnswer(); // 사용자로부터 뭐할지 받기

            users = run(answer, users); // 알고리즘 돌리기
             Console.WriteLine(string.Empty.PadLeft(30,'*'));
            }
        }

        static int getAnswer()
        {
            int answer = 0;
            bool result = int.TryParse(Console.ReadLine(), out answer);

            while (result == false || answer > 5 || answer < 1)
            {
                Console.WriteLine("Invalid answer");
                result = int.TryParse(Console.ReadLine(), out answer);
            }
            return answer;
        }


        static List<Profile> run(int answer, List<Profile> users)
        {
            var function = new functions();
            switch (answer)
            {
                case 1:
                    Console.Clear();
                    int usernumber = 1;
                    foreach (var user in users)
                    {
                        Console.WriteLine($"{usernumber}. name: {user.name}");
                        usernumber++;
                    }
                    Console.WriteLine("If you want to see more information about your friend, please type the number in front of your friend's name");
                    int index = 0;
                    int.TryParse(Console.ReadLine(),out index);
                    if (index == 0 || index> users.Count || index< 0)
                    {
                        Console.WriteLine("Invalid answer");
                        run(1, users);
                    }
                    Console.Clear();
                    Console.WriteLine($"name :{users[index-1].name}\n" +
                                      $"age :{users[index - 1].age}\n" +
                                      $"job: {users[index - 1].job}\n" +
                                      $"name of work or school: {users[index - 1].workOrSchool}");
                    break;

                case 2:
                    Console.Clear();
                    users = function.AddFriend(users);
                    break;

                case 3:
                    Console.Clear();
                    users = function.removeFriend(users);
                    break;

                case 4:
                    bool loop = true;
                    string json = JsonSerializer.Serialize(users);
                    File.WriteAllText("C:\\Users\\Princess Ko\\Desktop\\C--repo\\Social Media\\users.json", json);
                    Environment.Exit(0);
                    break;
            }

            return users;
        }


    }
}
