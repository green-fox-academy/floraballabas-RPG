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
        public Skeleton(FoxDraw foxDraw)
        {
            int number = 1;
            this.currentHP = maxHP;
            this.maxHP = 2 * number * RollDice();
            this.DP = 2 * number/2 * RollDice();
            this.SP = 5 * number * RollDice();
        }

        public void PlaceEnemy(FoxDraw foxDraw, Random rnd, List<bool[]> matrixForSkeleton, int tilesize)
        {
            bool placingIsSuccesful = false;
            do
            {
                int x = rnd.Next(1, 11);
                int y = rnd.Next(1, 11);
                if (matrixForSkeleton[y][x] == true)
                {
                    placingIsSuccesful = true;
                    foxDraw.AddImage("./Assets/skeleton.png", x * tilesize, y * tilesize);
                    matrixForSkeleton[y][x] = false;
                }

            } while (!placingIsSuccesful);
        }
    }
}
