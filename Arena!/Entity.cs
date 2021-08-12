using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_
{
    public  abstract class Entity
    {
        public int HP;
        public int DEF;
        public int attackValue;
        public int damageMod;
        public bool isALive;
        

        abstract public int Attack();


        abstract public int SpecialAttack();
    }
}
