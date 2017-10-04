using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Character
    {
        protected int currentHP;
        protected int maxHP;
        protected int DP;
        protected int SP;
        protected bool isDead;

        static Random rnd = new Random();
        protected int d6;

        public int RollDice()
        {
            d6 = rnd.Next(1, 7);
            return d6;
        }

    }
}
