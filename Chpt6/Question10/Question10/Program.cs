using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter positive integer N (N<20): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i+n-1; j++)
                {
                 Console.Write("{0} ", j);   
                }
                
                Console.WriteLine();
            }
        }
    }
}