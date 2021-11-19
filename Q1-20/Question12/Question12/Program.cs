using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write($"\n{i}");
                }

            }
        }
    }
}