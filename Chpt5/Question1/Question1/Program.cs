using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            int numbFirst = int.Parse(Console.ReadLine());
            
            Console.Write("enter second number: ");
            int numSecond = int.Parse(Console.ReadLine());

            int c = 0;

            if (numbFirst > numSecond)
            {
                c = numbFirst;
                numbFirst = numSecond;
                numSecond = c;
                
                Console.Write($"{numbFirst},{numSecond}");
            }
            else
            {
                Console.Write($"{numbFirst},{numSecond}");
            }
        }
    }
}