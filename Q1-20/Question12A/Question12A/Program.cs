using System;

namespace Question12A
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("it is prime number");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }
        }

    }
}