using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Hero : Character
    {
        private static int startingX = 0;
        private static int startingY = 0;

        public static void PlaceHero(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-down.png", startingX, startingY);
        }
    }
}
