using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Boss : Enemy
    {
        public Boss (FoxDraw foxDraw)
        {
            int number = 1;
            this.currentHP = maxHP;
            this.maxHP = 2 * number * RollDice() + RollDice();
            this.DP = 2 * number / 2 * RollDice() + RollDice();
            this.SP = 5 * number * RollDice() + number;
            foxDraw.AddImage("./Assets/boss.png", 500, 50);
        }

        //public static void PlaceBoss(FoxDraw foxDraw)
        //{
        //    foxDraw.AddImage("./Assets/boss.png", 500, 50);
        //}
    }
}
