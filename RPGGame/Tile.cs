using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Tile
    {
        private static int boardsize = 50;
        private static List<bool[]> matrix = new List<bool[]>
        {
            new bool[] { false,false,false,false,false,false,false,false,false,false,false,false },
            new bool[] { false, true, true, true, false, true, false, true, true, true, true, false },
            new bool[] { false, true, true, true, false, true, false, true, false, false, true, false },
            new bool[] { false, true, false, false, false, true, false, true, false, false, true, false },
            new bool[] { false, true, true, true, true, true, false, true, true, true, true, false },
            new bool[] { false, false, false, false, false, true, false, false, false, false, true, false},
            new bool[] { false, true, false, true, false, true, true, true, true, false, true, false },
            new bool[] { false, true, false, true, false, true, false, false, true, false, true, false },
            new bool[] { false, true, true, true, true, true, false, false, true, true, true, false },
            new bool[] { false, true, false, false, false, true, true, true, true, false, true, false },
            new bool[] { false, true, true, true, false, true, false, false, true, true, true, false },
            new bool[] { false,false,false,false,false,false,false,false,false,false,false,false }
        };
        
        public static void DrawMap(FoxDraw foxDraw)
        {
            int y = 0;
            int x = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                y = i * boardsize;
                for (int j = 0; j < matrix.Count; j++)
                {
                    x = j * boardsize;
                    if (matrix[i][j] == true)
                    {
                        foxDraw.AddImage("./Assets/floor.png", x, y);
                    }
                    else
                    {
                        foxDraw.AddImage("./Assets/wall.png", x, y);
                    }
                }
            }
        }
        public static bool IsWalkable()
        {
            
        }
        //public static void DrawFloor(FoxDraw foxDraw)
        //{
        //    int y = 0;
        //    int x = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        y = i * 50;
        //        for (int j = 0; j < 10; j++)
        //        {
        //            x = j * 50;
        //            foxDraw.AddImage("./Assets/floor.png", x, y);
        //        }
        //    }
        //}
    }
}
