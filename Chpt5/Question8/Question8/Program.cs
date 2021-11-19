using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number('0' for int, '1' for double and '2' for string):");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case (0):
                {
                    Console.Write("\nYou have entered for int");
                    input += 1;
                    Console.Write($"\nInt is {input}");
                    break;
                }
                case (1):
                {
                    Console.Write("\nYou have entered for double");
                    input += 1;
                    Console.Write($"\ndouble is {input}");
                    break;
                }
                case (2):
                {
                    Console.Write("\nYou have entered for string");
                    Console.Write($"\nstring is {input}*");
                    break;
                }
            }
        }
    }
}