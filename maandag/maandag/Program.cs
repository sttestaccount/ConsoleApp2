using System;
namespace maandag
{
   
   class TestSystem
    {
        static void Main(string[] args)
        {
            string naam = "Type your first name";
            string filename1 = "Then type your last name";
            Console.WriteLine(naam);
            Console.WriteLine(filename1);
            string inputfromuser = Console.ReadLine();
            string inputfromuser2 = Console.ReadLine();
            Console.WriteLine(@"   

 ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄    ▄▄▄▄███▄▄▄▄      ▄████████          ███      ▄██████▄       
███     ███   ███    ███ ███       ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███      ▀█████████▄ ███    ███      
███     ███   ███    █▀  ███       ███    █▀  ███    ███ ███   ███   ███   ███    █▀          ▀███▀▀██ ███    ███      
███     ███  ▄███▄▄▄     ███       ███        ███    ███ ███   ███   ███  ▄███▄▄▄              ███   ▀ ███    ███      
███     ███ ▀▀███▀▀▀     ███       ███        ███    ███ ███   ███   ███ ▀▀███▀▀▀              ███     ███    ███      
███     ███   ███    █▄  ███       ███    █▄  ███    ███ ███   ███   ███   ███    █▄           ███     ███    ███      
███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███ ███   ███   ███   ███    ███          ███     ███    ███      
 ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀   ▀█   ███   █▀    ██████████         ▄████▀    ▀██████▀       
                         ▀                                                                                             
    ███        ▄█    █▄       ▄████████         ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████                    
▀█████████▄   ███    ███     ███    ███        ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███                    
   ▀███▀▀██   ███    ███     ███    █▀         ███    █▀    ███    ███ ███   ███   ███   ███    █▀                     
    ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄           ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄                        
    ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀          ▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀                        
    ███       ███    ███     ███    █▄         ███    ███   ███    ███ ███   ███   ███   ███    █▄                     
    ███       ███    ███     ███    ███        ███    ███   ███    ███ ███   ███   ███   ███    ███                    
   ▄████▀     ███    █▀      ██████████        ████████▀    ███    █▀   ▀█   ███   █▀    ██████████                    

{0}.", inputfromuser);
            Console.WriteLine("You belong to house {0}", inputfromuser2);
            presstoBegin();
        }

        public static void presstoBegin()
        {
            Console.WriteLine("Press 'b' to begin.");
            string input3 = Console.ReadLine().ToLower();
            if (input3.Equals("b"))
            {
                Game.MoveDecision();
            }
            else
            {
                Console.WriteLine("tell me when you are ready");
                presstoBegin();
            }
        }





        //public Monster(string name)
        //{
        //    this.name = name;
        //    maximumHP = 100;
        //    currentHP = 100;
        //}


                //switch (R.Value)
                //{
                //    case 1: //Dungeon 1
                //        currentLocation = new Tuple<int, int>(5, 0);
                //        break;
                //    case 2: //Dungeon 2
                //        currentLocation = new Tuple<int, int>(0, 0);
                //        break;
                //    case 3: //Dungeon 3
                //        currentLocation = new Tuple<int, int>(0, 0);
                //        break;
                //}
            }

                //public class moveMaker
                //{ 
                // switch (moveMaker.Value);
                //}
                //    public static void youWin()
                //    {

                //    }
                //    public static void youLose()
                //    {

                //    }
                //    private class Character
                //    {

                //        }

                //        public List<string> lookAroundRoom()
                //        {
                //            Room room = dungeon.DungeonLayout[currentLocation];
                //            List<string> targets = new List<string>();
                //            foreach (Monster monster in room.monster)
                //            {
                //                targets.Add(monster.Name);
                //            }
                //            return targets;
                //        }

                //        public Monster targetMonster(ListBox lst)
                //        {
                //            //I think this should be split into two methods
                //            //currently it does two things - sets the monster as the target
                //            //and then returns monster data
                //            Room room = dungeon.DungeonLayout[currentLocation];
                //            target = room.monster[lst.SelectedIndex];
                //            return target;
                //        }
                //    }


                //  
                //        public Monster()
                //        {
                //            Name = $"Monster {autoIncrementID++}";
                //            currentHP = 20;
                //            maximumHP = 20;
                //            level = 1;
                //        }
                //    }

                //    public void MonsterDie(Room room, Monster monster)
                //    {
                //        room.monster = null;
                //    }


                //    public class Dungeon
                //    {
                //        public string Name { get; set; }
                //        public int Value { get; set; }
                //        public Dictionary<Tuple<int, int>, Room> DungeonLayout { get; set; }

                //        public Dungeon(int value)
                //        {
                //            DungeonLayout = new Dictionary<Tuple<int, int>, Room>();

                //            switch (value)
                //            {
                //                case 1:
                //                    Name = "Dungeon 1";
                //                    Value = value;
                //                    DungeonLayout.Add(new Tuple<int, int>(5, 0), new Room(false, false, false, true));
                //                    DungeonLayout.Add(new Tuple<int, int>(4, 0), new Room(false, true, true, false));
                //                    //Code truncated. The rest of this code contains 
                //                    //more lines like the above two 
                //                    //to generate the layout of the dungeon. 
                //            }
                //        }
                //    }
                //}

                //string fileName = @"C:\mydir\myfile.ext";
                //string path = @"C:\mydir\";
                //string result;
                //result = path.GetFileName(fileName);
                //Console.WriteLine("GetFileName('{0}') returns '{1}'",
                //    fileName, result);

                //result = Path.GetFileName(path);
                //Console.WriteLine("GetFileName('{0}') returns '{1}'",
                //path, result);
            }
















//    public static class MaandagClass
//{
//string naam = "Welcome to this game";
//string fileName1 = "c:\\documents\users\test.txt";
//string fileName2 = @c;
//return naam
//return fileName1
//return fileName2
//}

