using System;

namespace TableauxMutlidimensionnels
{
    class Program

    {
        static void Main(string[] args)
        {
            int[,] RegularArray = new int[3, 3] {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            int xIndex = 3;
            int Count = 0;
            int yIndex = 0;
            //int CountUp = 0;

            int[][] JaggedArray = new int[3][];

            for (Count = 0; Count <= 2; Count++)
            {
                JaggedArray[yIndex + Count] = new int[xIndex - Count];
            }

            Count = 0;

            for (yIndex = 0; yIndex <= 2; yIndex++)
            {
                for (xIndex = 0; xIndex <= (2-Count); xIndex++)
                { 
                    JaggedArray[yIndex][xIndex] = RegularArray[yIndex, xIndex];
                    
                }

                Count++;
                
            }

            for (int x = 0; x < JaggedArray.Length; x++)
            {
                for (int y = 0; y < JaggedArray[x].Length; y++)
                {
                    
                    Console.WriteLine(JaggedArray[x][y]);
                    
                }
            }
        }
    }
}
