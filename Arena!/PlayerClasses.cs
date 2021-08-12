using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_
{
    class PlayerClassWarrior : Entity, Iactions
    {
        int specialAttackCounter { get; set; }
        public PlayerClassWarrior()
        {
             HP = 50;
             DEF = 16 ;
         attackValue = 6;
         damageMod = 4;
         isALive = true;
            specialAttackCounter = 0;       
    
    }

        public override int  Attack()
        {

            var randomDiceRoll = new Random();
            var damageDice = randomDiceRoll.Next(1, 12) + damageMod;
            Console.WriteLine("You slash out with your greataxe!");
            Console.WriteLine($"you have done {damageDice} damage!");
            
            return damageDice;


        }

        public  override int SpecialAttack()
        {
            var randomDiceRoll = new Random();

            if (specialAttackCounter == 0)
            {
                var damageDice = randomDiceRoll.Next(3, 36) + damageMod;
                Console.WriteLine("You slash out with all of your might, but the strain might be too much to handle!");
                Console.WriteLine($"you have done {damageDice} damage!");
                specialAttackCounter++;
                return damageDice;
            }
            else if (specialAttackCounter == 1)
            {
                var damageDice = randomDiceRoll.Next(3, 36) + damageMod;
                Console.WriteLine("You swing once more with all of your strength, but you feel the strain is too much for you now!");
                Console.WriteLine($"you have done {damageDice} damage!");
                specialAttackCounter++;
                return damageDice;

            }
            else if (specialAttackCounter > 1)
            {

                var damageDice = randomDiceRoll.Next(1, 6) + damageMod;
                Console.WriteLine(" you cant swing with such strength anymore!");
                return damageDice;
            }

            else
            {
                Console.WriteLine("Logical error somehow, Zero will be returned");
                return 0;

            }
        
        
        }
    }


}
