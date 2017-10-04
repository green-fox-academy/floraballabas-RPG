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

        public Hero(FoxDraw foxDraw)
        {
            this.currentHP = maxHP;
            this.maxHP = 20 + 3 * RollDice();
            this.DP = 2 * RollDice();
            this.SP = 5 * RollDice();
            foxDraw.AddImage("./Assets/hero-down.png", startingX, startingY);
        }

        //public static void PlaceHero(FoxDraw foxDraw)
        //{
        //    foxDraw.AddImage("./Assets/hero-down.png", startingX, startingY);
        //}
        public static void HeroDown(FoxDraw foxDraw)
        {
            if (Tile.Matrix[startingY / boardsize + 1][startingX / boardsize])
            {
                Tile.DrawTile(foxDraw, startingX, startingY);
                startingY += boardsize;
            }
            foxDraw.AddImage("./Assets/hero-down.png", startingX, startingY);
        }
        public static void HeroUp(FoxDraw foxDraw)
        {
            if (Tile.Matrix[startingY / boardsize - 1][startingX / boardsize])
            {
                Tile.DrawTile(foxDraw, startingX, startingY);
                startingY -= boardsize;
            }
            foxDraw.AddImage("./Assets/hero-up.png", startingX, startingY);
        }
        public static void HeroLeft(FoxDraw foxDraw)
        {
            if (Tile.Matrix[startingY / boardsize][startingX / boardsize -1])
            {
                Tile.DrawTile(foxDraw, startingX, startingY);
                startingX -= boardsize;
            }
            foxDraw.AddImage("./Assets/hero-left.png", startingX, startingY);
        }
        public static void HeroRight(FoxDraw foxDraw)
        {
            if (Tile.Matrix[startingY / boardsize][startingX / boardsize + 1])
            {
                Tile.DrawTile(foxDraw, startingX, startingY);
                startingX += boardsize;
            }
            foxDraw.AddImage("./Assets/hero-right.png", startingX, startingY);
        }
    }
}
