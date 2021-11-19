using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int previous = 0;
            int next = 0;
            
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <=n; i++)
            {
                
                int current = i++;
                next = next + i;
                Console.Write($"{i},");
            }
            
        }
    }
}