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
            var profile = new Profile();
            var socialMedia = new Social_Media();

            profile.Load(); // 유저리스트 불러오기
            socialMedia.welcome(profile.users,profile);
            Console.Clear();
            Console.WriteLine($"Hello, {Login.CurrentUser.name}");
            socialMedia.MainPage(profile);

        }


    }
}
