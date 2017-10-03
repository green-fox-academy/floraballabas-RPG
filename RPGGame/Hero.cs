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
        private static int startingX = 50;
        private static int startingY = 50;
        private static int boardsize = 50;

        public static void PlaceHero(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-down.png", startingX, startingY);
        }
        public static void HeroDown(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-down.png", startingX, startingY + boardsize);
            startingY += boardsize;
        }
        public static void HeroUp(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-up.png", startingX, startingY - boardsize);
            startingY -= boardsize;
        }
        public static void HeroLeft(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-left.png", startingX - boardsize, startingY);
            startingX -= boardsize;
        }
        public static void HeroRight(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-right.png", startingX + boardsize, startingY);
            startingX += boardsize;
        }
    }
}
