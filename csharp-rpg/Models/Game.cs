namespace csharp_rpg.Models
{

    public class Hero
    {

        public string Explore { get; set; }
        public string Attack { get; set; }

        public Hero(string explore, string attack)
        {

            Attack = attack;
            Explore = explore;


        }
    }








}