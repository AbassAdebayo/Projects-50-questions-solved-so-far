using System;
using System.Diagnostics.CodeAnalysis;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i%3!=0 && i%7!=0)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}