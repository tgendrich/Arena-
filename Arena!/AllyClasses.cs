using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_
{
    public class Frank: Entity
    {
       public int Arrows { get; set; }
       
        public Frank()
        {
            HP = 35;
            DEF = 16;
            attackValue = 8;
            Arrows = 15;
            damageMod = 3;
            isALive = true;
        }

        public override int Attack()
        {
            var randomDiceRoll = new Random();
            var damageDice = randomDiceRoll.Next(1, 6) + damageMod;
            Console.WriteLine("Frank fires a bolt.");
            Console.WriteLine($"frank has done {damageDice} damage!");
            Arrows -= 1;
            return damageDice;
            
            
        }

        public override int SpecialAttack()
        {
            var randomDiceRoll = new Random();
            var damageDice = randomDiceRoll.Next(3, 24) + (damageMod * 3);
            Console.WriteLine("Bolts Fly from Frank's crossbow!");
            Console.WriteLine($"frank has done {damageDice} damage!");
            Arrows -= 3;
            return damageDice;
        }
    }
}
