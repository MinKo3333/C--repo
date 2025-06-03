using System.Numerics;
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
            var socialMedia = new Social_Media();
            var dataHandling = new Data_Handling();

            dataHandling.Load(); // 유저리스트 불러오기
            socialMedia.welcome(dataHandling.users,dataHandling);
            Console.Clear();
            Console.WriteLine($"Hello, {Login.CurrentUser.Name}");
            socialMedia.MainPage(Current_User.CurrentUser,dataHandling);

        }


    }
}
