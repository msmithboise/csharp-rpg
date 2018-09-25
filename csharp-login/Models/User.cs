using System.Collections.Generic;

namespace csharp_login.Models
{

    public class User
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public bool ValidatePassword(string password)
        {
            return password == Password;
        }



        public User(string name, string pass)  // constructor
        {
            Username = name;
            Password = pass;
        }








    }
}