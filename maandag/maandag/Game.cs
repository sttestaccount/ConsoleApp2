using System;
namespace maandag
{
    public class Game
    {

        public static void MoveDecision()
        {
            string choice;

            Console.WriteLine("You can choose which way to go:");
            Console.WriteLine("Press 'N' for North");
            Console.WriteLine("Press 'S' for South");
            Console.WriteLine("Press 'W' for West");
            Console.WriteLine("Press 'E' for East");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            MonsterSpawner();
        }

        public static void MonsterSpawner()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 3);

            if (random = 1)
            {
                Monster monstertje = new Monster("karbonkel");
                monstertje.currentHP = 100;
                monstertje.currentHealth = 100;
            }
            if (random = 2)
            {
                Monster monstertje = new Monster("ex-gf");
                monstertje.currentHP = 200;
                monstertje.currentHealth = 200;
            }
            if (random = 3)
            {
                Monster monstertje = new Monster("policeman");
                monstertje.currentHP = 50;
                monstertje.currentHealth = 50;
            }
          
        }

    }
        }


//        }
//            else if (Random.value => (2 / 3))
//            {
//                Monster(string name, int level, int currentHP, int maximumHP; int currentHealth; int maxHealth);
//                {
//                    this.name = "BOSS B;
//                    this.currentHP = currentHP;
//                    this.maximumHP = maximumHP;
//                    this.currentHealth = currentHealth;
//                    this.maxHealth = maxHealth;
//                }
//                // statements executed if boolean-expression-2 is true
//            } }
//            else if (Random.value =< (1 / 3))
//            {
//                Monster(string name, int level, int currentHP, int maximumHP; int currentHealth; int maxHealth);
//                {
//                    this.name = "BOSS C";
//                    this.currentHP = currentHP;
//                    this.maximumHP = maximumHP;
//                    this.currentHealth = currentHealth;
//                    this.maxHealth = maxHealth;
//                }
//                // statements executed if boolean-expression-3 is true
//            }
//        }
//    }
//}

         //if (Random.value > 0.2) //%80 percent chance (1 - 0.2 is 0.8)
         //{ //code here
         //}

//if (Random.value > 0.7) //%30 percent chance (1 - 0.7 is 0.3)
//{ //code here
//}

