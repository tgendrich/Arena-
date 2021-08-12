using System;

namespace Arena_
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity playerClass = null;
            Entity allyClass = null;
            Entity enemyClass = null;
            
            Console.WriteLine("Hello! Welcome to the Arena!");
            Console.WriteLine("Shall you fight today!?     Yes/No");
            string enter = Console.ReadLine();
            if (enter == "Yes")
            {
                Console.WriteLine("Then We Shall Begin!");
                EcounterBuilder builder = new EcounterBuilder();
                 playerClass = builder.PlayerBuild();
                allyClass = builder.AllyBuild();
                enemyClass = builder.EnemyBuild();
                
            }
            else
                Console.WriteLine("Then Begone, Coward!");



            Console.WriteLine("Now, Fight!");


        }
    }
}
