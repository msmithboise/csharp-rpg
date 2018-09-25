using System;
using System.Collections.Generic;
using csharp_login.Models;

namespace csharp_login
{
    class Program
    {
        private const string Value = "Welcome!";

        static void Main(string[] args)
        {

            Dictionary<string, User> users = new Dictionary<string, User>(){
                { "mark", new User("mark", "IHeartCode")},
                { "jake", new User("jake", "MarkRocks")}
            };

            // how to register new user
            User dmoney = new User("d$", "DeMoneyMoMoney");
            users.Add(dmoney.Username, dmoney);







            Console.Clear();
            Console.WriteLine("Please login to continue");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (users.ContainsKey(username) && users[username].ValidatePassword(password))
            {
                // users at username.ValidatePassword method we created, passing password property

                System.Console.WriteLine("SUCCESS!!!!");

            }
            else
            {
                System.Console.WriteLine("INVALID USERNAME OR PASSWORD!");
            }



        }
    }
}
