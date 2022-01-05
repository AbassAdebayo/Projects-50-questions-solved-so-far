using System;
using System.Collections.Generic;

namespace QUIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] TotalArray =
            {
                {1, 2, 3},
                {4, 5, 6},
                {9, 8, 9}
            };
            
            Console.Write(diagonalDifference(TotalArray));
        }

        public static int diagonalDifference(int[,] arr)
        {
           int length = 3;
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        sum1 += arr[i,j];
                    }

                    if (i == length - j - 1)
                    {
                        sum2 += arr[i, j];
                    }
                }
            }
            
            int result = Math.Abs(sum1 - sum2);
            return result;
        }
    }
}