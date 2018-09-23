using System;
using System.Collections.Generic;
using day_1.Models;

namespace day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Console.Clear();
            List<string> choices = new List<string>();
            Dictionary<string, string> dictionaryChoices = new Dictionary<string, string>();
            dictionaryChoices.Add("rock", "paper");

            while (playing)
            {
                Console.WriteLine("Hello what is your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Oh hello {name}");
                if (name != null && name.ToLower() == "mark")
                {
                    Console.WriteLine("Whats up doc!?");
                }
                Console.WriteLine("How old are you?");
                string myAgeString = Console.ReadLine();
                int age;
                if (!Int32.TryParse(myAgeString, out age))
                {
                    Console.WriteLine("Bad Input!");
                    return;
                }
                Console.WriteLine($"Cool! Did you know in 10 years you will be {age + 10}");
                User user = new User(name, age);
                Console.WriteLine($"Anywho I made a user object with the name {user.Name}, and the age {user.Age}");
                System.Console.WriteLine("Wait.... I forgot? Will you tell me again? (Y/N)");
                string response = Console.ReadLine();
                if (response.ToUpper() != "Y")
                {
                    playing = false;
                }
            };
        }
    }
}