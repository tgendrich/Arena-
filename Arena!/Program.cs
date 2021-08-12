using System;

namespace Arena_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello! Welcome to the Arena!");
            Console.WriteLine("Shall you fight today!?     Yes/No");
            string enter = Console.ReadLine();
            if (enter == "Yes")
            {
                Console.WriteLine("Then We Shall Begin!");
                EcounterBuilder builder = new EcounterBuilder();
                builder.BuildAttempt();
            }
            else
                Console.WriteLine("Then Begone, Coward!");

            
            
            
        }
    }
}
