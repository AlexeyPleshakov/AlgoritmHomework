using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public static void Greetings(List<User> users)
        {
            foreach (var user in users)
            {
                if (user.IsPremium)
                {
                    Console.WriteLine($"Hello, {user.Name}");
                }
                else
                {
                    Console.WriteLine($"Hello, {user.Name}");
                    Program.ShowAds();
                }
            }
        } 
    }
}
