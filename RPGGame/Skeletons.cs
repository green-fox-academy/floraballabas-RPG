using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Skeletons 
    {
        private static int startingX = 50;
        private static int startingY = 50;
        private static int boardsize = 50;
        static Random rnd = new Random();
        private static List<bool[]> matrixForSkeleton = new List<bool[]>
        {
            new bool[] { false,false,false,false,false,false,false,false,false,false,false,false },
            new bool[] { false, false, true, true, false, true, false, true, true, true, false, false },
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

        
        public Skeletons(FoxDraw foxDraw)
        {
            List<Skeleton> ListOfSkeleton = new List<Skeleton>();
            ListOfSkeleton.Add(new Skeleton(foxDraw));
            ListOfSkeleton[0].PlaceEnemy(foxDraw, rnd, matrixForSkeleton, boardsize);
            ListOfSkeleton.Add(new Skeleton(foxDraw));
            ListOfSkeleton[1].PlaceEnemy(foxDraw, rnd, matrixForSkeleton, boardsize);
            ListOfSkeleton.Add(new Skeleton(foxDraw));
            ListOfSkeleton[2].PlaceEnemy(foxDraw, rnd, matrixForSkeleton, boardsize);

        }

    }
}
