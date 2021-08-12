using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_
{
    class ZombieHulk : Entity
    {
        
        public ZombieHulk()
        {
          HP = 30;
         DEF = 12 ;
         attackValue = 4;
         damageMod = 3;
          isALive = true;
    
        }
        
        
        
        public override int Attack()
        {
            var randomDiceRoll = new Random();
            var damageDice = randomDiceRoll.Next(1, 10) + damageMod;
            Console.WriteLine("The Zombie slames you with its rotten limbs.");
            Console.WriteLine($"The zombie has done {damageDice} damage to     !");
            return damageDice;
        }

        public override int SpecialAttack()
        {
            var randomDiceRoll = new Random();
            var damageDice = randomDiceRoll.Next(1, 10) + damageMod;
            Console.WriteLine("The Zombie slames you with its rotten limbs.");
            Console.WriteLine($"The zombie has done {damageDice} damage to     !");
            return damageDice;
        }
    }
}
