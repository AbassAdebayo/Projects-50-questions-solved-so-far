using System;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {
            int countHead = 0;
            int countTail = 0;
            for (decimal i = 1; i < 1000000; i++)
            {
                Random flip = new Random();
                int coinFlipping = flip.Next(1, 1000000);
                

                if (coinFlipping == 1)
                {
                    countHead++;
                }
                else if(coinFlipping==0)
                {
                    countTail++;
                }
            }
            
            Console.Write($"The numbers of heads is {countHead} and the number of tail is {countTail}");
        }
    }
}