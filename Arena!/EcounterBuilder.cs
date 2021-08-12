using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_
{
    public class EcounterBuilder
    {





        public Entity PlayerBuild()
        {
            
            
            Console.WriteLine("Now then; What is your class? Here is what you can pick from!");

            List<string> classes = new List<string>() { "Warrior" };
            foreach (var item in classes)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();

            bool switchPick = true;
            do
            {
                string classPick = Console.ReadLine();

                switch (classPick)
                {
                    case "Warrior":
                        {
                            Console.WriteLine("You Have Picked Warrior!");
                            return new PlayerClassWarrior();
                        }
                        
                    default:
                        Console.WriteLine("wise guy eh?  Pick a real class!");
                        break;

                }

            } while (switchPick == true);
            Console.WriteLine("somethings goin funky");
            return  new PlayerClassWarrior();
         

        }



         public Entity AllyBuild()
        {

            Console.WriteLine("Now, who shall join you in the Arena? Here Are Your Possible Allies!");

            List<string> allies = new List<string>() { "Frank" };
            foreach (var item in allies)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();
            bool switchPick = true;

            do
            {

                string allyPick = Console.ReadLine();

                switch (allyPick)
                {
                    case "Frank":
                        Console.WriteLine("You Have Picked Frank As Your Ally!");
                        return new Frank();
                       
                        
                    default:
                        Console.WriteLine("wise guy eh?  Pick Someone Already!");

                        break;
                }




            } while (switchPick);
            Console.WriteLine("SOmethings goin funky");
            return new Frank();

        }


        public Entity EnemyBuild()
        {



            Console.WriteLine("Now, Who Shall You Fight!?  Here Are Your Possible Enemies!");
            List<string> enemies = new List<string>() { "Zombie" };
            foreach (var item in enemies)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();

            bool switchPick = true;
            do
            {

                string enemyPick = Console.ReadLine();

                switch (enemyPick)
                {
                    case "Zombie":
                        Console.WriteLine("You Have Picked The Zombie As Your Enemy!");
                        return new ZombieHulk();
                    default:
                        Console.WriteLine("wise guy eh?  Pick Someone to fight Already!");

                        break;
                }




            } while (switchPick);
            Console.WriteLine("Somethin goin funky");
            return new ZombieHulk();

            

            
        } 




    }
    
    
    
    
    
    
    
    
    
}
