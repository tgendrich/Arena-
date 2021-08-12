using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_
{
    public abstract class Entity
    {
        public int HP;
        public int DEF;
        public int attackValue;
        public int damageMod;
        public bool isALive;


        public abstract int Attack();
        

        public int Defend()
        {
            return DEF + 2;
        }

        public abstract int SpecialAttack();
    
    }
}
