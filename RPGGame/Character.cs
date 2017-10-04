using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Character
    {
        protected double currentHP;
        protected double maxHP;
        protected double DP;
        protected double SP;
        protected bool isDead;

        static Random rnd = new Random();
        protected double d6;

        public double RollDice()
        {
            d6 = rnd.Next(1, 7);
            return d6;
        }

    }
}
