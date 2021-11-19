using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;

            for (int i = 1; i <= 8; i++)
            {
                Console.Write("enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    min = num;
                }
                else if (num>max)
                {
                    max = num;
                }
                else if (num<min)
                {
                    min = num;
                }
            }
            Console.Write($"\nThe smallest of the integers is {min} & the biggest is {max}");
        }
    }
}