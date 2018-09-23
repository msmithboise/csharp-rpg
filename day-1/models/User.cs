namespace day_1.Models
{

    public class User
    {   //accessor  datatype name of variable
        // this is called a field.
        public string Name { get; set; }
        public int Age { get; private set; }
        public bool IsAlive { get; set; }

        public void Birthday()
        {
            Age++;
        }


        public string GetStringAge()
        {
            return Age.ToString();

        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            IsAlive = true;
        }
    }


}