using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Skeleton : Enemy
    {
        public Skeleton()
        {
            int x = 1;
            this.currentHP = maxHP;
            this.maxHP = 2 * x * RollDice();
            this.DP = 2 * x/2 * RollDice();
            this.SP = 5 * x * RollDice();
        }
        public static void PlaceEnemy(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/skeleton.png", 300, 300);
        }
    }
}
