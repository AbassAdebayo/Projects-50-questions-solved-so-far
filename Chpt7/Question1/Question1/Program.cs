using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            int sum;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = 5 * myArray[i];
                Console.Write(myArray[i] +" ");
            }
            
        }
    }
}