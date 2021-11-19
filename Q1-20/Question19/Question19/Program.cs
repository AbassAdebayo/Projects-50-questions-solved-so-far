using System;

namespace Question19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 40; i++)
            {
                double twoMultiples = Math.Pow(2, i);
                Console.Write($"\n{twoMultiples}");
            }
            
        }
    }
}