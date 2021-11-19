using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter a number:");
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;

                if (i==0)
                {
                    min = numbers[i];
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i]<min)
                {
                    min = numbers[i];
                }
                
            }
            Console.Write($"\nThe greatest of given five numbers is {max}");
        }
    }
}