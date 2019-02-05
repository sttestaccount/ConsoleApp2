using System;
namespace maandag
{

    public class Monster
    {
        public string name { get; set; }
        public int currentHP { get; set; }
        public int currentHealth { get; set; }

        public Monster(String name)
        {
            this.name = name;
        }

    }
}

